using System;
using System.Windows.Forms;
using JTDFROTAS.Classes;

namespace JTDFROTAS.geralSistema.origemDestino
{
    public partial class FormUF : Form
    {
        public FormUF()
        {
            InitializeComponent();
        }

        public FormUF(UF uf)
        {
            InitializeComponent();
            txtId.Text = uf.Id.ToString();
            txtNome.Text = uf.Nome;
            txtSigla.Text = uf.Sigla;
        }

        private void FormUF_Load(object sender, EventArgs e)
        {
            
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
