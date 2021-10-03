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
        public IList<Usuario> ObtenerUsuarios(Dictionary<string, object> parametros)
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            String consultaSQL = string.Concat(" SELECT id_usuario, ",
                                              "         u.id_perfil, ",
                                              "         usuario, ",
                                              "         password, ",
                                              "         email, ",
                                              "         estado, ",
                                              "         u.borrado, ",
                                              "         p.nombre ",
                                              "  FROM Usuarios u ",
                                              "  INNER JOIN Perfiles p ON u.id_perfil = p.id_perfil ",
                                              "  WHERE 1=1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idUsuario"))
                    consultaSQL += " AND (id_usuario = @idUsuario) ";
                if (parametros.ContainsKey("idPerfil"))
                    consultaSQL += " AND (u.id_perfil = @idPerfil) ";
                if (parametros.ContainsKey("nombre"))
                    consultaSQL += " AND (LOWER(usuario) LIKE '%' + LOWER(@nombre) + '%') ";
                if (parametros.ContainsKey("email"))
                    consultaSQL += " AND (LOWER(email) Like '%' + LOWER(@email) + '%') ";
                if (parametros.ContainsKey("estado"))
                    consultaSQL += " AND (LOWER(estado) = LOWER(@estado)) ";
                if (!parametros.ContainsKey("borrado"))
                    consultaSQL += " AND (u.borrado=0) ";
                //Para consultar por el nombre exacto
                if (parametros.ContainsKey("nombreExacto"))
                    consultaSQL += " AND (usuario = @nombreExacto) ";
                //Para consultar por el email exacto
                if (parametros.ContainsKey("emailExacto"))
                    consultaSQL += " AND (email = @emailExacto) ";
            }
            else
                consultaSQL += "AND (u.borrado=0) ";
            consultaSQL += " ORDER BY LOWER(usuario) ASC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoUsuarios.Add(MapeoObjeto(resultado));
            }

            return listadoUsuarios;
        }

        internal bool CrearUsuario(Usuario usuario)
        {
            string consultaSQL = " INSERT INTO Usuarios (id_perfil, usuario, password, email, estado, borrado)" +
                                 " VALUES (@idPerfil, @nombre, @contrasena, @email, @estado, 0)";

            var parametros = new Dictionary<string, object>
            {
                { "idPerfil", usuario.Perfil.IdPerfil },
                { "nombre", usuario.Nombre },
                { "contrasena", usuario.Contrasena },
                { "email", usuario.Email },
                { "estado", usuario.Estado }
            };

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario retorna FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarUsuario(Usuario usuario)
        {
            string consultaSQL = " UPDATE Usuarios" +
                                 " SET usuario = @nombre," +
                                 "     id_perfil = @idPerfil," +
                                 "     password = @contrasena," +
                                 "     email = @email," +
                                 "     estado = @estado," +
                                 "     borrado = @borrado" + 
                                 " WHERE id_usuario = @idUsuario";

            var parametros = new Dictionary<string, object>
            {
                { "idUsuario", usuario.IdUsuario },
                { "idPerfil", usuario.Perfil.IdPerfil },
                { "nombre", usuario.Nombre },
                { "contrasena", usuario.Contrasena },
                { "email", usuario.Email },
                { "estado", usuario.Estado },
                { "borrado", usuario.Borrado }
            };

            // Si una fila es afectada por la actualizacion retorna TRUE, de lo contrario FALSE
            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        private Usuario MapeoObjeto(DataRow row)
        {
            Usuario usuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                Nombre = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Estado = row["estado"].ToString(),
                Contrasena = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
                Borrado = Convert.ToBoolean(row["borrado"].ToString()),
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
