using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System.Collections.Generic;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class SueldoService
    {
        //-------------------------------------------------------Atributos-------------------------------------------------------
        private readonly SueldoDao sueldoDao;

        //--------------------------------------------------------Metodos--------------------------------------------------------
        //Constructor
        public SueldoService()
        {
            sueldoDao = new SueldoDao();
        }

        //Crear un sueldo
        internal bool CrearSueldo(Sueldo sueldo)
        {
            return sueldoDao.CrearSueldo(sueldo);
        }

        //Actualizar un sueldo
        internal bool ActualizarSueldo(Sueldo sueldo)
        {
            return sueldoDao.ActualizarSueldo(sueldo);
        }

        //Consultar varios sueldos por filtros
        internal IList<Sueldo> ObtenerSueldos(Dictionary<string, object> parametros = null)
        {
            return sueldoDao.ObtenerSueldos(parametros);
        }
    }
}
