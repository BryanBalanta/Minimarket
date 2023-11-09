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
    public partial class FrmConsultarCliente : Form
    {
        public Form1 MidParent { get; internal set; }

        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            DataTable MitablaDatos = new DataTable();

            DataGridViewButtonColumn dgbcEditarCliente = new DataGridViewButtonColumn();
            dgbcEditarCliente.Name = "Actualizar";
            dgbcEditarCliente.Text = "Actualizar";

            MitablaDatos = CN_Cliente.ConsultarCliente();
            dgvCliente.DataSource = MitablaDatos;
            dgvCliente.Columns[0].Visible = false;
            dgvCliente.Columns.Add(dgbcEditarCliente);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                cbBoxActualizarTipoDocumentoCliente.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                txtBoxActualizarNDocumentoCliente.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtBoxActualizarNombresCliente.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                txtBoxActualizarApellidosCliente.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                txtBoxActualizarCorreoCliente.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
                txtBoxActulizarCelularCliente.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();

            objCliente.Identificacion = txtBoxActualizarNDocumentoCliente.Text.Trim();
            objCliente.TipoDocumento = cbBoxActualizarTipoDocumentoCliente.SelectedItem.ToString();
            objCliente.Nombres = txtBoxActualizarNombresCliente.Text.Trim();
            objCliente.Apellidos = txtBoxActualizarApellidosCliente.Text.Trim();
            objCliente.Correo = txtBoxActualizarCorreoCliente.Text.Trim();
            objCliente.Celular = txtBoxActulizarCelularCliente.Text.Trim();

            if (CN_Cliente.ActualizarCliente(objCliente))
            {
                MessageBox.Show("Actualizacion Exitosa");
            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente ObjFrmConsultarProveedor = new FrmRegistrarCliente();

            //ObjFrmConsultarProveedor.MidParent = this;

            ObjFrmConsultarProveedor.Show();
            ObjFrmConsultarProveedor.WindowState = FormWindowState.Maximized;
        }
    }
}
