using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class OrdenDeCompra
    {
        public int idordenDeCompra { get; set; }
        public String CodigoOrdenDeCompra { get; set; }
        public String Iva { get; set; }
        public String PrecioTotal { get; set; }
        public String FechaPedido { get; set; }
        public String FechaEntrega { get; set; }
        public String TotalSinIva { get; set; }

    }
}
