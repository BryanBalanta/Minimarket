using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Cliente:DA_BASE
    {
        public static bool InsertarCliente(Cliente objCliente) 
        {
            string strSQL = "Insert into cliente" +
                "(tipoDocumento, identificacion, nombres, apellidos, correo, celular) values (";
            strSQL += "'" + objCliente.TipoDocumento + "',";
            strSQL += "'" + objCliente.Identificacion + "',";
            strSQL += "'" + objCliente.Nombres + "',";
            strSQL += "'" + objCliente.Apellidos + "',";
            strSQL += "'" + objCliente.Correo + "',";
            strSQL += "'" + objCliente.Celular + "');";

            return RealizarTransaccion(strSQL);
        }

        public static DataTable ConsultarCliente() 
        {
            DataTable dt = new DataTable();

            String strSQL = "select * from cliente";

            return ConsultarDatos(strSQL);
        }
        public static bool ActualizarCliente(Cliente objCliente)
        {
            string strSQL = "Update cliente set tipoDocumento='" +
                objCliente.TipoDocumento + "',identificacion='" +
                objCliente.Identificacion + "',nombres='" +
                objCliente.Nombres + "',apellidos='" +
                objCliente.Apellidos + "',correo='" +
                objCliente.Correo + "',celular='" +
                objCliente.Celular + "';";

            return RealizarTransaccion(strSQL);
        }
    }
}
