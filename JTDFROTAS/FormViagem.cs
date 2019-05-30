using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTDFROTAS.Classes;
using System.Net;

namespace JTDFROTAS.Movimento
{
    public partial class FormViagem : Form
    {
        public FormViagem()
        {
            InitializeComponent();
        }

        private void FormViagem_Load(object sender, EventArgs e)
        {
            MapsApi a = APIs.consultaMaps("cila, 2774, vila imperial", "shopping iguatemi saojosedoriopreto");
            
            label2.Text = a.DestinationAddresses[0];
            label1.Text = a.OriginAddresses[0];
            label3.Text = a.Rows[0].Elements[0].Distance.Text;
            label4.Text = a.Rows[0].Elements[0].Duration.Text;

            ReceitaApi b = APIs.consultaCNPJ("53216453000116");
            label9.Text = b.Nome;
        }

       

        

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CrystalReport11_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
