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
    public partial class FormVeiculo : Form
    {
        public FormVeiculo()
        {
            InitializeComponent();
        }

        private void txtCodModelo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodModelo.Text))
            {
                txtModelo.Text = "";
                return;
            }
            if (!Int32.TryParse(txtCodModelo.Text, out int id))
                return;
            Modelo m = Modelo.Buscar(id);
            txtModelo.Text = m.Nome;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscaModelo_Click(object sender, EventArgs e)
        {
            ConsultaModelo consModelo = new ConsultaModelo(txtCodModelo);
            consModelo.MdiParent = Form1.container;
            consModelo.Show();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPlaca.Text.Trim())
                || String.IsNullOrWhiteSpace(txtModelo.Text.Trim())
                    || String.IsNullOrWhiteSpace(txtCodCliente.Text.Trim())
                        || String.IsNullOrWhiteSpace(txtCustoMedio.Text.Trim()))
            {
                MessageBox.Show(this, "Todos os campos precisam ser Preenchidos!", "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String placa = txtPlaca.Text.Trim();
            int modelo = Int32.Parse(txtModelo.Text.Trim());
            int cliente = Int32.Parse(txtCodCliente.Text.Trim());
            double custoMedio = Double.Parse(txtCustoMedio.Text.Trim());
            String tipoVeiculo = cboTipo.SelectedText;
            Veiculo v = new Veiculo(placa,
                                    tipoVeiculo,
                                    modelo,
                                    cliente,
                                    custoMedio);
            v.Registrar();
        }

        private void FormVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
