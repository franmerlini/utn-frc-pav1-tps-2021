using BugTrackingSystem.CapaAccesoDatos.Daos;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.CapaLogicaNegocio.Services
{
    class SueldoPerfilHistoricoService
    {
        private readonly SueldoPerfilHistoricoDao sueldoPerfilHistoricoDao;

        public SueldoPerfilHistoricoService()
        {
            sueldoPerfilHistoricoDao = new SueldoPerfilHistoricoDao();
        }

        internal IList<SueldoPerfilHistorico> ObtenerSueldosPerfilHistorico(Dictionary<string, object> parametros = null)
        {
            return sueldoPerfilHistoricoDao.ObtenerSueldosPerfilHistorico(parametros);
        }


    }
}
