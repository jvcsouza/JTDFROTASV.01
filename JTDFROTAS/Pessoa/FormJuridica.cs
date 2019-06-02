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

namespace JTDFROTAS.Pessoa
{
    public partial class FormJuridica : Form
    {
        public FormJuridica()
        {
            InitializeComponent();
        }

        private void btnConsultaCNPJ_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtConsultaCNPJ.Text.Trim()))
                return;
            ReceitaApi empresa = APIs.consultaCNPJ(txtConsultaCNPJ.Text);
            txtFantasia.Text = empresa.Fantasia;
            txtNome.Text = empresa.Nome;
            txtLogradouro.Text = empresa.Logradouro;
            txtLogradouroN.Text = empresa.Numero.ToString();
            txtCidade.Text = empresa.Municipio;
            txtCnpj.Text = empresa.Cnpj;
            txtAtividade.Text = empresa.AtividadePrincipal[0].Text;
            txtCodCidade.Text = Cidade.BuscarRegistrar(txtCidade.Text.Trim(), empresa.Uf).ToString();
        }

        private void FormJuridica_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Juridica p = new Juridica(txtNome.Text,
                                      txtLogradouro.Text,
                                      txtLogradouroN.Text,
                                      Int32.Parse(txtCodCidade.Text),
                                      txtCnpj.Text,
                                      txtFantasia.Text,
                                      txtAtividade.Text);
            if (!p.Registrar())
                throw new Exception();
            txtId.Text = p.CodPessoaJuridica.ToString();
            Dispose();
        }
    }
}
