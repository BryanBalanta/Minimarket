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
    public partial class FrmRegistrarProducto : Form
    {
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void gbRegistrarProducto_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto();

            objProducto.Nombre=txtBoxRegistrarNombreProducto.Text.Trim();
            objProducto.Marca=txtBoxRegistrarMarcaProducto.Text.Trim();
            objProducto.Stock=txtBoxRegistrarStockProducto.Text.Trim();
            objProducto.PVP=txtBoxRegistrarPrecioVentaPublicoProducto.Text.Trim();
            objProducto.Descripcion=txtBoxRegistrarDescripcionProducto.Text.Trim();
            objProducto.UnidadMedida = cbBoxRegistrarUnidadMedidaProducto.SelectedItem.ToString();

            if (CN_Producto.InsertarProducto(objProducto))
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
