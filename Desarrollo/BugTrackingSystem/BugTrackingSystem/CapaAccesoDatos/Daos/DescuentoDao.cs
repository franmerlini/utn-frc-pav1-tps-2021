using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace BugTrackingSystem.CapaAccesoDatos
{
    public class DescuentoDao
    {
        public IList<Descuento> ObtenerDescuentos(Dictionary<string, object> parametros)
        {
            List<Descuento> listadoDescuentos = new List<Descuento>();

            String consultaSQL = string.Concat("  SELECT id_descuento, ",
                                               "         n_descuento, ",
                                               "         monto, ",
                                               "         borrado ",
                                               "  FROM Descuentos ",
                                               "  WHERE 1 = 1 ");

            // Si parametros = null, no se hace ningún filtrado
            if (parametros != null)
            {
                if (parametros.ContainsKey("idDescuento"))
                    consultaSQL += " AND (id_descuento = @idDescuento) ";
                if (parametros.ContainsKey("nombre"))
                    consultaSQL += " AND (n_descuento = @nombre) ";
                if (parametros.ContainsKey("monto"))
                    consultaSQL += " AND (monto = @monto) ";
                if (!parametros.ContainsKey("borrado"))
                    consultaSQL += " AND (borrado = 0) ";
            }
            else
            {
                consultaSQL += "AND (borrado = 0) ";
            }

            consultaSQL += " ORDER BY n_descuento ASC";

            var resultados = DataManager.ObtenerInstancia().ConsultaSQL(consultaSQL, parametros);

            foreach (DataRow resultado in resultados.Rows)
            {
                listadoDescuentos.Add(MapeoObjeto(resultado));
            }

            return listadoDescuentos;
        }

        internal bool CrearDescuento(Descuento descuento)
        {
            string consultaSQL = " INSERT INTO Descuentos (n_descuento, monto, borrado)" +
                                 " Values (@nombre, @monto, 0)";

            var parametros = new Dictionary<string, object>
            {
                {"nombre", descuento.Nombre },
                {"monto", descuento.Monto }
            };

            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        internal bool ActualizarDescuento(Descuento descuento)
        {
            string consultaSQL = " UPDATE Descuentos " +
                                " SET n_descuento = @nombre, " +
                                "     monto = @monto, " +
                                "     borrado = @borrado " +
                                " WHERE id_descuento = @idDescuento ";

            var parametros = new Dictionary<string, object>
            {
                {"idDescuento", descuento.IdDescuento },
                {"nombre", descuento.Nombre },
                {"monto", descuento.Monto },
                {"borrado", descuento.Borrado }
            };

            return (DataManager.ObtenerInstancia().EjecutarSQL(consultaSQL, parametros) == 1);
        }

        private Descuento MapeoObjeto(DataRow row)
        {
            Descuento Descuento = new Descuento
            {
                IdDescuento = Convert.ToInt32(row["id_descuento"].ToString()),
                Nombre = row["n_descuento"].ToString(),
                Monto = Convert.ToDecimal(row["monto"].ToString()),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return Descuento;
        }
    }
}
