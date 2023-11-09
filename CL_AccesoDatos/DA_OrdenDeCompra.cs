using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_OrdenDeCompra:DA_BASE
    {
        public static bool InsertarOrdenDeCompra(OrdenDeCompra objOrdenDeCompra) 
        {
            string strSQL = "Insert into ordenDeCompra" +
                "(codigoOrdenDeCompra, Iva, precioTotal, fechaPedido, fechaEntrega, totalSinIva) values (";
            strSQL += "'" + objOrdenDeCompra.CodigoOrdenDeCompra + "',";
            strSQL += "'" + objOrdenDeCompra.Iva + "',";
            strSQL += "'" + objOrdenDeCompra.PrecioTotal + "',";
            strSQL += "'" + objOrdenDeCompra.FechaPedido + "',";
            strSQL += "'" + objOrdenDeCompra.FechaEntrega + "',";
            strSQL += "'" + objOrdenDeCompra.TotalSinIva + "');";

            return RealizarTransaccion(strSQL);
        }
        public static bool ActualizarOrdenDeCompra(OrdenDeCompra objOrdenDeCompra)
        {
            string strSQL = "Update ordenDeCompra" +
                "(codigoOrdenDeCompra, Iva, precioTotal, fechaPedido, fechaEntrega, totalSinIva) values (";
            strSQL += "'" + objOrdenDeCompra.CodigoOrdenDeCompra + "',";
            strSQL += "'" + objOrdenDeCompra.Iva + "',";
            strSQL += "'" + objOrdenDeCompra.PrecioTotal + "',";
            strSQL += "'" + objOrdenDeCompra.FechaPedido + "',";
            strSQL += "'" + objOrdenDeCompra.FechaEntrega + "',";
            strSQL += "'" + objOrdenDeCompra.TotalSinIva + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
