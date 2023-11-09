using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_BASE
    {
        public static string CadenaConexion = "SERVER=localhost;" +
            "DATABASE=bd_minimarket; UID= root; PASSWORD=";
        public static bool RealizarTransaccion(string strSQL) 
        {
            bool resultado = false;

            try 
            {
                using (MySqlConnection conn = new MySqlConnection
                    (CadenaConexion)) 
                {
                    conn.Open();
                    using (MySqlTransaction tr = conn.BeginTransaction())
                    {
                        try 
                        { 
                        using(MySqlCommand cmd = new MySqlCommand
                    (strSQL, conn))                
                            {
                                cmd.Transaction = tr;
                                cmd.ExecuteNonQuery();
                            }
                            tr.Commit();
                            resultado = true;
                        }
                        catch (Exception) 
                        {
                            tr.Rollback();
                            resultado = false;
                            throw;
                        }
                    }
                }
            }
            catch (Exception) 
            {
                resultado = false;
                throw;
            }
            return resultado;
        }
        public static DataTable ConsultarDatos(String StrSQL) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(StrSQL, conn))
                    {
                        using(MySqlDataReader dr=cmd.ExecuteReader()) 
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            return dt;
                        }
                    }
                }
            }
            catch(Exception) {
                throw;
            }
        }
    }
}
