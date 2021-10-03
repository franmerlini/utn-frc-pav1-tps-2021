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
    public class PerfilDao
    {
        public IList<Perfil> ObtenerPerfiles(Dictionary<string, object> parametros)
        {
            List<Perfil> listadoPerfil = new List<Perfil>();

            var strSql = String.Concat("SELECT id_perfil, ",
                                       "       nombre, ",
                                       "       borrado ",
                                       "FROM Perfiles ",
                                       "WHERE 1=1");

            if (parametros != null)
            {
                if (parametros.ContainsKey("idPerfil"))
                    strSql += "AND (id_perfil=@idPerfil) ";
                if (parametros.ContainsKey("nombre"))
                    strSql += "AND (nombre=@nombre) ";
                if (parametros.ContainsKey("borrado"))
                    strSql += " AND (borrado=0)";
            }
            else
                strSql += " AND (borrado=0)";

            var resultadoConsulta = (DataRowCollection)DataManager.ObtenerInstancia().ConsultaSQL(strSql, parametros).Rows;

            foreach (DataRow resultado in resultadoConsulta)
            {
                listadoPerfil.Add(MapeoObjeto(resultado));
            }

            return listadoPerfil;
        }

        private Perfil MapeoObjeto(DataRow row)
        {
            Perfil perfil = new Perfil
            {
                IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                Nombre = row["nombre"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return perfil;
        }


    }
}
