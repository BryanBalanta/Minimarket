using CL_Capa_Entidades;
using CL_Capa_Negocio;
using Microsoft.Win32;
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
    public partial class FrmRegistrarOrdenDeCompra : Form
    {
        public FrmRegistrarOrdenDeCompra()
        {
            InitializeComponent();
        }

        private void btnGuardarOrdenDeCompras_Click(object sender, EventArgs e)
        {
            OrdenDeCompra objOrdenDeCompra = new OrdenDeCompra();

            objOrdenDeCompra.CodigoOrdenDeCompra = txtBoxRegistrarCodigoCliente.Text.Trim();
            objOrdenDeCompra.Iva = txtBoxRegistrarIvaOrdenDeCompra.Text.Trim();
            objOrdenDeCompra.PrecioTotal = txtBoxRegistrarPrecioTotalOrdenDeCompra.Text.Trim();
            objOrdenDeCompra.FechaPedido = txtBoxRegistrarFechaPedidoFactura.Text.Trim();
            objOrdenDeCompra.FechaEntrega = txtBoxRegistrarfechaEntregaOrdenDeCompra.Text.Trim();
            objOrdenDeCompra.TotalSinIva = txtBoxRegistrarTotalSinIvaOrdenDeCompra.Text.Trim();

            if (CN_OrdenDeCompra.InsertarOrdenDeCompra(objOrdenDeCompra))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
            {
                MessageBox.Show("Fallo en  la insercion");
            }
        }
    }
}
