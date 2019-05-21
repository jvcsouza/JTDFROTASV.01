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
    public partial class FormModelo : Form
    {
        public FormModelo()
        {
            InitializeComponent();
        }
        public FormModelo(Modelo m)
        {
            InitializeComponent();
            txtCodMarca.Text = m.CodMarca.ToString();
            txtNome.Text = m.Nome;
            txtId.Text = m.Id.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormModelo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscaMarca_Click(object sender, EventArgs e)
        {
            ConsultaMarca consMarca = new ConsultaMarca(txtCodMarca);
            consMarca.MdiParent = Form1.container;
            consMarca.Show();
        }

        private void txtCodMarca_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodMarca.Text))
            {
                txtMarca.Text = "";
                return;
            }
            if(!Int32.TryParse(txtCodMarca.Text, out int id))
                return;
            Marca m = Marca.Buscar(id);
            txtMarca.Text = m.Nome;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
