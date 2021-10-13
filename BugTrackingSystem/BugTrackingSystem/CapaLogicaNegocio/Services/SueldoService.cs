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

        //Crear un sueldo
        internal bool CrearSueldo(Sueldo sueldo)
        {
            return sueldoDao.CrearSueldo(sueldo);
        }

        //Actualizar un sueldo
        internal bool ActualizarSueldo(Sueldo sueldo, Dictionary<string, object> parametros)
        {
            return sueldoDao.ActualizarSueldo(sueldo, parametros);
        }

        //Consultar varios sueldos por filtros
        internal IList<Sueldo> ObtenerSueldos(Dictionary<string, object> parametros = null)
        {
            return sueldoDao.ObtenerSueldos(parametros);
        }

        internal int CrearSueldoTransaccion(Sueldo sueldo, BindingList<SueldoAsignacion> listaSueldoAsignacion, BindingList<SueldoDescuento> listaSueldoDescuento, SueldoPerfilHistorico sueldoPerfilHistorico)
        {
            return sueldoDao.CrearSueldoTransaccion(sueldo, listaSueldoAsignacion, listaSueldoDescuento, sueldoPerfilHistorico);
        }
    }
}
