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
    public partial class ConsultaVeiculo : Form
    {
        private TextBox campo;
        private bool selecionar = false;
        public ConsultaVeiculo()
        {
            InitializeComponent();
        }
        public ConsultaVeiculo(TextBox campo)
        {
            InitializeComponent();
            this.campo = campo;
            selecionar = true;
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Atualiza Veiculo"))
                return;
            FormVeiculo fVeiculo = new FormVeiculo();
            fVeiculo.MdiParent = Form1.container;
            fVeiculo.Show();
        }

        private void ConsultaVeiculo_Load(object sender, EventArgs e)
        {
            dgvVeiculo.DataSource = Veiculo.Listar(true);
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
                dgvVeiculo.DataSource = Veiculo.Listar(true);
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked)
                dgvVeiculo.DataSource = Veiculo.Listar(false);
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
                dgvVeiculo.DataSource = Veiculo.Listar();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void dgvVeiculo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!selecionar)
                return;
            int id = (int) dgvVeiculo.CurrentRow.Cells[0].Value;
            campo.Text = id.ToString();
            Dispose();
        }
    }
}
