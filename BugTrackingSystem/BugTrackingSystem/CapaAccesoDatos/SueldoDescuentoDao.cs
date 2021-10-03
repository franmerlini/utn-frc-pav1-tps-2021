using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class SueldoDescuentoDao
    {
        public IList<SueldoDescuento> ObtenerSueldoDescuentos(Dictionary<string, object> parametros)
        {
            List<SueldoDescuento> listadoSueldoDescuentos = new List<SueldoDescuento>();

            var consultaSQL = String.Concat("  SELECT s.id_usuario, ",
                                            "         s.fecha, ",
                                            "         s.id_descuento, ",
                                            "         s.cantidad, ",
                                            "         s.monto, ",
                                            "         s.borrado, ",
                                            "         u.id_usuario, ",
                                            "         u.id_perfil, ",
                                            "         u.usuario, ",
                                            "         u.password, ",
                                            "         u.email, ",
                                            "         u.estado, ",
                                            "         u.borrado, ",
                                            "         p.id_perfil, ",
                                            "         p.nombre ",
                                            "  FROM SueldoDescuentos s",
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
                if (parametros.ContainsKey("s.borrado"))
                    consultaSQL += " AND (borrado = 0) ";
            }
            else
            {
                consultaSQL += "AND (s.borrado = 0) ";
            }

            consultaSQL += " ORDER BY s.fecha DESC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoSueldoDescuentos.Add(MapeoObjeto(resultado));
            }

            return listadoSueldoDescuentos;
        }

        internal bool CrearSueldoDescuento(SueldoDescuento sueldoDescuento)
        {
            string consultaSQL = " INSERT INTO SueldoAsignaciones (id_usuario, fecha, id_descuento, cantidad, monto, borrado)" +
                                 " VALUES (@idUsuario, @fecha, @idDescuento, cantidad, monto, 0)";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", sueldoDescuento.Usuario.IdUsuario },
                { "fecha", sueldoDescuento.Fecha },
                { "idDescuento", sueldoDescuento.Descuento.IdDescuento },
                { "cantidad", sueldoDescuento.Cantidad },
                { "monto", sueldoDescuento.Monto }
            };

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario retorna FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarSueldoDescuento(SueldoDescuento sueldoDescuento)
        {
            string consultaSQL = " UPDATE SueldoAsignaciones" +
                                 " SET id_usuario = @idUsuario," +
                                 "     fecha = @fecha," +
                                 "     id_descuento = @idDescuento," +
                                 "     cantidad = @cantidad," +
                                 "     monto = @monto," +
                                 "     borrado = @borrado" +
                                 " WHERE id_usuario = @idUsuario";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", sueldoDescuento.Usuario.IdUsuario },
                { "fecha", sueldoDescuento.Fecha },
                { "idDescuento", sueldoDescuento.Descuento.IdDescuento },
                { "cantidad", sueldoDescuento.Cantidad },
                { "monto", sueldoDescuento.Monto },
                { "borrado", sueldoDescuento.Borrado }
            };

            // Si una fila es afectada por la actualizacion retorna TRUE, de lo contrario FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        private SueldoDescuento MapeoObjeto(DataRow row)
        {
            SueldoDescuento sueldoDescuento = new SueldoDescuento
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

                Descuento = new Descuento
                {
                    IdDescuento = Convert.ToInt32(row["id_descuento"].ToString()),
                    Nombre = row["n_descuento"].ToString(),
                    Monto = (float)Convert.ToDouble(row["monto"].ToString()),
                    Borrado = Convert.ToBoolean(row["borrado"].ToString())
                },

                Monto = (float)Convert.ToDouble(row["monto"].ToString()),
                Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return sueldoDescuento;
        }
    }
}