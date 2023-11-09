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
    public partial class FrmRegistrarCategoria : Form
    {
        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        public Form1 MidParent { get; internal set; }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            Categoria objCategoria=new Categoria();

            objCategoria.Nombre=txtBoxRegistrarNombreCategoria.Text.Trim();
            objCategoria.Descripcion=txtBoxRegistrarDescripcionCategoria.Text.Trim();

            if (CN_Categoria.InsertarCategoria(objCategoria)) 
            {
                MessageBox.Show("Registro exitoso");
            }
            else 
            {
                MessageBox.Show("Fallo en la insercion");
            }
        }
    }
}
