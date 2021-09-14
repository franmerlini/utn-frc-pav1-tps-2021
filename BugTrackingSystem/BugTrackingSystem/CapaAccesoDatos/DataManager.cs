using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.DAO
{
    public class DataManager
    {
        //Atributo declarado como static para instanciar un solo objeto de la clase DataManager
        private static DataManager instanciaDataManager;
        //Atributo que contiene la cadena de conexion a la base de datos
        private string cadenaConexion;

        //Metodo constructor (inicializa el atributo cnnStr con la cadena de conexion a la base de datos)
        public DataManager()
        {
            cadenaConexion = @"Data Source=DESKTOP-MB42SCU\SQLEXPRESS;Initial Catalog=BugTracker81211;Integrated Security=True";
        }

        //Metodo que devuelve la unica instancia de la clase DataManager (en caso que no exista, la crea)
        public static DataManager ObtenerInstancia()
        {
            if (instanciaDataManager == null)
            {
                instanciaDataManager = new DataManager();
            }

            return instanciaDataManager;
        }

        ///      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ///      La función recibe por valor una sentencia sql como string y un diccionario de objetos como parámetros
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        public DataTable ConsultaSQL(string consultaSQL, Dictionary<string, object> parametros = null)
        {
            SqlConnection conexionSQL = new SqlConnection();
            SqlCommand comandoSQL = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                conexionSQL.ConnectionString = cadenaConexion;
                conexionSQL.Open();

                comandoSQL.Connection = conexionSQL;
                comandoSQL.CommandType = CommandType.Text;
                comandoSQL.CommandText = consultaSQL;

                //Se agrega a la colección de parámetros del comando los filtros recibidos
                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        comandoSQL.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }

                tabla.Load(comandoSQL.ExecuteReader());
                return tabla;
            }

            catch (Exception ex)
            {
                throw (ex);
            }

            finally
            {
                conexionSQL.Close();
            }
        }

        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        public int EjecutarSQL(string consultaSQL, Dictionary<string, object> parametros = null)
        {
            SqlConnection conexionSQL = new SqlConnection();
            SqlCommand comandoSQL = new SqlCommand();

            int resultado = 0;

            try
            {
                conexionSQL.ConnectionString = cadenaConexion;
                conexionSQL.Open();

                comandoSQL.Connection = conexionSQL;
                comandoSQL.CommandType = CommandType.Text;
                comandoSQL.CommandText = consultaSQL;

                //Se agrega a la colección de parámetros del comando los filtros recibidos
                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        comandoSQL.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }

                // Retorna el resultado de ejecutar el comando
                resultado = comandoSQL.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexionSQL.Close();
            }

            return resultado;
        }

        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero
        public object ConsultaSQLScalar(string consultaSQL)
        {
            SqlConnection conexionSQL = new SqlConnection();
            SqlCommand comandoSQL = new SqlCommand();

            try
            {
                conexionSQL.ConnectionString = cadenaConexion;
                conexionSQL.Open();

                comandoSQL.Connection = conexionSQL;
                comandoSQL.CommandType = CommandType.Text;
                comandoSQL.CommandText = consultaSQL;

                return comandoSQL.ExecuteScalar();
            }

            catch (SqlException ex)
            {
                throw (ex);
            }

            finally
            {
                conexionSQL.Close();
            }
        }
    }
}
