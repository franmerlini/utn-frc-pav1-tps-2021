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
                                            "        u.id_usuario, ",
                                            "        u.id_perfil, ",
                                            "        u.usuario, ",
                                            "        u.password, ",
                                            "        u.email, ",
                                            "        u.estado, ",
                                            "        u.borrado, ",
                                            "        p.id_perfil, ",
                                            "        p.nombre, ",
                                            "        a.n_asignacion, ",
                                            "        a.monto ",
                                            "  FROM SueldoAsignaciones s",
                                            "  INNER JOIN Usuarios u ON u.id_usuario = s.id_usuario",
                                            "  INNER JOIN Perfiles p ON p.id_perfil = u.id_perfil",
                                            "  INNER JOIN Asignaciones a ON a.id_asignacion = s.id_asignacion",
                                            "  WHERE 1 = 1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idUsuario"))
                    consultaSQL += " AND (s.id_usuario = @idUsuario) ";
                if (parametros.ContainsKey("usuario"))
                    consultaSQL += " AND (LOWER(u.usuario) LIKE '%' + LOWER(@usuario) + '%') ";
                if (parametros.ContainsKey("fechaDesde"))
                    consultaSQL += " AND (s.fecha >= @fechaDesde) ";
                if (parametros.ContainsKey("fechaHasta"))
                    consultaSQL += " AND (s.fecha <= @fechaHasta) ";
                if (parametros.ContainsKey("monto"))
                    consultaSQL += " AND (s.monto = @monto) ";
                if (parametros.ContainsKey("fechaExacta"))
                    consultaSQL += " AND (s.fecha = @fechaExacta) ";
                if (parametros.ContainsKey("cantidad"))
                    consultaSQL += " AND (s.cantidad = @cantidad) ";
                if (parametros.ContainsKey("usuarioExacto"))
                    consultaSQL += " AND (u.usuario = @usuarioExacto) ";
                if (parametros.ContainsKey("idAsignacion"))
                    consultaSQL += " AND (s.id_asignacion = @idAsignacion) ";
            }

            consultaSQL += " ORDER BY s.fecha DESC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoSueldoAsignaciones.Add(MapeoObjeto(resultado));
            }

            return listadoSueldoAsignaciones;
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
                    Monto = Convert.ToDecimal(row["monto"].ToString()),
                },

                Monto = Convert.ToDecimal(row["monto"].ToString()),
                Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
            };

            return sueldoAsignacion;
        }
    }
}