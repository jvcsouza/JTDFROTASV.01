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
    public partial class ConsultaUF : Form
    {
        private bool selecionar = false;
        private TextBox campo;

        public ConsultaUF()
        {
            InitializeComponent();
        }
        public ConsultaUF(TextBox campo)
        {
            InitializeComponent();
            this.campo = campo;
            selecionar = true;
            btnSelecionar.Enabled = true;
        }

        private void ConsultaUF_Load(object sender, EventArgs e)
        {
            dgvUF.DataSource = UF.Listar(true);
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbSim.Checked)
                return;
            dgvUF.DataSource = UF.Listar(true);
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbNao.Checked)
                return;
            dgvUF.DataSource = UF.Listar(false);
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbTodos.Checked)
                return;
            dgvUF.DataSource = UF.Listar();
        }

        private void dgvUF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Atualiza Estado"))
                return;
            FormUF fUF = new FormUF();
            fUF.MdiParent = Form1.container;
            fUF.Show();
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

        private void editarCelula()
        {
            if (childrenAberto("Atualiza Estado"))
                return;
            int id = (int)dgvUF.CurrentRow.Cells[0].Value;
            String nome = dgvUF.CurrentRow.Cells[1].Value.ToString();
            String sigla = dgvUF.CurrentRow.Cells[2].Value.ToString();
            //bool ativo = (bool)dgvUF.CurrentRow.Cells[4].Value;
            UF estado = new UF(id, nome, sigla, true);
            FormUF fUF = new FormUF(estado);
            fUF.MdiParent = Form1.container;
            fUF.Show();
        }

        private void dgvUF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!selecionar) editarCelula();
            else { 
                campo.Text = dgvUF.CurrentRow.Cells[0].Value.ToString();
                Dispose();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarCelula();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            dgvUF_CellDoubleClick(null, null);
        }
    }
}
