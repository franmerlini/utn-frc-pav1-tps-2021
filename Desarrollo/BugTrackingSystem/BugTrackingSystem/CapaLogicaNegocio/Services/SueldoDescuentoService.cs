using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System.Collections.Generic;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class SueldoDescuentoService
    {
        //-------------------------------------------------------Atributos-------------------------------------------------------
        private readonly SueldoDescuentoDao sueldoDescuentoDao;

        //--------------------------------------------------------Metodos--------------------------------------------------------
        //Constructor
        public SueldoDescuentoService()
        {
            sueldoDescuentoDao = new SueldoDescuentoDao();
        }

        //Consultar varios sueldo descuentos por filtros
        internal IList<SueldoDescuento> ObtenerSueldoDescuentos(Dictionary<string, object> parametros = null)
        {
            return sueldoDescuentoDao.ObtenerSueldoDescuentos(parametros);
        }
    }
}
