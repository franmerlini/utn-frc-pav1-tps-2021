using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System.Collections.Generic;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class AsistenciaUsuarioService
    {
        //-------------------------------------------------------Atributos-------------------------------------------------------
        private readonly AsistenciaUsuarioDao asistenciaUsuarioDao;

        //--------------------------------------------------------Metodos--------------------------------------------------------
        //Constructor
        public AsistenciaUsuarioService()
        {
            asistenciaUsuarioDao = new AsistenciaUsuarioDao();
        }

        //Crear una asistencia de usuario
        internal bool CrearAsistenciaUsuario(AsistenciaUsuario asistenciaUsuario)
        {
            return asistenciaUsuarioDao.CrearAsistenciaUsuario(asistenciaUsuario);
        }

        //Actualizar una asistencia de usuario
        internal bool ActualizarAsistenciaUsuario(AsistenciaUsuario asistenciaUsuario, Dictionary<string, object> parametros)
        {
            return asistenciaUsuarioDao.ActualizarAsistenciaUsuario(asistenciaUsuario, parametros);
        }

        //Consultar varias asistencias de usuario por filtros
        public IList<AsistenciaUsuario> ObtenerAsistenciasUsuario(Dictionary<string, object> parametros = null)
        {
            return asistenciaUsuarioDao.ObtenerAsistenciasUsuario(parametros);
        }
    }
}
