using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class AsignacionDao
    {
        public IList<Asignacion> ObtenerAsignaciones(Dictionary<string, object> parametros)
        {
            List<Asignacion> listadoAsignaciones = new List<Asignacion>();

            String consultaSQL = string.Concat("  SELECT id_asignacion, ",
                                               "         n_asignacion, ",
                                               "         monto, ",
                                               "         borrado ",
                                               "  FROM Asignaciones ",
                                               "  WHERE 1 = 1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idAsignacion"))
                    consultaSQL += " AND (id_asignacion = @idAsignacion) ";
                if (parametros.ContainsKey("nombre"))
                    consultaSQL += " AND (n_asignacion = @nombre) ";
                if (parametros.ContainsKey("monto"))
                    consultaSQL += " AND (monto = @monto) ";
                if (!parametros.ContainsKey("borrado"))
                    consultaSQL += " AND (borrado = 0) ";
            }
            else
            {
                consultaSQL += "AND (borrado = 0) ";
            }

            consultaSQL += " ORDER BY n_asignacion ASC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoAsignaciones.Add(MapeoObjeto(resultado));
            }

            return listadoAsignaciones;
        }

        internal bool CrearAsignacion(Asignacion asignacion)
        {
            string consultaSQL = " INSERT INTO Asignaciones (n_asignacion, monto, borrado)" +
                                 " Values (@nombre, @monto, 0)";

            var parametros = new Dictionary<string, object>
            {
                {"nombre", asignacion.Nombre },
                {"monto", asignacion.Monto }
            };

            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarAsignacion(Asignacion asignacion)
        {
            string consultaSQL = " UPDATE Asignaciones " +
                                " SET n_asignacion = @nombre, " +
                                "     monto = @monto, " +
                                "     borrado = @borrado " +
                                " WHERE id_asignacion = @idAsignacion ";

            var parametros = new Dictionary<string, object>
            {
                {"idAsignacion", asignacion.IdAsignacion },
                {"nombre", asignacion.Nombre },
                {"monto", asignacion.Monto },
                {"borrado", asignacion.Borrado }
            };

            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        private Asignacion MapeoObjeto(DataRow row)
        {
            Asignacion Asignacion = new Asignacion
            {
                IdAsignacion = Convert.ToInt32(row["id_asignacion"].ToString()),
                Nombre = row["n_asignacion"].ToString(),
                Monto = Convert.ToDecimal(row["monto"].ToString()),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return Asignacion;
        }
    }
}
