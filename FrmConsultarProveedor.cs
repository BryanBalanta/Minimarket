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
    public partial class FrmConsultarProveedor : Form
    {
        public Form1 MidParent { get; internal set; }

        public FrmConsultarProveedor()
        {
            InitializeComponent();
        }

        private void FrmConsultarProveedor_Load(object sender, EventArgs e)
        {
            DataTable MiTablaDatos = new DataTable();

            DataGridViewButtonColumn dgbcEditarProveedor = new DataGridViewButtonColumn();
            dgbcEditarProveedor.Name = "Actualizar";
            dgbcEditarProveedor.Text = "Actualizar";

            MiTablaDatos = CN_Proveedor.ConsultarProveedor();
            dgvProveedores.DataSource = MiTablaDatos;
            dgvProveedores.Columns[0].Visible = false;
            dgvProveedores.Columns.Add(dgbcEditarProveedor);

        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            FrmRegistrarProveedor ObjFrmConsultarProveedor = new FrmRegistrarProveedor();

            //ObjFrmConsultarProveedor.MidParent = this;

            ObjFrmConsultarProveedor.Show();
            ObjFrmConsultarProveedor.WindowState = FormWindowState.Maximized;
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.Columns[e.ColumnIndex].Name == "Actualizar") {
                //MessageBox.Show(dgvProveedores.CurrentRow.Cells[0].Value.ToString());

                txtBoxActualizarNitProveedor.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
                txtBoxActualizarRazonSocialProveedor.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
                txtBoxActualizarTelefonoProveedor.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
                txtBoxActualizarNomenclaturaProveedor.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
                txtBoxActualizarCiudadProveedor.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();
                txtBoxActualizarDepartamentoProveedor.Text = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
                txtBoxActualizarCorreoProveedor.Text = dgvProveedores.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = new Proveedor();

            objProveedor.Nit = txtBoxActualizarNitProveedor.Text.Trim();
            objProveedor.RazonSocial = txtBoxActualizarRazonSocialProveedor.Text.Trim();
            objProveedor.Telefono = txtBoxActualizarTelefonoProveedor.Text.Trim();
            objProveedor.Nomenclatura = txtBoxActualizarNomenclaturaProveedor.Text.Trim();
            objProveedor.Ciudad = txtBoxActualizarCiudadProveedor.Text.Trim();
            objProveedor.Departamento = txtBoxActualizarDepartamentoProveedor.Text.Trim();
            objProveedor.Correo = txtBoxActualizarCorreoProveedor.Text.Trim();

            if (CN_Proveedor.ActualizarProveedor(objProveedor))
            {
                MessageBox.Show("Actualizacion Exitosa");
            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }

        private void gbGestionProveedores_Enter(object sender, EventArgs e)
        {

        }
    }
}
