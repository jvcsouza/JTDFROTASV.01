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
using Newtonsoft.Json;

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
            MapsApi a = NovoMaps("cantanduva", "riograndedosul");
            
            label2.Text = a.DestinationAddresses[0];
            label1.Text = a.OriginAddresses[0];
            label3.Text = a.Rows[0].Elements[0].Distance.Text;
            label4.Text = a.Rows[0].Elements[0].Duration.Text;

            label9.Text = consultaCNPJ("53216453000116").Nome;
        }

        public ReceitaApi consultaCNPJ(String cnpj)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            client.Headers.Add("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            String json = client.DownloadString($" https://www.receitaws.com.br/v1/cnpj/{cnpj}");
            return JsonConvert.DeserializeObject<ReceitaApi>(json);
        }

        public MapsApi NovoMaps(String origem, String destino)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            client.Headers.Add("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            String json = client.DownloadString($"https://maps.googleapis.com/maps/api/distancematrix/json?origins={origem}&destinations={destino}&key=AIzaSyD7yhJ82pacq_YAidfXTgqYhcjFfTd-E80");
            return JsonConvert.DeserializeObject<MapsApi>(json);
            //Console.WriteLine(m.Rows[0].Elements[0].Duration.Text);
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
