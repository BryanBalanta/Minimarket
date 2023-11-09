using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Factura
    {
        public int idFactura { get; set; }
        public String CodigoFactura { get; set; }
        public String FechaGeneracion { get; set; }
        public String Iva { get; set; }
        public String SinIva { get; set; }
        public String Total { get; set; }

    }
}
