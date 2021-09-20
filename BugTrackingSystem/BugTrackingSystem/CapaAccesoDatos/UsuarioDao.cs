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
    public class UsuarioDao
    {
        public IList<Usuario> ObtenerUsuarios(Dictionary<string, object> parametros = null)
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            String consultaSQL = string.Concat(" SELECT id_usuario, ",
                                              "        u.id_perfil, ",
                                              "        usuario, ",
                                              "        password, ",
                                              "        email, ",
                                              "        estado, ",
                                              "        u.borrado, ",
                                              "        p.nombre ",
                                              "   FROM Usuarios u ",
                                              "  INNER JOIN Perfiles p ON u.id_perfil = p.id_perfil ",
                                              "  WHERE 1=1 ") ;

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idUsuario"))
                    consultaSQL += " AND (id_usuario = @idUsuario) ";
                if (parametros.ContainsKey("idPerfil"))
                    consultaSQL += " AND (u.id_perfil = @idPerfil) ";
                if (parametros.ContainsKey("nombre"))
                    consultaSQL += " AND (usuario LIKE '%' + @nombre + '%') ";
                if (parametros.ContainsKey("contrasena"))
                    consultaSQL += " AND (password = @contrasena) ";
                if (parametros.ContainsKey("email"))
                    consultaSQL += " AND (email = @email) ";
                if (parametros.ContainsKey("estado"))
                    consultaSQL += " AND (estado = @estado) ";
                if (parametros.ContainsKey("borrado"))
                    consultaSQL += " AND (u.borrado=0) ";
                //Para consultar por el nombre exacto
                if (parametros.ContainsKey("nombreExacto"))
                    consultaSQL += " AND (usuario = @nombreExacto) ";
            }

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoUsuarios.Add(MapeoObjeto(resultado));
            }

            return listadoUsuarios;
        }

        internal bool CrearUsuario(Usuario usuario)
        {
            string consultaSQL = " INSERT INTO Usuarios (id_usuario, id_perfil, usuario, password, email, estado, borrado)" +
                                 " VALUES (@idUsuario, @idPerfil, @nombre, @contrasena, @email, @estado, 0)";

            var parametros = new Dictionary<string, object>();

            parametros.Add("idUsuario", usuario.IdUsuario);
            parametros.Add("idPerfil", usuario.Perfil.IdPerfil);
            parametros.Add("nombre", usuario.Nombre);
            parametros.Add("contrasena", usuario.Contrasena);
            parametros.Add("email", usuario.Email);
            parametros.Add("estado", usuario.Estado);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario retorna FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarUsuario(Usuario oUsuario)
        {
            string ConsultaSQL = "  UPDATE Usuarios" +
                                "      SET usuario = @usuario," +
                                "       id_perfil = @idPerfil," +
                                "       contrasena = @contrasena," +
                                "       email = @email," +
                                "       estado = @estado," +
                                "   WHERE id_usuario = @idUsuario";

            var parametros = new Dictionary<string, object>();
            parametros.Add("idUsuario", oUsuario.IdUsuario);
            parametros.Add("idPerfil", oUsuario.Perfil.IdPerfil);
            parametros.Add("nombre", oUsuario.Nombre);
            parametros.Add("contrasena", oUsuario.Contrasena);
            parametros.Add("email", oUsuario.Email);
            parametros.Add("estado", oUsuario.Estado);
            // Si una fila es afectada por la actualizacion retorna TRUE, de lo contrario FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(ConsultaSQL, parametros) == 1);

        }

        internal bool EliminarUsuario(Usuario oUsuario)
        {
            string ConsultaSQL = " UPDATE Usuarios" +
                            "   SET borrado = 1" +
                            "  WHERE id_usuario = @id_usuario";
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_usuario", oUsuario.IdUsuario);

            // Si una fila es afectada por la actualizacion retorna TRUE, de lo contrario FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(ConsultaSQL, parametros) == 1);

        }


        private Usuario MapeoObjeto(DataRow row)
        {
            Usuario usuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                Nombre = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Contrasena = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                Perfil = new Perfil()
                {
                    IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                    Nombre = row["nombre"].ToString(),
                }
            };

            return usuario;
        }
    }
}
