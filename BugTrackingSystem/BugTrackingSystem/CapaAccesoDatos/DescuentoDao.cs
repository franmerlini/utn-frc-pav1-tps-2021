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
                if (parametros.ContainsKey("borrado"))
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

        private Descuento MapeoObjeto(DataRow row)
        {
            Descuento Descuento = new Descuento
            {
                IdDescuento = Convert.ToInt32(row["id_descuento"].ToString()),
                Nombre = row["n_descuento"].ToString(),
                Monto = (float)Convert.ToDouble(row["monto"].ToString()),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return Descuento;
        }
    }
}
