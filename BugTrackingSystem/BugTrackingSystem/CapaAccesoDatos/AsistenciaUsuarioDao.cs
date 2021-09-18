using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class AsistenciaUsuarioDao
    {
        public IList<AsistenciaUsuario> ObtenerConFiltros(Dictionary<string, object> parametros = null)
        {
            List<AsistenciaUsuario> listadoAsistencias = new List<AsistenciaUsuario>();

            var strSql = String.Concat("SELECT a.id_usuario, ",
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

            if (parametros.ContainsKey("usuario"))
                strSql += " AND (LOWER(u.usuario) LIKE '%' + LOWER(@usuario) + '%') ";
            if (parametros.ContainsKey("fechaDesde"))
                strSql += " AND (fecha>=@fechaDesde) ";
            if (parametros.ContainsKey("fechaHasta"))
                strSql += " AND (fecha<=@fechaHasta) ";
            if (parametros.ContainsKey("idEstadoAsistencia"))
                strSql += " AND (e.id_estado_asistencia=@idEstadoAsistencia) ";
            if (parametros.ContainsKey("borrado"))
                strSql += " AND (a.borrado=0) ";
            strSql += " ORDER BY a.fecha DESC";

            var resultadoConsulta = (DataRowCollection)DataManager.ObtenerInstancia().ConsultaSQL(strSql, parametros).Rows;

            foreach (DataRow resultado in resultadoConsulta)
            {
                listadoAsistencias.Add(MapeoObjeto(resultado));
            }

            return listadoAsistencias;
        }

        private AsistenciaUsuario MapeoObjeto(DataRow row)
        {
            AsistenciaUsuario asistenciaUsuario = new AsistenciaUsuario();

            asistenciaUsuario.Usuario = new Usuario();
            asistenciaUsuario.Usuario.IdUsuario = Convert.ToInt32(row["id_usuario"].ToString());
            asistenciaUsuario.Usuario.Nombre = row["usuario"].ToString();
            asistenciaUsuario.Usuario.Contrasena = row["password"].ToString();
            asistenciaUsuario.Usuario.Email = row["email"].ToString();
            asistenciaUsuario.Usuario.Estado = row["estado"].ToString();
            asistenciaUsuario.Usuario.Borrado = Convert.ToBoolean(row["borrado"].ToString());

            asistenciaUsuario.Usuario.Perfil = new Perfil();
            asistenciaUsuario.Usuario.Perfil.IdPerfil = Convert.ToInt32(row["id_perfil"].ToString());
            asistenciaUsuario.Usuario.Perfil.Nombre = row["nombre"].ToString();

            asistenciaUsuario.Fecha = Convert.ToDateTime(row["fecha"].ToString());
            asistenciaUsuario.HoraIngreso = Convert.ToDateTime(row["hora_ingreso"].ToString());
            asistenciaUsuario.HoraSalida = Convert.ToDateTime(row["hora_salida"].ToString());

            asistenciaUsuario.EstadoAsistencia = new EstadoAsistencia();
            asistenciaUsuario.EstadoAsistencia.IdEstadoAsistencia = Convert.ToInt32(row["id_estado_asistencia"].ToString());
            asistenciaUsuario.EstadoAsistencia.Nombre = row["n_estados_asistencia"].ToString();
            asistenciaUsuario.EstadoAsistencia.Borrado = Convert.ToBoolean(row["borrado"].ToString());

            asistenciaUsuario.Comentario = row["comentario"].ToString();

            asistenciaUsuario.Borrado = Convert.ToBoolean(row["borrado"].ToString());

            return asistenciaUsuario;
        }
    }
}