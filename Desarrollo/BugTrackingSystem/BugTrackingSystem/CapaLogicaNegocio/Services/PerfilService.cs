using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    class PerfilService
    {
        private readonly PerfilDao perfilDao = new PerfilDao();

        public IList<Perfil> ObtenerPerfiles(Dictionary<string, object> parametros = null)
        {
            return perfilDao.ObtenerPerfiles(parametros);
        }
    }
}
