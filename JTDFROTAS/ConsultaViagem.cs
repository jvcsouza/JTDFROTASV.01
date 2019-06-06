using JTDFROTAS.Classes;
using JTDFROTAS.Movimento;
using System;
using System.Windows.Forms;

namespace JTDFROTAS
{
    public partial class ConsultaViagem : Form
    {
        public ConsultaViagem()
        {
            InitializeComponent();
        }

        private void ConsultaViagem_Load(object sender, EventArgs e)
        {
            dgvViagem.DataSource = Viagem.Listar();
        }

        private void dgvViagem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            String nome = dgvViagem.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show(this, $"Deseja realmente cancelar a viagem de {nome} ??\nA Operação não pode ser desfeita!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
                return;
            try
            {
                Viagem.Cancelar(Int32.Parse(dgvViagem.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show(this, $"Viagem Cancelada com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvViagem.DataSource = Viagem.Listar();
            }
            catch(Exception err)
            {
                MessageBox.Show(Form1.container, err.Message, $"ERROR {err.HResult}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormViagem fViagem = new FormViagem();
            fViagem.MdiParent = Form1.container;
            fViagem.Show();
        }
    }
}
