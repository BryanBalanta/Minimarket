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
    public partial class FrmActualizarMiniMarket : Form
    {
        public FrmActualizarMiniMarket()
        {
            InitializeComponent();
        }

        private void btnActualizarMiniMarket_Click(object sender, EventArgs e)
        {

        }

        private void FrmActualizarMiniMarket_Load(object sender, EventArgs e)
        {
            DataTable MiTablaDatos = new DataTable();

            MiTablaDatos = CN_MiniMarket.ConsultarMinimarket();


            txtBoxActualizarNitMiniMarket.Text = MiTablaDatos.Rows[0]["nit"].ToString();
            txtBoxActualizarRazonSocialMiniMarket.Text = MiTablaDatos.Rows[0]["razonSocial"].ToString();
            txtBoxActualizarTelefonoMiniMarket.Text = MiTablaDatos.Rows[0]["telefono"].ToString();
            txtBoxActualizarNomenclaturaMiniMarket.Text = MiTablaDatos.Rows[0]["nomenclatura"].ToString();
            txtBoxActualizarCiudadMiniMarket.Text = MiTablaDatos.Rows[0]["ciudad"].ToString();
            txtBoxActualizarDepartamentoMiniMarket.Text = MiTablaDatos.Rows[0]["departamento"].ToString();
            txtBoxActualizarCorreoMiniMarket.Text = MiTablaDatos.Rows[0]["correo"].ToString();
            txtBoxActualizarSitioWebMiniMarket.Text = MiTablaDatos.Rows[0]["sitioWeb"].ToString();
            txtBoxActualizarFacebookMiniMarket.Text = MiTablaDatos.Rows[0]["Facebook"].ToString();
            txtBoxActualizarWhatsappMiniMarket.Text = MiTablaDatos.Rows[0]["whatsapp"].ToString();
        }

        private void gbActualizarMiniMarket_Enter(object sender, EventArgs e)
        {

        }
    }
}
