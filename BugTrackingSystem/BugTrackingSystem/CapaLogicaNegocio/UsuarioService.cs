using BugTrackingSystem.CapaAccesoDatos;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.CapaLogicaNegocio
{
    public class UsuarioService
    {
        //---Atributos---
        private UsuarioDao usuarioDao;

        //---Metodos---
        //Constructor
        public UsuarioService()
        {
            usuarioDao = new UsuarioDao();
        }
        //Listar todos los usuarios
        public IList<Usuario> ObtenerTodos()
        {
            return usuarioDao.ObtenerTodos();
        }
        //Validar un usuario pasando como parametro el nombre y la contraseña
        public Usuario ValidarUsuario(string nom, string cont)
        {
            var usu = usuarioDao.ObtenerUsuario(nom);

            if (usu != null && usu.Contrasena.Equals(cont))
            {
                return usu;
            }

            return null;
        }
        //Crear un usuario
        internal bool CrearUsuario(Usuario usuario)
        {
            return usuarioDao.CrearUsuario(usuario);
        }
        //Actualizar un usuario
        internal bool ActualizarUsuario(Usuario usuario)
        {
            return usuarioDao.ActualizarUsuario(usuario);
        }
        //Eliminar un usuario
        internal bool EliminarUsuario(Usuario usuario)
        {
            return usuarioDao.EliminarUsuario(usuario);
        }
        //Obtener un usuario
        internal object ObtenerUsuario(string usuario)
        {
            return usuarioDao.ObtenerUsuario(usuario);
        }
        //Consultar varios usuarios por filtros
        internal IList<Usuario> ObtenerConFiltros(Dictionary<string, object> filtros)
        {
            return usuarioDao.ObtenerConFiltros(filtros);
        }
    }
}
