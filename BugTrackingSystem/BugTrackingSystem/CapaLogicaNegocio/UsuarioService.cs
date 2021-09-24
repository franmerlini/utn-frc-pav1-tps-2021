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
        private readonly UsuarioDao usuarioDao;

        //---Metodos---
        //Constructor
        public UsuarioService()
        {
            usuarioDao = new UsuarioDao();
        }
        //Validar un usuario pasando como parametro el nombre y la contraseña
        public Usuario ValidarUsuario(string nom, string cont)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "nombreExacto", nom }
            };

            var usu = usuarioDao.ObtenerUsuarios(parametros);

            if (usu[0] != null && usu[0].Contrasena.Equals(cont))
            {
                return usu[0];
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

        //Consultar varios usuarios por filtros
        internal IList<Usuario> ObtenerUsuarios(Dictionary<string, object> parametros = null)
        {
            return usuarioDao.ObtenerUsuarios(parametros);
        }
    }
}
