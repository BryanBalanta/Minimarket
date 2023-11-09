using CL_Capa_Entidades;
using CL_Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_MiniMarket
{
    public partial class FrmRegistrarProveedor : Form
    {
        public FrmRegistrarProveedor()
        {
            InitializeComponent();
        }

        public Form1 MidParent { get; internal set; }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = new Proveedor();

            objProveedor.Nit = txtBoxRegistrarNitProveedor.Text.Trim();
            objProveedor.RazonSocial = txtBoxRegistrarRazonSocialProveedor.Text.Trim();
            objProveedor.Telefono = txtBoxRegistrarTelefonoProveedor.Text.Trim();
            objProveedor.Nomenclatura = txtBoxRegistrarNomenclaturaProveedor.Text.Trim();
            objProveedor.Ciudad = txtBoxRegistrarCiudadProveedor.Text.Trim();
            objProveedor.Departamento = txtBoxRegistrarDepartamentoProveedor.Text.Trim();
            objProveedor.Correo = txtBoxRegistrarCorreoProveedor.Text.Trim();

            if (CN_Proveedor.InsertarProveedor(objProveedor))
            {
                MessageBox.Show("Registro Exitoso");
            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }

        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
