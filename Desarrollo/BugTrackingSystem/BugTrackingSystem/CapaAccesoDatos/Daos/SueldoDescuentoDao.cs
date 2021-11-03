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
                                            "         u.id_usuario, ",
                                            "         u.id_perfil, ",
                                            "         u.usuario, ",
                                            "         u.password, ",
                                            "         u.email, ",
                                            "         u.estado, ",
                                            "         u.borrado, ",
                                            "         p.id_perfil, ",
                                            "         p.nombre, ",
                                            "         d.n_descuento, ",
                                            "         d.monto ",
                                            "  FROM SueldoDescuentos s",
                                            "  INNER JOIN Descuentos d ON d.id_descuento = s.id_descuento",
                                            "  INNER JOIN Usuarios u ON u.id_usuario = s.id_usuario",
                                            "  INNER JOIN Perfiles p ON p.id_perfil = u.id_perfil",
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
                if (parametros.ContainsKey("fechaExacta"))
                    consultaSQL += " AND (s.fecha = @fechaExacta) ";
                if (parametros.ContainsKey("monto"))
                    consultaSQL += " AND (s.monto = @monto) ";
                if (parametros.ContainsKey("cantidad"))
                    consultaSQL += " AND (s.cantidad = @cantidad) ";
                if (parametros.ContainsKey("usuarioExacto"))
                    consultaSQL += " AND (u.usuario = @usuarioExacto) ";
                if (parametros.ContainsKey("idDescuento"))
                    consultaSQL += " AND (s.id_descuento = @idDescuento) ";
            }

            consultaSQL += " ORDER BY s.fecha DESC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoSueldoDescuentos.Add(MapeoObjeto(resultado));
            }

            return listadoSueldoDescuentos;
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
                    Monto = Convert.ToDecimal(row["monto"].ToString()),
                    Borrado = Convert.ToBoolean(row["borrado"].ToString())
                },

                Monto = Convert.ToDecimal(row["monto"].ToString()),
                Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
            };

            return sueldoDescuento;
        }
    }
}