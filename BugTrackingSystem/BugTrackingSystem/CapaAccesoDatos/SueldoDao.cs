using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class SueldoDao
    {
        public IList<Sueldo> ObtenerSueldos(Dictionary<string, object> parametros)
        {
            List<Sueldo> listadoSueldos = new List<Sueldo>();

            String consultaSQL = string.Concat(" SELECT s.id_usuario, ",
                                                "         s.fecha, ",
                                                "         s.sueldo_bruto, ",
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
                                                "  FROM Sueldos s ",
                                                "  INNER JOIN Usuarios u ON u.id_usuario = s.id_usuario",
                                                "  INNER JOIN Perfiles p ON p.id_perfil = u.id_perfil",
                                                "  WHERE 1 = 1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("usuario"))
                    consultaSQL += " AND (LOWER(u.usuario) LIKE '%' + LOWER(@usuario) + '%') ";
                if (parametros.ContainsKey("fechaDesde"))
                    consultaSQL += " AND (s.fecha >= @fechaDesde) ";
                if (parametros.ContainsKey("fechaHasta"))
                    consultaSQL += " AND (s.fecha <= @fechaHasta) ";
                if (parametros.ContainsKey("fechaExacta"))
                    consultaSQL += " AND (s.fecha = @fechaExacta) ";
                if (parametros.ContainsKey("sueldoBruto"))
                    consultaSQL += " AND (s.sueldo_bruto = @sueldoBruto) ";
                if (!parametros.ContainsKey("borrado"))
                    consultaSQL += " AND (s.borrado = 0) ";
                //Para consultar por el usuario exacto
                if (parametros.ContainsKey("usuarioExacto"))
                    consultaSQL += " AND (usuario = @usuarioExacto) ";
            }
            else
            {
                consultaSQL += "AND (s.borrado = 0) ";
            }

            consultaSQL += " ORDER BY s.fecha ASC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoSueldos.Add(MapeoObjeto(resultado));
            }

            return listadoSueldos;
        }

        internal bool CrearSueldo(Sueldo sueldo)
        {
            string consultaSQL = " INSERT INTO Sueldos (id_usuario, fecha, sueldo_bruto, borrado)" +
                                 " VALUES (@idUsuario, @fecha, @sueldoBruto, 0)";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", sueldo.Usuario.IdUsuario },
                { "fecha", sueldo.Fecha },
                { "sueldoBruto", sueldo.SueldoBruto }
            };

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario retorna FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarSueldo(Sueldo sueldo)
        {
            string consultaSQL = " UPDATE Sueldos" +
                                 " SET id_usuario = @idUsuario," +
                                 "     fecha = @fecha," +
                                 "     sueldo_bruto = @sueldoBruto," +
                                 "     borrado = @borrado" +
                                 " WHERE id_usuario = @idUsuario";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", sueldo.Usuario.IdUsuario },
                { "fecha", sueldo.Fecha },
                { "sueldoBruto", sueldo.SueldoBruto },
                { "borrado", sueldo.Borrado }
            };

            // Si una fila es afectada por la actualizacion retorna TRUE, de lo contrario FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        private Sueldo MapeoObjeto(DataRow row)
        {
            Sueldo sueldo = new Sueldo
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
                SueldoBruto = (float)Convert.ToDouble(row["sueldo_bruto"].ToString()),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return sueldo;
        }
    }
}