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

        //Crear un sueldo descuento
        internal bool CrearSueldoDescuento(SueldoDescuento sueldoDescuento)
        {
            return sueldoDescuentoDao.CrearSueldoDescuento(sueldoDescuento);
        }

        //Actualizar un sueldo descuento
        internal bool ActualizarSueldoDescuento(SueldoDescuento sueldoDescuento, Dictionary<string, object> parametros)
        {
            return sueldoDescuentoDao.ActualizarSueldoDescuento(sueldoDescuento, parametros);
        }

        //Consultar varios sueldo descuentos por filtros
        internal IList<SueldoDescuento> ObtenerSueldoDescuentos(Dictionary<string, object> parametros = null)
        {
            return sueldoDescuentoDao.ObtenerSueldoDescuentos(parametros);
        }
    }
}
