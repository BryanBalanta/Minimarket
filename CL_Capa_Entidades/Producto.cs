using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public String Nombre { get; set; }
        public String Marca { get; set; }
        public String Stock { get; set; }
        public String PVP { get; set; }
        public String Descripcion { get; set; }
        public String UnidadMedida { get; set; }
    }
}
