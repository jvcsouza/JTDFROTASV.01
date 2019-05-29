using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTDFROTAS.Pessoa
{
    public partial class ConsultaFisica : Form
    {
        private bool selecionar = false;
        private TextBox campo;

        public ConsultaFisica()
        {
            InitializeComponent();
        }
        public ConsultaFisica(TextBox campo)
        {
            InitializeComponent();
            this.campo = campo;
            selecionar = true;
        }

        private void ConsultaFisica_Load(object sender, EventArgs e)
        {

        }
    }
}
