using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System.Collections.Generic;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class AsignacionService
    {
        //-------------------------------------------------------Atributos-------------------------------------------------------
        private readonly AsignacionDao asignacionDao;

        //--------------------------------------------------------Metodos--------------------------------------------------------
        //Constructor
        public AsignacionService()
        {
            asignacionDao = new AsignacionDao();
        }

        //Consultar varias asignaciones por filtros
        internal IList<Asignacion> ObtenerAsignaciones(Dictionary<string, object> parametros = null)
        {
            return asignacionDao.ObtenerAsignaciones(parametros);
        }
    }
}
