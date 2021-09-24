using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class AsistenciaUsuarioDao
    {
        public IList<AsistenciaUsuario> ObtenerAsistenciasUsuario(Dictionary<string, object> parametros)
        {
            List<AsistenciaUsuario> listadoAsistencias = new List<AsistenciaUsuario>();

            var consultaSQL = String.Concat("SELECT a.id_usuario, ",
                                      "        a.id_asistencia_usuario, ",
                                      "        a.fecha, ",
                                      "        a.hora_ingreso, ",
                                      "        a.hora_salida, ",
                                      "        a.id_estado_asistencia, ",
                                      "        a.comentario,  ",
                                      "        a.borrado, ",
                                      "        e.id_estado_asistencia, ",
                                      "        e.n_estados_asistencia, ",
                                      "        e.borrado, ",
                                      "        u.id_usuario, ",
                                      "        u.id_perfil, ",
                                      "        u.usuario, ",
                                      "        u.password, ",
                                      "        u.email, ",
                                      "        u.estado, ",
                                      "        u.borrado, ",
                                      "        p.id_perfil, ",
                                      "        p.nombre ",
                                      "  FROM AsistenciaUsuarios a",
                                      "  INNER JOIN EstadosAsistencia e ON e.id_estado_asistencia = a.id_estado_asistencia",
                                      "  INNER JOIN Usuarios u ON u.id_usuario = a.id_usuario",
                                      "  INNER JOIN Perfiles p ON p.id_perfil = u.id_perfil",
                                      "  WHERE 1=1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idAsistenciaUsuario"))
                    consultaSQL += " AND (a.id_asistencia_usuario=@idAsistenciaUsuario) ";
                if (parametros.ContainsKey("usuario"))
                    consultaSQL += " AND (LOWER(u.usuario) LIKE '%' + LOWER(@usuario) + '%') ";
                if (parametros.ContainsKey("fechaDesde"))
                    consultaSQL += " AND (fecha>=@fechaDesde) ";
                if (parametros.ContainsKey("fechaHasta"))
                    consultaSQL += " AND (fecha<=@fechaHasta) ";
                if (parametros.ContainsKey("idEstadoAsistencia"))
                    consultaSQL += " AND (e.id_estado_asistencia=@idEstadoAsistencia) ";
                if (!parametros.ContainsKey("borrado"))
                    consultaSQL += " AND (a.borrado=0) ";
                //Para consultar por el usuario exacto
                if (parametros.ContainsKey("usuarioExacto"))
                    consultaSQL += " AND (usuario = @usuarioExacto) ";
            }
            else
                consultaSQL += "AND (a.borrado=0) ";

            consultaSQL += " ORDER BY a.fecha DESC";

            var resultadoConsulta = (DataRowCollection)DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros).Rows;

            foreach (DataRow resultado in resultadoConsulta)
            {
                listadoAsistencias.Add(MapeoObjeto(resultado));
            }

            return listadoAsistencias;
        }

        internal bool CrearAsistenciaUsuario(AsistenciaUsuario asistenciaUsuario)
        {
            string consultaSQL = " INSERT INTO AsistenciaUsuarios (id_usuario, fecha, hora_ingreso, hora_salida, id_estado_asistencia, comentario, borrado) " +
                                 " VALUES (@idUsuario, @fecha, @horaIngreso, @horaSalida, @idEstadoAsistencia, @comentario, 0) ";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", asistenciaUsuario.Usuario.IdUsuario },
                { "fecha", asistenciaUsuario.Fecha },
                { "horaIngreso", asistenciaUsuario.HoraIngreso },
                { "horaSalida", asistenciaUsuario.HoraSalida },
                { "idEstadoAsistencia", asistenciaUsuario.EstadoAsistencia.IdEstadoAsistencia },
                { "comentario", asistenciaUsuario.Comentario }
            };

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario retorna FALSE

            // TODO: VER TEMA DE AÑADIR NULLS DENTRO DE LOS REGISTROS SQL

            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarAsistenciaUsuario(AsistenciaUsuario asistenciaUsuario)
        {
            string consultaSQL = "  UPDATE AsistenciaUsuarios " +
                                 "     SET id_usuario = @idUsuario," +
                                 "         fecha = @fecha, " +
                                 "         hora_ingreso = @horaIngreso, " +
                                 "         hora_salida = @horaSalida, " +
                                 "         id_estado_asistencia = @idEstadoAsistencia, " +
                                 "         comentario = @comentario, " +
                                 "         borrado = @borrado " + 
                                 "   WHERE id_asistencia_usuario = @idAsistenciaUsuario";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", asistenciaUsuario.Usuario.IdUsuario },
                { "fecha", asistenciaUsuario.Fecha },
                { "horaIngreso", asistenciaUsuario.HoraIngreso },
                { "horaSalida", asistenciaUsuario.HoraSalida },
                { "idEstadoAsistencia", asistenciaUsuario.EstadoAsistencia.IdEstadoAsistencia },
                { "comentario", asistenciaUsuario.Comentario },
                { "idAsistenciaUsuario", asistenciaUsuario.IdAsistenciaUsuario },
                { "borrado", asistenciaUsuario.Borrado }
            };

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario retorna FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        private AsistenciaUsuario MapeoObjeto(DataRow row)
        {
            AsistenciaUsuario asistenciaUsuario = new AsistenciaUsuario
            {
                IdAsistenciaUsuario = Convert.ToInt32(row["id_asistencia_usuario"].ToString()),
                Fecha = Convert.ToDateTime(row["fecha"].ToString()),
                HoraIngreso = Convert.ToDateTime(row["hora_ingreso"].ToString()).ToString("HH:mm"),
                HoraSalida = Convert.ToDateTime(row["hora_salida"].ToString()).ToString("HH:mm"),
                Comentario = row["comentario"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString()),

                Usuario = new Usuario
                {
                    IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                    Nombre = row["usuario"].ToString(),
                    Contrasena = row["password"].ToString(),
                    Email = row["email"].ToString(),
                    Estado = row["estado"].ToString(),
                    Borrado = Convert.ToBoolean(row["borrado"].ToString()),

                    Perfil = new Perfil
                    {
                        IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                        Nombre = row["nombre"].ToString()
                    }
                },

                EstadoAsistencia = new EstadoAsistencia
                {
                    IdEstadoAsistencia = Convert.ToInt32(row["id_estado_asistencia"].ToString()),
                    Nombre = row["n_estados_asistencia"].ToString(),
                    Borrado = Convert.ToBoolean(row["borrado"].ToString())
                }
            };

            return asistenciaUsuario;
        }
    }
}