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

        //Crear una asignacion de sueldo
        internal bool CrearSueldoAsignacion(SueldoAsignacion sueldoAsignacion)
        {
            return sueldoAsignacionDao.CrearSueldoAsignacion(sueldoAsignacion);
        }

        //Actualizar una asignacion de sueldo
        internal bool ActualizarSueldoAsignacion(SueldoAsignacion sueldoAsignacion)
        {
            return sueldoAsignacionDao.ActualizarSueldoAsignacion(sueldoAsignacion);
        }

        //Consultar varias asignaciones de sueldo por filtros
        internal IList<SueldoAsignacion> ObtenerSueldoAsignaciones(Dictionary<string, object> parametros = null)
        {
            return sueldoAsignacionDao.ObtenerSueldoAsignaciones(parametros);
        }
    }
}
