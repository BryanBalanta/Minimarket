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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minimarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarMiniMarket ObjFrmMinimarket = new FrmRegistrarMiniMarket();

            ObjFrmMinimarket.MidParent = this;

            ObjFrmMinimarket.Show();
            ObjFrmMinimarket.WindowState = FormWindowState.Maximized;
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmRegistrarProveedor ObjFrmProveedor = new FrmRegistrarProveedor();

            //ObjFrmProveedor.MidParent = this;

            //ObjFrmProveedor.Show();
            //ObjFrmProveedor.WindowState = FormWindowState.Maximized;
        }

        private void FrmRegistrarProveedor(object sender, EventArgs e)
        {
            FrmRegistrarProveedor ObjFrmProveedor = new FrmRegistrarProveedor();

            ObjFrmProveedor.MidParent = this;

            ObjFrmProveedor.Show();
            ObjFrmProveedor.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmActualizarMiniMarket ObjFrmMinimarket = new FrmActualizarMiniMarket();

            //ObjFrmMinimarket.MidParent=this;

            //ObjFrmMinimarket.Show();
            //ObjFrmMinimarket.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmRegistrarMiniMarket ObjFrmMinimarket = new FrmRegistrarMiniMarket();

            //ObjFrmMinimarket.MidParent = this;

            //ObjFrmMinimarket.Show();
            //ObjFrmMinimarket.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultarProveedor ObjFrmProveedor = new FrmConsultarProveedor();

            ObjFrmProveedor.MidParent = this;

            ObjFrmProveedor.Show();
            ObjFrmProveedor.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria ObjFrmCategoria = new FrmRegistrarCategoria();

            ObjFrmCategoria.MidParent = this;

            ObjFrmCategoria.Show();
            ObjFrmCategoria.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmConsultarCategoria ObjFrmCategoria = new FrmConsultarCategoria();

            ObjFrmCategoria.MidParent = this;

            ObjFrmCategoria.Show();
            ObjFrmCategoria.WindowState = FormWindowState.Maximized;
        }

        private void registrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente ObjFrmCliente = new FrmRegistrarCliente();

            ObjFrmCliente.MidParent = this;

            ObjFrmCliente.Show();
            ObjFrmCliente.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente ObjFrmCliente = new FrmConsultarCliente();

            ObjFrmCliente.MidParent = this;

            ObjFrmCliente.Show();
            ObjFrmCliente.WindowState = FormWindowState.Maximized;
        }
    }
}
