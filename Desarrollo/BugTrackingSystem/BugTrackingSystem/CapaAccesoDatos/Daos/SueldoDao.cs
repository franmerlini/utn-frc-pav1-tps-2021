using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

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
                if (parametros.ContainsKey("idUsuario"))
                    consultaSQL += " AND (s.id_usuario = @idUsuario) ";
                //Para consultar por el usuario exacto
                if (parametros.ContainsKey("usuarioExacto"))
                    consultaSQL += " AND (usuario = @usuarioExacto) ";
            }

            consultaSQL += " ORDER BY s.fecha DESC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoSueldos.Add(MapeoObjeto(resultado));
            }

            return listadoSueldos;
        }

        internal int CrearSueldoTransaccion(Sueldo sueldo, BindingList<SueldoAsignacion> listaSueldoAsignacion, BindingList<SueldoDescuento> listaSueldoDescuento, SueldoPerfilHistorico sueldoPerfilHistorico)
        {
            var string_conexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=BugTrackerTPI;Integrated Security=True";

            SqlConnection dbConnection = new SqlConnection();
            SqlTransaction dbTransaction = null;
            try
            {
                dbConnection.ConnectionString = string_conexion;
                dbConnection.Open();
                dbTransaction = dbConnection.BeginTransaction();

                SqlCommand insertSueldo = new SqlCommand
                {
                    Connection = dbConnection,
                    CommandType = CommandType.Text,
                    Transaction = dbTransaction,

                    CommandText = " INSERT INTO Sueldos (id_usuario, fecha, sueldo_bruto)" +
                                           " VALUES (@id_usuario, @fecha, @sueldo_bruto) "
                };

                insertSueldo.Parameters.AddWithValue("id_usuario", sueldo.Usuario.IdUsuario);
                insertSueldo.Parameters.AddWithValue("fecha", sueldo.Fecha.ToString("yyyy-MM-dd"));
                insertSueldo.Parameters.AddWithValue("sueldo_bruto", sueldo.SueldoBruto);

                insertSueldo.ExecuteNonQuery();

                foreach (SueldoAsignacion s in listaSueldoAsignacion)
                {
                    SqlCommand insertAsignacion = new SqlCommand
                    {
                        Connection = dbConnection,
                        CommandType = CommandType.Text,
                        Transaction = dbTransaction,

                        CommandText = " INSERT INTO SueldoAsignaciones (id_usuario, fecha, id_asignacion, monto, cantidad) " +
                                                   " VALUES (@id_usuario, @fecha, @id_asignacion, @monto, @cantidad) "
                    };

                    insertAsignacion.Parameters.AddWithValue("id_usuario", s.Usuario.IdUsuario);
                    insertAsignacion.Parameters.AddWithValue("fecha", s.Fecha.ToString("yyyy-MM-dd"));
                    insertAsignacion.Parameters.AddWithValue("id_asignacion", s.Asignacion.IdAsignacion);
                    insertAsignacion.Parameters.AddWithValue("monto", s.Monto);
                    insertAsignacion.Parameters.AddWithValue("cantidad", s.Cantidad);

                    insertAsignacion.ExecuteNonQuery();
                }

                foreach (SueldoDescuento s in listaSueldoDescuento)
                {
                    SqlCommand insertDescuento = new SqlCommand
                    {
                        Connection = dbConnection,
                        CommandType = CommandType.Text,
                        Transaction = dbTransaction,

                        CommandText = " INSERT INTO SueldoDescuentos (id_usuario, fecha, id_descuento, monto, cantidad) " +
                                                   " VALUES (@id_usuario, @fecha, @id_descuento, @monto, @cantidad) "
                    };

                    insertDescuento.Parameters.AddWithValue("id_usuario", s.Usuario.IdUsuario);
                    insertDescuento.Parameters.AddWithValue("fecha", s.Fecha.ToString("yyyy-MM-dd"));
                    insertDescuento.Parameters.AddWithValue("id_descuento", s.Descuento.IdDescuento);
                    insertDescuento.Parameters.AddWithValue("monto", s.Monto);
                    insertDescuento.Parameters.AddWithValue("cantidad", s.Cantidad);

                    insertDescuento.ExecuteNonQuery();
                }

                if (sueldoPerfilHistorico != null)
                {
                    SqlCommand insertSPH = new SqlCommand
                    {
                        Connection = dbConnection,
                        CommandType = CommandType.Text,
                        Transaction = dbTransaction,

                        CommandText = "IF NOT EXISTS (SELECT * FROM SueldoPerfilHistorico " +
                                                "WHERE id_perfil = @idPerfil " +
                                                "AND fecha = @fecha) " +
                                             "BEGIN " +
                                                "INSERT INTO SueldoPerfilHistorico (id_perfil, fecha, sueldo) " +
                                                "VALUES (@idPerfil, @fecha, @sueldo) " +
                                             "END " +
                                             "ELSE " +
                                             "BEGIN " +
                                                "UPDATE SueldoPerfilHistorico " +
                                                "SET sueldo = @sueldo " +
                                                "WHERE id_perfil = @idPerfil " +
                                                "AND fecha = @fecha " +
                                             "END"
                    };

                    insertSPH.Parameters.AddWithValue("idPerfil", sueldoPerfilHistorico.Perfil.IdPerfil);
                    insertSPH.Parameters.AddWithValue("fecha", sueldoPerfilHistorico.Fecha.ToString("yyyy-MM-dd"));
                    insertSPH.Parameters.AddWithValue("sueldo", sueldoPerfilHistorico.Sueldo);

                    insertSPH.ExecuteNonQuery();
                }

                dbTransaction.Commit();
            }
            catch (SqlException ex)
            {
                dbTransaction.Rollback();
                if (ex.Message.Contains("Arithmetic overflow"))
                    return 1;
                throw ex;
            }
            return 0;
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
                SueldoBruto = Convert.ToDecimal(row["sueldo_bruto"].ToString()),
            };

            return sueldo;
        }
    }
}