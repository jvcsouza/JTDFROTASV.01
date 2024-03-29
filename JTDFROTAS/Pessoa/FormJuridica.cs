﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTDFROTAS.Classes;
using JTDFROTAS.geralSistema.origemDestino;

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
            if (String.IsNullOrWhiteSpace(txtCnpj.Text.Trim())
                || String.IsNullOrWhiteSpace(txtNome.Text.Trim())
                    || String.IsNullOrWhiteSpace(txtCodCidade.Text.Trim()))
            {
                MessageBox.Show(Form1.container, "Todos os campos precisam ser preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private bool childrenAberto(String formName)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.Text == formName)
                {
                    form.Focus();
                    return true;
                }
            }
            return false;
        }
        private void btnBuscaCidade_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Cidade"))
                return;
            ConsultaCidade consCidade = new ConsultaCidade(txtCodCidade);
            consCidade.MdiParent = Form1.container;
            consCidade.Show();
        }

        private void txtCodCidade_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodCidade.Text.Trim())
               || !Int32.TryParse(txtCodCidade.Text.Trim(), out int i))
            {
                txtCidade.Text = "";
                return;
            }
            txtCidade.Text = Cidade.Buscar(i);
        }
    }
}
