using System;
using System.Windows.Forms;
using JTDFROTAS.Classes;

namespace JTDFROTAS.Pessoa
{
    public partial class FormFisica : Form
    {
        public FormFisica()
        {
            InitializeComponent();
        }
        public FormFisica(Fisica pFisica)
        {
            txtId.Text = pFisica.IdFisica.ToString();
            txtNome.Text = pFisica.Nome;
            txtCpf.Text = pFisica.Cpf;
            txtCodCidade.Text = pFisica.CodCidade.ToString();
            txtLogradouroN.Text = pFisica.Endereco[1].ToString();
            txtLogradouro.Text = pFisica.Endereco[0].ToString();
            foreach (Telefone fone in pFisica.Contatos)
            {
                lbxContatos.Items.Add("{fone.Contato} : {fone.Fone}");
            }
        }

        private void FormFisica_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Fisica pFisica = new Fisica(txtNome.Text.Trim(),
                                        txtLogradouro.Text.Trim(),
                                        txtLogradouroN.Text.Trim(),
                                        Int32.Parse(txtCodCidade.Text.Trim()),
                                        txtCpf.Text.Trim());
        }
    }
}
