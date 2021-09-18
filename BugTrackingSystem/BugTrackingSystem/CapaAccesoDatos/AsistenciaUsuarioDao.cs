using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class AsistenciaUsuarioDao
    {
        public IList<AsistenciaUsuario> ObtenerTodos()
        {
            List<AsistenciaUsuario> listadoAsistencias = new List<AsistenciaUsuario>();

            String consultaSQL = string.Concat(" SELECT id_usuario, ",
                                          "        fecha, ",
                                          "        hora_ingreso, ",
                                          "        hora_salida, ",
                                          "        id_estado_asistencia, ",
                                          "        comentario ",
                                          "   FROM AsistenciaUsuarios a",
                                          "  INNER JOIN Usuarios u ON u.id_usuario = a.id_usuario ");

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoAsistencias.Add(MapeoObjeto(resultado));
            }

            return listadoAsistencias;
        }

        public IList<AsistenciaUsuario> ObtenerConFiltros(Dictionary<string, object> parametros)
        {
            List<AsistenciaUsuario> listadoAsistencias = new List<AsistenciaUsuario>();

            var strSql = String.Concat("SELECT a.id_usuario, ",
                                      "        a.fecha,",
                                      "        a.hora_ingreso,",
                                      "        a.hora_salida,",
                                      "        a.id_estado_asistencia,",
                                      "        a.comentario,  ",
                                      "  FROM AsistenciaUsuarios as a",
                                      "  INNER JOIN EstadosAsistencia as e ON e.id_estado_asistencia = a.id_estado_asistencia",
                                      "  INNER JOIN Usuarios as u ON u.id_usuario = a.id_usuario",
                                      "  WHERE 1=1 ");

            if (parametros.ContainsKey("idUsuario"))
                strSql += " AND (a.id_usuario=@idUsuario) ";
            if (parametros.ContainsKey("fecha"))
                strSql += " AND (a.fecha=@fecha) ";
            if (parametros.ContainsKey("horaIngreso"))
                strSql += " AND (a.hora_ingreso=@horaIngreso) ";
            if (parametros.ContainsKey("horaSalida"))
                strSql += " AND (a.hora_salida=@horaSalida)  ";
            if (parametros.ContainsKey("idEstadoAsistencia"))
                strSql += " AND (e.id_estado_asistencia=@idEstadoAsistencia) ";
            strSql += " ORDER BY a.fecha DESC";

            var resultadoConsulta = (DataRowCollection)DataManager.ObtenerInstancia().ConsultaSQL(strSql, parametros).Rows;

            foreach (DataRow resultado in resultadoConsulta)
            {
                listadoAsistencias.Add(ObjectMapping(row));
            }

            return listadoAsistencias;
        }

        private AsistenciaUsuario MapeoObjeto(DataRow row)
        {
            AsistenciaUsuario asistenciaUsuario = new AsistenciaUsuario
            {
                AsistenciaUsuario asistenciaUsuario = new AsistenciaUsuario();

            asistenciaUsuario.Usuario = new Usuario();
            asistenciaUsuario.Usuario.IdUsuario = Convert.ToInt32(row["id_usuario"].ToString());
            asistenciaUsuario.Usuario.Nombre = row["usuario"].ToString();
            asistenciaUsuario.Usuario.Contrasena = row["password"].ToString();
            asistenciaUsuario.Usuario.Email = row["email"].ToString();
            asistenciaUsuario.Usuario.Estado = row["estado"].ToString();

            asistenciaUsuario.Usuario.Perfil = new Perfil();
            asistenciaUsuario.Usuario.Perfil.IdPerfil = Convert.ToInt32(row["id_perfil"].ToString());
            asistenciaUsuario.Usuario.Perfil.nombre = row["nombre"].ToString();

            asistenciaUsuario.Fecha =
        };
            return asistenciaUsuario;
        }
}

public Usuario Usuario { get; set; }
public DateTime Fecha { get; set; }
public DateTime HoraIngreso { get; set; }
public DateTime HoraSalida { get; set; }
public EstadoAsistencia EstadoAsistencia { get; set; }
public string Comentario { get; set; }