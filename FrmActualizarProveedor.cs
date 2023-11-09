using CL_Capa_Entidades;
using CL_Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_MiniMarket
{
    public partial class FrmActualizarProveedor : Form
    {
        public Form1 MidParent { get; internal set; }

        public FrmActualizarProveedor()
        {
            InitializeComponent();
        }

        private void gbActualizarProveedor_Enter(object sender, EventArgs e)
        {

        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            //Proveedor objProveedor = new Proveedor();

            //objProveedor.Nit = txtBoxActualizarNitProveedor.Text.Trim();
            //objProveedor.RazonSocial = txtBoxActualizarRazonSocialProveedor.Text.Trim();
            //objProveedor.Telefono = txtBoxActualizarTelefonoProveedor.Text.Trim();
            //objProveedor.Nomenclatura = txtBoxActualizarNomenclaturaProveedor.Text.Trim();
            //objProveedor.Ciudad = txtBoxActualizarCiudadProveedor.Text.Trim();
            //objProveedor.Departamento = txtBoxActualizarDepartamentoProveedor.Text.Trim();
            //objProveedor.Correo = txtBoxActualizarCorreoProveedor.Text.Trim();

            //if (CN_Proveedor.ActualizarProveedor(objProveedor))
            //{
            //    MessageBox.Show("Registro Exitoso");
            //}
            //else
            //{
            //    MessageBox.Show("Fallo en la insercion");
            //}
        }

        private void FrmActualizarProveedor_Load(object sender, EventArgs e)
        {
            //DataTable MiTablaDatos = new DataTable();

            //MiTablaDatos = CN_Proveedor.ConsultarProveedor();

            //txtBoxActualizarNitProveedor.Text = MiTablaDatos.Rows[0]["nit"].ToString();
            //txtBoxActualizarRazonSocialProveedor.Text = MiTablaDatos.Rows[0]["razonSocial"].ToString();
            //txtBoxActualizarTelefonoProveedor.Text = MiTablaDatos.Rows[0]["telefono"].ToString();
            //txtBoxActualizarNomenclaturaProveedor.Text = MiTablaDatos.Rows[0]["nomenclatura"].ToString();
            //txtBoxActualizarCiudadProveedor.Text = MiTablaDatos.Rows[0]["ciudad"].ToString();
            //txtBoxActualizarDepartamentoProveedor.Text = MiTablaDatos.Rows[0]["departamento"].ToString();
            //txtBoxActualizarCorreoProveedor.Text = MiTablaDatos.Rows[0]["correo"].ToString();
        }
    }
}
