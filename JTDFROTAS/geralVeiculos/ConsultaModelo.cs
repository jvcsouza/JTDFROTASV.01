using System;
using System.Windows.Forms;
using JTDFROTAS.Classes;

namespace JTDFROTAS.geralVeiculos
{
    public partial class ConsultaModelo : Form
    {
        private TextBox campo;
        private bool selecionar = false;

        public ConsultaModelo()
        {
            InitializeComponent();
        }
        public ConsultaModelo(TextBox campo)
        {
            InitializeComponent();
            this.campo = campo;
            selecionar = true;
        }

        private void ConsultaModelo_Load(object sender, EventArgs e)
        {
            dgvModelo.DataSource = Modelo.Listar(true);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormModelo fModelo = new FormModelo();
            fModelo.MdiParent = Form1.container;
            fModelo.Show();
        }

        private void editarCelula()
        {
            int id = (int)dgvModelo.CurrentRow.Cells[0].Value;
            int codMarca = (int)dgvModelo.CurrentRow.Cells[1].Value;
            String nome = dgvModelo.CurrentRow.Cells[3].Value.ToString();
            bool ativo = (bool)dgvModelo.CurrentRow.Cells[4].Value;

            Modelo m = new Modelo(id, codMarca, nome, ativo);
            FormModelo fModelo = new FormModelo(m);
            fModelo.MdiParent = Form1.container;
            fModelo.Show();
        }

        private void dgvModelo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selecionar)
            {
                int id = (int)dgvModelo.CurrentRow.Cells[0].Value;
                campo.Text = id.ToString();
            }
            else editarCelula();
        }

        private void dgvModelo_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvModelo.Rows.Count <= 0)
                return;
            dgvModelo.Columns["CODMARCA"].Visible = false;
            dgvModelo.Columns["ATIVO"].Visible = false;
        }

        private void dgvModelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Visible = true;
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
                dgvModelo.DataSource = Modelo.Listar(true);
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked)
                dgvModelo.DataSource = Modelo.Listar(false);
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodos.Checked)
                dgvModelo.DataSource = Modelo.Listar();
        }
    }
}
