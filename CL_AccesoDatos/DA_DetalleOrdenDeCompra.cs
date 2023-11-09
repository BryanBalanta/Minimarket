using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_DetalleOrdenDeCompra:DA_BASE
    {
        public static bool InsertarDetalleOrdenDeCompra(DetalleOrdenDeCompra objDetalleOrdenDeCompra) 
        {
            string strSQL = "Insert into producto" +
                "(codigoDetalleOrdenDeCompra, cantidadProducto, precioCompra, subtotal) values (";
            strSQL += "'" + objDetalleOrdenDeCompra.CodigoDetalleOrdenDeCompra + "',";
            strSQL += "'" + objDetalleOrdenDeCompra.CantidadProducto + "',";
            strSQL += "'" + objDetalleOrdenDeCompra.PrecioCompra + "',";
            strSQL += "'" + objDetalleOrdenDeCompra.Subtotal + "');";

            return RealizarTransaccion(strSQL);

        }
        public static bool ActualizarDetalleOrdenDeCompra(DetalleOrdenDeCompra objDetalleOrdenDeCompra)
        {
            string strSQL = "Insert producto" +
                "(codigoDetalleOrdenDeCompra, cantidadProducto, precioCompra, subtotal) values (";
            strSQL += "'" + objDetalleOrdenDeCompra.CodigoDetalleOrdenDeCompra + "',";
            strSQL += "'" + objDetalleOrdenDeCompra.CantidadProducto + "',";
            strSQL += "'" + objDetalleOrdenDeCompra.PrecioCompra + "',";
            strSQL += "'" + objDetalleOrdenDeCompra.Subtotal + "');";

            return RealizarTransaccion(strSQL);

        }
    }
}
