using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System.Collections.Generic;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class SueldoAsignacionService
    {
        //-------------------------------------------------------Atributos-------------------------------------------------------
        private readonly SueldoAsignacionDao sueldoAsignacionDao;

        //--------------------------------------------------------Metodos--------------------------------------------------------
        //Constructor
        public SueldoAsignacionService()
        {
            sueldoAsignacionDao = new SueldoAsignacionDao();
        }

        //Consultar varias asignaciones de sueldo por filtros
        internal IList<SueldoAsignacion> ObtenerSueldoAsignaciones(Dictionary<string, object> parametros = null)
        {
            return sueldoAsignacionDao.ObtenerSueldoAsignaciones(parametros);
        }
    }
}
