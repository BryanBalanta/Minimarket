using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Empleado:DA_BASE
    {
        public static bool InsertarEmpleado(Empleado objEmpleado) 
        {
            string strSQL = "Insert into empleado" +
                "(tipoDocumento, identificacion, nombres, apellidos, correo, celular, clave) values (";
            strSQL += "'" + objEmpleado.TipoDocumento + "',";
            strSQL += "'" + objEmpleado.Identificacion + "',";
            strSQL += "'" + objEmpleado.Nombres + "',";
            strSQL += "'" + objEmpleado.Apellidos+ "',";
            strSQL += "'" + objEmpleado.Correo + "',";
            strSQL += "'" + objEmpleado.Celular + "',";
            strSQL += "'" + objEmpleado.Clave + "');";

            return RealizarTransaccion(strSQL);
        }
        public static bool ActualizarEmpleado(Empleado objEmpleado)
        {
            string strSQL = "Update empleado" +
                "(tipoDocumento, identificacion, nombres, apellidos, correo, celular, clave) values (";
            strSQL += "'" + objEmpleado.TipoDocumento + "',";
            strSQL += "'" + objEmpleado.Identificacion + "',";
            strSQL += "'" + objEmpleado.Nombres + "',";
            strSQL += "'" + objEmpleado.Apellidos + "',";
            strSQL += "'" + objEmpleado.Correo + "',";
            strSQL += "'" + objEmpleado.Celular + "',";
            strSQL += "'" + objEmpleado.Clave + "');";

            return RealizarTransaccion(strSQL);
        }
    }
}
