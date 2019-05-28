using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTDFROTAS.geralVeiculos
{
    public partial class ConsultaVeiculo : Form
    {
        public ConsultaVeiculo()
        {
            InitializeComponent();
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
    }
}
