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
    public partial class FrmRegistrarCliente : Form
    {
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        public Form1 MidParent { get; internal set; }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente=new Cliente();

            objCliente.TipoDocumento=cbBoxRegistrarTipoDocumentoCliente.SelectedItem.ToString();
            objCliente.Identificacion=txtBoxRegistrarNDocumentoCliente.Text.Trim();
            objCliente.Nombres=txtBoxRegistrarNombresCliente.Text.Trim();
            objCliente.Apellidos=txtBoxRegistrarApellidosCliente.Text.Trim();
            objCliente.Correo=txtBoxRegistrarCorreoCliente.Text.Trim();
            objCliente.Celular=txtBoxRegistrarCelularCliente.Text.Trim();

            if (CN_Cliente.InsertarCliente(objCliente))
            {
                MessageBox.Show("Registro Exitoso");
            }
            else 
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }

        private void gbRegistrarEmpleado_Enter(object sender, EventArgs e)
        {

        }
    }
}
