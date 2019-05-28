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
    }
}
