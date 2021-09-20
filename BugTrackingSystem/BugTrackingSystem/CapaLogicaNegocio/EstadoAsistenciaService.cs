using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class EstadoAsistenciaService
    {
        private readonly EstadoAsistenciaDao estadoAsistenciaDao;

        public EstadoAsistenciaService()
        {
            estadoAsistenciaDao = new EstadoAsistenciaDao();
        }

        public IList<EstadoAsistencia> ObtenerEstadosAsistencia(Dictionary<string, object> parametros = null)
        {
            return estadoAsistenciaDao.ObtenerEstadosAsistencia(parametros);
        }
    }
}
