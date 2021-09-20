using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class AsistenciaUsuarioService
    {
        //---Atributos---
        private readonly AsistenciaUsuarioDao asistenciaUsuarioDao;

        //---Metodos---
        //Constructor
        public AsistenciaUsuarioService()
        {
            asistenciaUsuarioDao = new AsistenciaUsuarioDao();
        }

        //Obtener
        public IList<AsistenciaUsuario> ObtenerAsistenciasUsuario(Dictionary<string, object> parametros = null)
        {
            return asistenciaUsuarioDao.ObtenerAsistenciasUsuario(parametros);
        }

        //Crear
        internal bool CrearAsistenciaUsuario(AsistenciaUsuario asistenciaUsuario)
        {
            return asistenciaUsuarioDao.CrearAsistenciaUsuario(asistenciaUsuario);
        }

        //Actualizar
        internal bool ActualizarAsistenciaUsuario(AsistenciaUsuario asistenciaUsuario)
        {
            return asistenciaUsuarioDao.ActualizarAsistenciaUsuario(asistenciaUsuario);
        }

        //Eliminar
    }
}
