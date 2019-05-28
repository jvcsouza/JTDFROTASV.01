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
    public partial class ConsultaCidade : Form
    {
        private bool selecionar = false;
        private TextBox campo;
        public ConsultaCidade()
        {
            InitializeComponent();
        }
        public ConsultaCidade(TextBox campo)
        {
            InitializeComponent();
            this.campo = campo;
            selecionar = true;
        }

        private void ConsultaCidade_Load(object sender, EventArgs e)
        {
            dgvCidade.DataSource = Cidade.Listar(true);
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbSim.Checked)
                return;
            dgvCidade.DataSource = Cidade.Listar(true);
        }

        private void dgvCidade_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvCidade.Rows.Count <= 0)
                return;
            dgvCidade.Columns["CODESTADO"].Visible = false;
            dgvCidade.Columns["ATIVO"].Visible = false;
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbNao.Checked)
                return;
            dgvCidade.DataSource = Cidade.Listar(false);
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbTodos.Checked)
                return;
            dgvCidade.DataSource = Cidade.Listar();
        }

        private void dgvCidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Visible = true;
        }

        private bool childrenAberto(String formName)
        {
            foreach (Form form in Form1.container.MdiChildren)
            {
                if (form.Text == formName)
                {
                    form.Focus();
                    return true;
                }
            }
            return false;
        }

        private void editarCelular()
        {
            if (childrenAberto("Atualiza Cidade"))
                return;
            int id = (int) dgvCidade.CurrentRow.Cells[0].Value;
            String nome = dgvCidade.CurrentRow.Cells[2].Value.ToString();
            int codEstado = (int) dgvCidade.CurrentRow.Cells[1].Value;
            bool ativo = (bool) dgvCidade.CurrentRow.Cells[5].Value;
            Cidade c = new Cidade(id, nome, codEstado, ativo);
            FormCidade fCidade = new FormCidade(c);
            fCidade.MdiParent = Form1.container;
            fCidade.Show();
        }
        private void dgvCidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!selecionar) editarCelular();
            else
            {
                campo.Text = dgvCidade.CurrentRow.Cells[0].Value.ToString();
                Dispose();
            }
        }
    }
}
