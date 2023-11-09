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
    public partial class FrmConsultarCategoria : Form
    {
        public Form1 MidParent { get; internal set; }

        public FrmConsultarCategoria()
        {
            InitializeComponent();
        }

        private void FrmConsultarCategoria_Load(object sender, EventArgs e)
        {
            DataTable MitablaDatos = new DataTable();

            DataGridViewButtonColumn dgbcEditarCliente = new DataGridViewButtonColumn();
            dgbcEditarCliente.Name = "Actualizar";
            dgbcEditarCliente.Text = "Actualizar";

            MitablaDatos = CN_Categoria.ConsultarCategoria();
            dgvCategoria.DataSource = MitablaDatos;
            dgvCategoria.Columns[0].Visible = false;
            dgvCategoria.Columns.Add(dgbcEditarCliente);
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                txtBoxActualizarNombreCategoria.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
                txtBoxActualizarDescripcionCategoria.Text = dgvCategoria.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();

            objCategoria.Nombre = txtBoxActualizarNombreCategoria.Text.Trim();
            objCategoria.Descripcion = txtBoxActualizarDescripcionCategoria.Text.Trim();

            if (CN_Categoria.ActualizarCategoria(objCategoria))
            {
                MessageBox.Show("Actualizacion Exitosa");
            }
            else
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria ObjFrmConsultarCategoria = new FrmRegistrarCategoria();

            //ObjFrmConsultarCategoria.MidParent = this;

            ObjFrmConsultarCategoria.Show();
            ObjFrmConsultarCategoria.WindowState = FormWindowState.Maximized;
        }
    }
}
