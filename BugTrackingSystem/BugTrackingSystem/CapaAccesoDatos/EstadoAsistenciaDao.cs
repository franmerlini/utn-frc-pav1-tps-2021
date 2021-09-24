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
    public class EstadoAsistenciaDao
    {
        public IList<EstadoAsistencia> ObtenerEstadosAsistencia(Dictionary<string, object> parametros)
        {
            List<EstadoAsistencia> listadoEstadosAsistencia = new List<EstadoAsistencia>();

            var strSql = String.Concat("SELECT id_estado_asistencia, ",
                                      "        n_estados_asistencia, ",
                                      "        borrado ",
                                      "  FROM EstadosAsistencia ",
                                      "  WHERE 1=1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idEstadoAsistencia"))
                    strSql += " AND (id_estado_asistencia=@idEstadoAsistencia) ";
                if (parametros.ContainsKey("nombreEstadoAsistencia"))
                    strSql += " AND (n_estados_asistencia=@nombreEstadoAsistencia) ";
                if (parametros.ContainsKey("borrado"))
                    strSql += " AND (borrado=0) ";
            }
            else
                strSql += " AND (borrado=0) ";

            var resultadoConsulta = (DataRowCollection)DataManager.ObtenerInstancia().ConsultaSQL(strSql, parametros).Rows;

            foreach (DataRow resultado in resultadoConsulta)
            {
                listadoEstadosAsistencia.Add(MapeoObjeto(resultado));
            }

            return listadoEstadosAsistencia;
        }

        private EstadoAsistencia MapeoObjeto(DataRow row)
        {
            EstadoAsistencia estadoAsistencia = new EstadoAsistencia
            {
                IdEstadoAsistencia = Convert.ToInt32(row["id_estado_asistencia"].ToString()),
                Nombre = row["n_estados_asistencia"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return estadoAsistencia;
        }
    }
}
