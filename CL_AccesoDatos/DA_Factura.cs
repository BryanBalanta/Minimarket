using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Factura:DA_BASE
    {
        public static bool InsertarFactura(Factura objFactura) 
        {
            string strSQL = "Insert into factura" +
                "(codigoFactura, fechaGeneracion, iva, sinIva, total) values (";
            strSQL += "'" + objFactura.CodigoFactura + "',";
            strSQL += "'" + objFactura.FechaGeneracion + "',";
            strSQL += "'" + objFactura.Iva + "',";
            strSQL += "'" + objFactura.SinIva + "',";
            strSQL += "'" + objFactura.Total + "');";

            return RealizarTransaccion(strSQL);
        }
        public static bool ActualizarFactura(Factura objFactura)
        {
            string strSQL = "Update factura" +
                "(codigoFactura, fechaGeneracion, iva, sinIva, total) values (";
            strSQL += "'" + objFactura.CodigoFactura + "',";
            strSQL += "'" + objFactura.FechaGeneracion + "',";
            strSQL += "'" + objFactura.Iva + "',";
            strSQL += "'" + objFactura.SinIva + "',";
            strSQL += "'" + objFactura.Total + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
