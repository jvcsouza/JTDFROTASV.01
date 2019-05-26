using System;
using System.Windows.Forms;
using JTDFROTAS.Classes;

namespace JTDFROTAS.geralVeiculos
{
    public partial class ConsultaModelo : Form
    {
        public ConsultaModelo()
        {
            InitializeComponent();
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

        private void dgvModelo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int) dgvModelo.CurrentRow.Cells[0].Value;
            int codMarca = (int)dgvModelo.CurrentRow.Cells[1].Value;
            String nome = dgvModelo.CurrentRow.Cells[3].Value.ToString();
            //bool ativo = (bool)dgvMarca.CurrentRow.Cells[2].Value;

            Modelo m = new Modelo(id, codMarca, nome);
            FormModelo fModelo = new FormModelo(m);
            fModelo.MdiParent = Form1.container;
            fModelo.Show();
        }

        private void dgvModelo_DataSourceChanged(object sender, EventArgs e)
        {
            if(dgvModelo.Rows.Count > 0)
                dgvModelo.Columns["CODMARCA"].Visible = false;
        }
    }
}
