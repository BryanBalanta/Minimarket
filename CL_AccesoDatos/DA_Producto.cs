using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Producto:DA_BASE
    {
        public static bool InsertarProducto(Producto objProducto) 
        {
            string strSQL = "Insert into producto" +
                "(codigo, nombre, marca, stock, PVP, descripcion, unidadMedida) values (";
            strSQL += "'" + objProducto.Nombre + "',";
            strSQL += "'" + objProducto.Marca + "',";
            strSQL += "'" + objProducto.Stock + "',";
            strSQL += "'" + objProducto.PVP + "',";
            strSQL += "'" + objProducto.Descripcion + "',";
            strSQL += "'" + objProducto.UnidadMedida + "');";

            return RealizarTransaccion(strSQL);
        }
        public static bool ActualizarProducto(Producto objProducto)
        {
            string strSQL = "Update producto" +
                "(codigo, nombre, marca, stock, PVP, descripcion, unidadMedida) values (";
            strSQL += "'" + objProducto.Nombre + "',";
            strSQL += "'" + objProducto.Marca + "',";
            strSQL += "'" + objProducto.Stock + "',";
            strSQL += "'" + objProducto.PVP + "',";
            strSQL += "'" + objProducto.Descripcion + "',";
            strSQL += "'" + objProducto.UnidadMedida + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
