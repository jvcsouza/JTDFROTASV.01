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
using JTDFROTAS.geralVeiculos;
using JTDFROTAS.Pessoa;

namespace JTDFROTAS
{
    public partial class VeiculoMotorista : Form
    {
        private List<Veiculo> listVeiculo;
        private ListView list;

        public VeiculoMotorista(ListView lsView)
        {
            InitializeComponent();
            listVeiculo = null;
            list = lsView;
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

        private void btnBuscaVeiculo_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Atualiza Veiculo"))
                return;
            ConsultaVeiculo consVeiculo = new ConsultaVeiculo(txtCodVeiculo);
            consVeiculo.MdiParent = Form1.container;
            consVeiculo.Show();
        }

        private void VeiculoMotorista_Load(object sender, EventArgs e)
        {
            
        }

        private void liberaVinculo(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMotorista.Text)
               || String.IsNullOrWhiteSpace(txtVeiculo.Text))
                btnSelecionar.Enabled = false;
            else btnSelecionar.Enabled = true;
        }

        private void txtCodVeiculo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodVeiculo.Text.Trim())
                || !Int32.TryParse(txtCodVeiculo.Text.Trim(), out int i))
            {
                txtVeiculo.Text = "";
                return;
            }
            txtVeiculo.Text = Veiculo.Buscar(i);
        }

        private void btnBuscaMoto_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Pessoa"))
                return;
            ConsultaPessoa consPessoa = new ConsultaPessoa(true, txtCodMotorista);
            consPessoa.MdiParent = Form1.container;
            consPessoa.Show();
        }

        private void txtCodMotorista_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodMotorista.Text.Trim())
                || !Int32.TryParse(txtCodMotorista.Text.Trim(), out int i))
            {
                txtMotorista.Text = "";
                return;
            }
            txtMotorista.Text = Motorista.Buscar(i);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            ListViewItem listItem = new ListViewItem(txtVeiculo.Text);
            listItem.SubItems.Add(txtMotorista.Text);
            list.Items.Add(listItem);
            list.Visible = false;
            list.Visible = true;
            Dispose();
        }
    }
}
