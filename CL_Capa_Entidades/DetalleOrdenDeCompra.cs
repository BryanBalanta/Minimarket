using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class DetalleOrdenDeCompra
    {
        public int idDetalleOrdenDeCompra { get; set; }
        public String CodigoDetalleOrdenDeCompra { get; set; }
        public String CantidadProducto { get; set; }
        public String PrecioCompra { get; set; }
        public String Subtotal { get; set; }
    }
}
