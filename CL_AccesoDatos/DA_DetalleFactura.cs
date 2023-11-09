using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_DetalleFactura:DA_BASE
    {
        public static bool InsertarDetalleFactura(DetalleFactura objDeatalleFactura) 
        {
            string strSQL = "Insert into detalleFactura" +
                "(cantidadProducto, precioVenta, subtotal) values (";
            strSQL += "'" + objDeatalleFactura.CantidadProdcuto + "',";
            strSQL += "'" + objDeatalleFactura.PrecioVenta + "',";
            strSQL += "'" + objDeatalleFactura.Subtotal + "');";

            return RealizarTransaccion(strSQL);
        }
        public static bool ActualizarDetalleFactura(DetalleFactura objDeatalleFactura)
        {
            string strSQL = "Update detalleFactura" +
                "(cantidadProducto, precioVenta, subtotal) values (";
            strSQL += "'" + objDeatalleFactura.CantidadProdcuto + "',";
            strSQL += "'" + objDeatalleFactura.PrecioVenta + "',";
            strSQL += "'" + objDeatalleFactura.Subtotal + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
