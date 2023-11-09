﻿using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_MiniMarket:DA_BASE
    {
        public static bool InsertarMiniMarket(Minimarket objMiniMarket) 
        {
            string strSQL = "Insert into minimarket" +
                "(nit, razonSocial, telefono, nomenclatura, ciudad, departamento, correo," +
                "sitioWeb, facebook, whatsapp) values (";
            strSQL += "'" + objMiniMarket.Nit + "',";
            strSQL += "'" + objMiniMarket.RazonSocial + "',";
            strSQL += "'" + objMiniMarket.Telefono + "',";
            strSQL += "'" + objMiniMarket.Nomenclatura + "',";
            strSQL += "'" + objMiniMarket.Ciudad + "',";
            strSQL += "'" + objMiniMarket.Departamento + "',";
            strSQL += "'" + objMiniMarket.Correo + "',";
            strSQL += "'" + objMiniMarket.SitioWeb + "',";
            strSQL += "'" + objMiniMarket.Facebook + "',";
            strSQL += "'" + objMiniMarket.Whatsapp + "');";

            return RealizarTransaccion(strSQL);
        }
        public static DataTable ConsultarMinimarket() 
        {
            DataTable dt = new DataTable();

            String strSQL ="select nit, razonSocial, telefono, nomenclatura, ciudad, departamento, correo, sitioWeb, facebook, whatsapp from minimarket where idMiniMarket=1;";

            return ConsultarDatos(strSQL);
        }
        public static bool ActualizarMiniMarket(Minimarket objMiniMarket)
        {
            string strSQL = "Update minimarket set razonSocial='" +
                objMiniMarket.RazonSocial + "',telefono='" +
                objMiniMarket.Telefono + "',nomenclatura='" +
                objMiniMarket.Nomenclatura + "',ciudad='" +
                objMiniMarket.Ciudad + "',departamento='" +
                objMiniMarket.Departamento + "',correo='" +
                objMiniMarket.Correo + "',sitioWeb='" +
                objMiniMarket.SitioWeb + "',facebook='" +
                objMiniMarket.Facebook + "',whatsapp='" +
                objMiniMarket.Whatsapp + "';";

            return RealizarTransaccion(strSQL);
        }
    }
}
