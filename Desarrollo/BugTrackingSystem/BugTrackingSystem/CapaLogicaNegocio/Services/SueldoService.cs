using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System.Collections.Generic;
using System.ComponentModel;

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

        //Consultar varios sueldos por filtros
        internal IList<Sueldo> ObtenerSueldos(Dictionary<string, object> parametros = null)
        {
            return sueldoDao.ObtenerSueldos(parametros);
        }

        // Crear una transacción de sueldo
        internal int CrearSueldoTransaccion(Sueldo sueldo, BindingList<SueldoAsignacion> listaSueldoAsignacion, BindingList<SueldoDescuento> listaSueldoDescuento, SueldoPerfilHistorico sueldoPerfilHistorico)
        {
            return sueldoDao.CrearSueldoTransaccion(sueldo, listaSueldoAsignacion, listaSueldoDescuento, sueldoPerfilHistorico);
        }
    }
}
