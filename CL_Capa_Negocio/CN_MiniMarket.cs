using CL_AccesoDatos;
using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Negocio
{
    public class CN_MiniMarket
    {
        public static bool InsertarMiniMarket(Minimarket objMiniMarket) 
        {
            return DA_MiniMarket.InsertarMiniMarket(objMiniMarket);
        }
        public static DataTable ConsultarMinimarket()
        {
            return DA_MiniMarket.ConsultarMinimarket();
    }
        public static bool ActualizarMinimaket(Minimarket objMinimarket)
        {
            return DA_MiniMarket.ActualizarMiniMarket(objMinimarket);
        }
    }
}
