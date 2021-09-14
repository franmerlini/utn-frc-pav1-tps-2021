using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.CapaAccesoDatos
{
    class UsuarioDao
    {
        public IList<Usuario> ObtenerTodos()
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            String consultaSQL = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil = p.id_perfil " +
                                          "  WHERE u.borrado = 0 ");

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoUsuarios.Add(MapeoObjeto(resultado));
            }

            return listadoUsuarios;
        }

        public Usuario ObtenerUsuario(string nombre)
        {
            String consultaSQL = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil = p.id_perfil ",
                                          "  WHERE usuario = @usuario");

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", nombre);


            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            if (resultados.Rows.Count > 0)
            {
                return MapeoObjeto(resultados.Rows[0]);
            }

            return null;
        }

        public IList<Usuario> ObtenerConFiltros(Dictionary<string, object> parametros)
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            String consultaSQL = string.Concat(" SELECT id_usuario, ",
                                              "        usuario, ",
                                              "        email, ",
                                              "        password, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre perfil ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil = p.id_perfil ",
                                              "  WHERE u.borrado = 0");

            if (parametros.ContainsKey("idPerfil"))
                consultaSQL += " AND (u.id_perfil = @idPerfil) ";


            if (parametros.ContainsKey("usuario"))
                consultaSQL += " AND (u.usuario LIKE '%' + @usuario + '%') ";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
                listadoUsuarios.Add(MapeoObjeto(resultado));

            return listadoUsuarios;
        }

        internal bool CrearUsuario(Usuario usuario)
        {
            string consultaSQL = "     INSERT INTO Usuarios (usuario, password, email, id_perfil, borrado)" +
                             "     VALUES (@usuario, @password, @email, @id_perfil, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", usuario.Nombre);
            parametros.Add("password", usuario.Contrasena);
            parametros.Add("email", usuario.Email);
            parametros.Add("id_perfil", usuario.Perfil.Id);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario retorna FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarUsuario(Usuario oUsuario)
        {
            throw new NotImplementedException();
        }

        internal bool EliminarUsuario(Usuario oUsuario)
        {
            throw new NotImplementedException();
        }


        private Usuario MapeoObjeto(DataRow row)
        {
            Usuario usuario = new Usuario
            {
                Id = Convert.ToInt32(row["id_usuario"].ToString()),
                Nombre = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Contrasena = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                Perfil = new Perfil()
                {
                    Id = Convert.ToInt32(row["id_perfil"].ToString()),
                    Nombre = row["perfil"].ToString(),
                }
            };

            return usuario;
        }
    }
}
