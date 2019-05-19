using System;
using System.Windows.Forms;
using JTDFROTAS.Classes;

namespace JTDFROTAS.geralVeiculos
{
    public partial class ConsultaMarca : Form
    {
        private bool selecionar = false;
        private TextBox campo;

        public ConsultaMarca()
        {
            InitializeComponent();
        }
        public ConsultaMarca(TextBox campo)
        {
            this.campo = campo;
            selecionar = true;
        }

        private void ConsultaMarca_Load(object sender, EventArgs e)
        {
            dgvMarca.DataSource = Marca.Listar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvMarca_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (selecionar) btnSelecionar.Enabled = true;
            btnEditar.Visible = true;
        }

        private void dgvMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selecionar)
            {
                campo.Text = dgvMarca.CurrentRow.Cells[0].Value.ToString();
                Dispose();
            }
            else
            {
                if (childrenAberto("Atualiza Marca"))
                    return;
                int id = (int) dgvMarca.CurrentRow.Cells[0].Value;
                String nome = dgvMarca.CurrentRow.Cells[1].Value.ToString();
                bool ativo = (bool) dgvMarca.CurrentRow.Cells[2].Value;
                Marca m = new Marca(id, nome, ativo);
                FormMarca fm = new FormMarca(m);
                fm.MdiParent = Form1.container;
                fm.Show();
            }

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

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbSim.Checked)
                return;
            dgvMarca.DataSource = Marca.Listar(true);
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbNao.Checked)
                return;
            dgvMarca.DataSource = Marca.Listar(false);
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbTodos.Checked)
                return;
            dgvMarca.DataSource = Marca.Listar();
        }

        private void dgvMarca_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvMarca.Rows.Count <= 0)
                return;
            dgvMarca.Columns["ativo"].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Atualiza Marca"))
                return;
            FormMarca consMarca = new FormMarca();
            consMarca.MdiParent = Form1.container;
            consMarca.Show();
        }
    }
}
