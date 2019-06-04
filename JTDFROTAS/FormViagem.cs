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
using System.Net;
using JTDFROTAS.Pessoa;
using JTDFROTAS.geralSistema.origemDestino;

namespace JTDFROTAS.Movimento
{
    public partial class FormViagem : Form
    {
        private List<Veiculo> listVeiculo;
        public FormViagem()
        {
            InitializeComponent();
        }

        private void FormViagem_Load(object sender, EventArgs e)
        {
            /*MapsApi a = APIs.consultaMaps("cila, 2774, vila imperial", "shopping iguatemi saojosedoriopreto");
            
            txtDestino.Text = a.DestinationAddresses[0];
            txtOrigem.Text = a.OriginAddresses[0];
            txtDuracao.Text = a.Rows[0].Elements[0].Distance.Text;
            txtDistancia.Text = a.Rows[0].Elements[0].Duration.Text;

            ReceitaApi b = APIs.consultaCNPJ("53216453000116");
            label9.Text = b.Nome;*/
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Vinculo Auxiliar"))
                return;
            VeiculoMotorista auxiliar = new VeiculoMotorista(lsView);
            auxiliar.MdiParent = Form1.container;
            auxiliar.Show();
        }

        private void txtCodOrigem_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodOrigem.Text.Trim())
                || !Int32.TryParse(txtCodOrigem.Text.Trim(), out int i))
            {
                txtOrigem.Text = "";
                return;
            }
            txtOrigem.Text = Cidade.Buscar(i);
        }

        private void txtCodDestino_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodDestino.Text.Trim())
                || !Int32.TryParse(txtCodDestino.Text.Trim(), out int i))
            {
                txtDestino.Text = "";
                return;
            }
            txtDestino.Text = Cidade.Buscar(i);
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

        private void btnBuscaCidadeOrigem_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Cidade"))
                return;
            ConsultaCidade consCidade = new ConsultaCidade(txtCodOrigem);
            consCidade.MdiParent = Form1.container;
            consCidade.Show();
        }

        private void btnBuscaCidadeDestino_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Cidade"))
                return;
            ConsultaCidade consCidade = new ConsultaCidade(txtCodDestino);
            consCidade.MdiParent = Form1.container;
            consCidade.Show();
        }
        private void liberaCalcula(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDestino.Text)
               || String.IsNullOrWhiteSpace(txtOrigem.Text))
                return;
            consultaAPI();
        }

        private void consultaAPI()
        {
            MapsApi a = APIs.consultaMaps(txtOrigem.Text.Trim(), txtDestino.Text.Trim());
            txtDuracao.Text = (null == a.Rows[0].Elements[0].Distance) ? "null" : a.Rows[0].Elements[0].Distance.Text;
            txtDistancia.Text = (null == a.Rows[0].Elements[0].Duration) ? "null" : a.Rows[0].Elements[0].Duration.Text;
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Pessoa"))
                return;
            ConsultaPessoa consPessoa = new ConsultaPessoa(txtCodCliente);
            consPessoa.MdiParent = Form1.container;
            consPessoa.Show();
        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodCliente.Text.Trim()))
            {
                txtCliente.Text = "";
                return;
            }
            if (!Int32.TryParse(txtCodCliente.Text.Trim(), out int id))
                return;
            txtCliente.Text = Classes.Pessoa.Buscar(id);
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCliente.Text.Trim()))
                gpbVeiculo.Enabled = false;
            else gpbVeiculo.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                lsView.Items.Remove(lsView.SelectedItems[0]);
            }
            catch { }
        }

        private void lsView_ItemActivate(object sender, EventArgs e)
        {

        }

        private void lsView_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
