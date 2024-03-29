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

namespace JTDFROTAS.Pessoa
{
    public partial class ConsultaPessoa : Form
    {
        private bool selecionar = false;
        private TextBox campo;
        private bool moto = false;

        public ConsultaPessoa()
        {
            InitializeComponent();
            dgvPessoa.DataSource = Juridica.Listar(true);
        }
        public ConsultaPessoa(TextBox campo)
        {
            InitializeComponent();
            selecionar = true;
            btnSelecionar.Enabled = true;
            this.campo = campo;
            dgvPessoa.DataSource = Juridica.Listar(true);
        }
        public ConsultaPessoa(bool motorista, TextBox campo)
        {
            InitializeComponent();
            moto = motorista;
            selecionar = true;
            btnSelecionar.Enabled = true;
            this.campo = campo;
            gpbAtivo.Enabled = false;
            gpbTipo.Enabled = false;
            dgvPessoa.DataSource = Motorista.Listar(true);
            //dgvPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        private void ConsultaPessoa_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked)
                dgvPessoa.DataSource = Juridica.Listar(false);
            else if (rdbSim.Checked)
                dgvPessoa.DataSource = Juridica.Listar(true);
            else if (rdbTodos.Checked)
                dgvPessoa.DataSource = Juridica.Listar();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJuridica.Checked)
                dgvPessoa.DataSource = Juridica.Listar();
            else if (rdbFisica.Checked)
                dgvPessoa.DataSource = Fisica.Listar();
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJuridica.Checked)
                dgvPessoa.DataSource = Juridica.Listar(false);
            else if (rdbFisica.Checked)
                dgvPessoa.DataSource = Fisica.Listar(false);
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJuridica.Checked)
                dgvPessoa.DataSource = Juridica.Listar(true);
            else if (rdbFisica.Checked)
                dgvPessoa.DataSource = Fisica.Listar(true);
        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked)
                dgvPessoa.DataSource = Fisica.Listar(false);
            else if (rdbSim.Checked)
                dgvPessoa.DataSource = Fisica.Listar(true);
            else if (rdbTodos.Checked)
                dgvPessoa.DataSource = Fisica.Listar();
        }

        private void dgvPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPessoa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selecionar)
            {
                campo.Text = dgvPessoa.CurrentRow.Cells[0].Value.ToString();
                Dispose();
                return;
            }
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPesquisaNome.Text.Trim()))
                return;
            DataTable table = null;

            if (rdbSim.Checked)
                if (moto)
                    table = Motorista.Listar(true);
                else
                    if (rdbJuridica.Checked) table = Juridica.ListarBusca(txtPesquisaNome.Text.Trim(), true);
                    else table = Fisica.ListarBusca(txtPesquisaNome.Text.Trim(), true);
            else if (rdbNao.Checked)
                if (moto)
                    table = Motorista.Listar(false);
                else
                    if (rdbJuridica.Checked) table = Juridica.ListarBusca(txtPesquisaNome.Text.Trim(), false);
                    else table = Fisica.ListarBusca(txtPesquisaNome.Text.Trim(), false);
            else if (rdbTodos.Checked)
                if (moto)
                    table = Motorista.Listar();
                else
                    if (rdbJuridica.Checked) table = Juridica.ListarBusca(txtPesquisaNome.Text.Trim());
                    else table = Fisica.ListarBusca(txtPesquisaNome.Text.Trim());
            dgvPessoa.DataSource = table;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvPessoa.CurrentRow.Cells[0].Value.ToString());
            if (rdbJuridica.Checked)
                dgvPessoa.DataSource = Juridica.Excluir(id);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            dgvPessoa_CellContentDoubleClick(null, null);
        }
    }
}
