using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class DetalleFactura
    {
        public int idDetalleFactura { get; set; }
        public string CantidadProdcuto { get; set; }
        public string PrecioVenta { get; set; }
        public string Subtotal { get; set; }
    }
}
