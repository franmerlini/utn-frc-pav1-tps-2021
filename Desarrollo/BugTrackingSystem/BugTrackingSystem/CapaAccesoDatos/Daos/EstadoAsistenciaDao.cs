using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class EstadoAsistenciaDao
    {
        public IList<EstadoAsistencia> ObtenerEstadosAsistencia(Dictionary<string, object> parametros)
        {
            List<EstadoAsistencia> listadoEstadosAsistencia = new List<EstadoAsistencia>();

            String consultaSQL = string.Concat("  SELECT id_estado_asistencia, ",
                                               "         n_estados_asistencia, ",
                                               "         borrado ",
                                               "  FROM EstadosAsistencia ",
                                               "  WHERE 1 = 1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idEstadoAsistencia"))
                    consultaSQL += " AND (id_estado_asistencia = @idEstadoAsistencia) ";
                if (parametros.ContainsKey("nombreEstadoAsistencia"))
                    consultaSQL += " AND (n_estados_asistencia = @nombreEstadoAsistencia) ";
                if (parametros.ContainsKey("borrado"))
                    consultaSQL += " AND (borrado = 0) ";
            }
            else
            {
                consultaSQL += " AND (borrado = 0) ";
            }

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
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
