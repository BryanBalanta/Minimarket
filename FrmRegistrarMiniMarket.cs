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
    public partial class FrmRegistrarMiniMarket : Form
    {
        public FrmRegistrarMiniMarket()
        {
            InitializeComponent();
        }

        public Form1 MidParent { get; set; }

        private void btnGuardarMiniMarket_Click(object sender, EventArgs e)
        {
            Minimarket objMiniMarket = new Minimarket();

            objMiniMarket.RazonSocial = txtBoxRegistrarRazonSocialMiniMarket.Text.Trim();
            objMiniMarket.Telefono = txtBoxRegistrarTelefonoMiniMarket.Text.Trim();
            objMiniMarket.Nomenclatura = txtBoxRegistrarNomenclaturaMiniMarket.Text.Trim();
            objMiniMarket.Ciudad = txtBoxRegistrarCiudadMiniMarket.Text.Trim();
            objMiniMarket.Departamento = txtBoxRegistrarDepartamentoMiniMarket.Text.Trim();
            objMiniMarket.Correo = txtBoxRegistrarCorreoMiniMarket.Text.Trim();
            objMiniMarket.SitioWeb = txtBoxRegistrarSitioWebMiniMarket.Text.Trim();
            objMiniMarket.Facebook = txtBoxRegistrarFacebookMiniMarket.Text.Trim();
            objMiniMarket.Whatsapp = txtBoxRegistrarWhatsappMiniMarket.Text.Trim();

            if (CN_MiniMarket.ActualizarMinimaket(objMiniMarket))
            {
                MessageBox.Show("Actualizacion Exitosa");
            }
            else
            {
                MessageBox.Show("Actualizacion no Exitosa");
            }

            //if (CN_MiniMarket.InsertarMiniMarket(objMiniMarket))
            //{
            //    MessageBox.Show("Registro Exitoso");
            //}
            //else
            //{
            //    MessageBox.Show("Fallo en la insercion");
            //    //}
            //}
        }
        private void gbRegistroMiniMarket_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRegistrarMiniMarket_Load(object sender, EventArgs e)
        {
            DataTable MiTablaDatos = new DataTable();

            MiTablaDatos = CN_MiniMarket.ConsultarMinimarket();

            txtBoxRegistrarNITMiniMarket.Text = MiTablaDatos.Rows[0]["nit"].ToString();
            txtBoxRegistrarRazonSocialMiniMarket.Text = MiTablaDatos.Rows[0]["razonSocial"].ToString();
            txtBoxRegistrarTelefonoMiniMarket.Text = MiTablaDatos.Rows[0]["telefono"].ToString();
            txtBoxRegistrarNomenclaturaMiniMarket.Text = MiTablaDatos.Rows[0]["nomenclatura"].ToString();
            txtBoxRegistrarCiudadMiniMarket.Text = MiTablaDatos.Rows[0]["ciudad"].ToString();
            txtBoxRegistrarDepartamentoMiniMarket.Text = MiTablaDatos.Rows[0]["departamento"].ToString();
            txtBoxRegistrarCorreoMiniMarket.Text = MiTablaDatos.Rows[0]["correo"].ToString();
            txtBoxRegistrarSitioWebMiniMarket.Text = MiTablaDatos.Rows[0]["sitioWeb"].ToString();
            txtBoxRegistrarFacebookMiniMarket.Text = MiTablaDatos.Rows[0]["Facebook"].ToString();
            txtBoxRegistrarWhatsappMiniMarket.Text = MiTablaDatos.Rows[0]["whatsapp"].ToString();
        }
    }
}
