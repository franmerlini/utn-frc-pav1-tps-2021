using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class AsistenciaUsuarioService
    {
        //---Atributos---
        private AsistenciaUsuarioDao asistenciaUsuarioDao;

        //---Metodos---
        //Constructor
        public AsistenciaUsuarioService()
        {
            asistenciaUsuarioDao = new AsistenciaUsuarioDao();
        }

        // Búsqueda filtrada
        public IList<AsistenciaUsuario> ObtenerConFiltros(Dictionary<string, object> parametros = null)
        {
            return asistenciaUsuarioDao.ObtenerConFiltros(parametros);
        }

    }
}
