using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System.Collections.Generic;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class EstadoAsistenciaService
    {
        //-------------------------------------------------------Atributos-------------------------------------------------------
        private readonly EstadoAsistenciaDao estadoAsistenciaDao;

        //--------------------------------------------------------Metodos--------------------------------------------------------
        //Constructor
        public EstadoAsistenciaService()
        {
            estadoAsistenciaDao = new EstadoAsistenciaDao();
        }

        //Consultar varios estados de asistencia por filtros
        public IList<EstadoAsistencia> ObtenerEstadosAsistencia(Dictionary<string, object> parametros = null)
        {
            return estadoAsistenciaDao.ObtenerEstadosAsistencia(parametros);
        }
    }
}
