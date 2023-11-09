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
    public partial class FrmRegistrarEmpleado : Form
    {
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void txtBoxActualizarTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado objEmpleado = new Empleado();

            objEmpleado.TipoDocumento = cbBoxRegistrarTipoDocumentoEmpleado.SelectedItem.ToString();
            objEmpleado.Identificacion = txtBoxRegistrarNDocumentoEmpleado.Text.Trim();
            objEmpleado.Nombres = txtBoxRegistrarNombresEmpleado.Text.Trim();
            objEmpleado.Apellidos = txtBoxRegistrarApellidosEmpleado.Text.Trim();
            objEmpleado.Correo = txtBoxRegistrarCorreoEmpleado.Text.Trim();
            objEmpleado.Celular = txtBoxRegistrarCelularEmpleado.Text.Trim();
            objEmpleado.Clave = txtBoxRegistrarClaveEmpleado.Text.Trim();

            if (CN_Empleado.InsertarEmpleado(objEmpleado))
            {
                MessageBox.Show("Registro Exitoso");
            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }
    }
}
