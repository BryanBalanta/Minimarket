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
    public partial class FrmRegistrarFactura : Form
    {
        public FrmRegistrarFactura()
        {
            InitializeComponent();
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            Factura objFactura = new Factura();

            objFactura.CodigoFactura = txtBoxRegistrarCodigoFactura.Text.Trim();
            objFactura.FechaGeneracion = txtBoxRegistrarFechaGeneracionFactura.Text.Trim();
            objFactura.Iva = txtBoxRegistrarIvaFactura.Text.Trim();
            objFactura.SinIva = txtBoxRegistrarSinIvaFactura.Text.Trim();
            objFactura.Total = txtBoxRegistrarTotalFactura.Text.Trim();

            if (CN_Factura.InsertarFactura(objFactura))
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
