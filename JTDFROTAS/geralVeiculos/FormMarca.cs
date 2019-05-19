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

namespace JTDFROTAS.geralVeiculos
{
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }
        public FormMarca(Marca marca)
        {
            InitializeComponent();
            txtId.Text = Convert.ToString(marca.Id);
            txtNome.Text = marca.Nome;
            chkAtivo.Checked = marca.Ativo;
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
