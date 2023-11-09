using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public String TipoDocumento { get; set; }
        public String Identificacion { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Correo { get; set; }
        public String Celular { get; set; }
    }
}
