using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Proveedor:DA_BASE
    {
        public static bool InsertarProveedor(Proveedor objProveedor)
        {
            string strSQL = "Insert into proveedor" +
                "(nit, razonSocial, telefono, nomenclatura, ciudad, departamento, correo) values (";
            strSQL += "'" + objProveedor.Nit + "',";
            strSQL += "'" + objProveedor.RazonSocial + "',";
            strSQL += "'" + objProveedor.Telefono + "',";
            strSQL += "'" + objProveedor.Nomenclatura + "',";
            strSQL += "'" + objProveedor.Ciudad + "',";
            strSQL += "'" + objProveedor.Departamento + "',";
            strSQL += "'" + objProveedor.Correo + "');";

            return RealizarTransaccion(strSQL);
        }
        public static DataTable ConsultarProveedor()
        {
            DataTable dt = new DataTable();

            String strSQL = "select * from proveedor";

            return ConsultarDatos(strSQL);
        }
        public static bool ActualizarProveedor(Proveedor objProveedor) 
        {
            string strSQL = "Update proveedor set razonSocial='" +
                objProveedor.RazonSocial + "',telefono='" +
                objProveedor.Telefono + "',nomenclatura='" +
                objProveedor.Nomenclatura + "',ciudad='" +
                objProveedor.Ciudad + "',departamento='" +
                objProveedor.Departamento + "',correo='" +
                objProveedor.Correo + "';";

            return RealizarTransaccion(strSQL);
        }
    }
}
