using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class SueldoAsignacionDao
    {
        public IList<SueldoAsignacion> ObtenerSueldoAsignaciones(Dictionary<string, object> parametros)
        {
            List<SueldoAsignacion> listadoSueldoAsignaciones = new List<SueldoAsignacion>();

            var consultaSQL = String.Concat("  SELECT s.id_usuario, ",
                                            "        s.fecha, ",
                                            "        s.id_asignacion, ",
                                            "        s.monto, ",
                                            "        s.cantidad, ",
                                            "        s.borrado, ",
                                            "        u.id_usuario, ",
                                            "        u.id_perfil, ",
                                            "        u.usuario, ",
                                            "        u.password, ",
                                            "        u.email, ",
                                            "        u.estado, ",
                                            "        u.borrado, ",
                                            "        p.id_perfil, ",
                                            "        p.nombre ",
                                            "  FROM SueldoAsignaciones s",
                                            "  INNER JOIN Usuarios u ON u.id_usuario = s.id_usuario",
                                            "  INNER JOIN Perfiles p ON p.id_perfil = u.id_perfil",
                                            "  WHERE 1 = 1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idUsuario"))
                    consultaSQL += " AND (s.id_usuario = @idUsuario) ";
                if (parametros.ContainsKey("fecha"))
                    consultaSQL += " AND (s.fecha = @fecha) ";
                if (parametros.ContainsKey("monto"))
                    consultaSQL += " AND (s.monto = @monto) ";
                if (parametros.ContainsKey("cantidad"))
                    consultaSQL += " AND (s.cantidad = @cantidad) ";
                if (parametros.ContainsKey("borrado"))
                    consultaSQL += " AND (s.borrado = 0) ";
            }
            else
            {
                consultaSQL += "AND (s.borrado = 0) ";
            }

            consultaSQL += " ORDER BY s.fecha DESC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoSueldoAsignaciones.Add(MapeoObjeto(resultado));
            }

            return listadoSueldoAsignaciones;
        }

        internal bool CrearSueldoAsignacion(SueldoAsignacion sueldoAsignacion)
        {
            string consultaSQL = " INSERT INTO SueldoAsignaciones (id_usuario, fecha, id_asignacion, monto, cantidad, borrado)" +
                                 " VALUES (@idUsuario, @fecha, @idAsignacion, monto, cantidad, 0)";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", sueldoAsignacion.Usuario.IdUsuario },
                { "fecha", sueldoAsignacion.Fecha },
                { "idAsignacion", sueldoAsignacion.Asignacion.IdAsignacion },
                { "monto", sueldoAsignacion.Monto },
                { "cantidad", sueldoAsignacion.Cantidad }
            };

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario retorna FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarSueldoAsignacion(SueldoAsignacion sueldoAsignacion)
        {
            string consultaSQL = " UPDATE SueldoAsignaciones" +
                                 " SET id_usuario = @idUsuario," +
                                 "     fecha = @fecha," +
                                 "     id_asignacion = @idAsignacion," +
                                 "     monto = @monto," +
                                 "     cantidad = @cantidad," +
                                 "     borrado = @borrado" +
                                 " WHERE id_usuario = @idUsuario";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", sueldoAsignacion.Usuario.IdUsuario },
                { "fecha", sueldoAsignacion.Fecha },
                { "idAsignacion", sueldoAsignacion.Asignacion.IdAsignacion },
                { "monto", sueldoAsignacion.Monto },
                { "cantidad", sueldoAsignacion.Cantidad },
                { "borrado", sueldoAsignacion.Borrado }
            };

            // Si una fila es afectada por la actualizacion retorna TRUE, de lo contrario FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        private SueldoAsignacion MapeoObjeto(DataRow row)
        {
            SueldoAsignacion sueldoAsignacion = new SueldoAsignacion
            {
                Usuario = new Usuario
                {
                    IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                    Nombre = row["usuario"].ToString(),
                    Email = row["email"].ToString(),
                    Contrasena = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                    Perfil = new Perfil()
                    {
                        IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                        Nombre = row["nombre"].ToString(),
                    }
                },

                Fecha = Convert.ToDateTime(row["fecha"].ToString()),

                Asignacion = new Asignacion
                {
                    IdAsignacion = Convert.ToInt32(row["id_asignacion"].ToString()),
                    Nombre = row["n_asignacion"].ToString(),
                    Monto = (float)Convert.ToDouble(row["monto"].ToString()),
                    Borrado = Convert.ToBoolean(row["borrado"].ToString())
                },

                Monto = (float)Convert.ToDouble(row["monto"].ToString()),
                Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return sueldoAsignacion;
        }
    }
}