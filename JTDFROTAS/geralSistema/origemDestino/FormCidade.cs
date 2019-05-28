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

namespace JTDFROTAS.geralSistema.origemDestino
{
    public partial class FormCidade : Form
    {
        public FormCidade()
        {
            InitializeComponent();
        }
        public FormCidade(Cidade c)
        {
            InitializeComponent();
            txtCodEstado.Text = c.CodUf.ToString();
            txtNome.Text = c.Nome;
            chkAtivo.Checked = c.Ativo;
            txtId.Text = c.Id.ToString();
        }

        private void FormCidade_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscaEstado_Click(object sender, EventArgs e)
        {
            ConsultaUF consUF = new ConsultaUF(txtCodEstado);
            consUF.MdiParent = Form1.container;
            consUF.Show();
        }

        private void txtCodEstado_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodEstado.Text))
            {
                txtEstado.Text = "";
                return;
            }
            if (!Int32.TryParse(txtCodEstado.Text, out int id))
                return;
            UF u = UF.Buscar(id);
            txtEstado.Text = u.Nome;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEstado.Text)
                || String.IsNullOrWhiteSpace(txtNome.Text))
                MessageBox.Show(this, "Verifique se campos estão preenchidos ou inconsistentes e tente novamente!", "Problemas!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //gravar
            }
        }
    }
}
