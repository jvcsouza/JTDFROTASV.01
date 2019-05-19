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

namespace JTDFROTAS
{
    public partial class FormLogin : Form
    {
        private ToolStrip tool;
        private ToolStripLabel user;
        public FormLogin(ToolStrip tools, ToolStripLabel user)
        {
            tool = tools;
            this.user = user;
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Conexao c = new Conexao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtUsuario.Text)
                || String.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show(this, "Preencha todos os campos!", "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (new Usuario(txtUsuario.Text.Trim(), txtSenha.Text.Trim()).Logar())
            {
                this.Dispose();
                tool.Visible = true;
                user.Text = Usuario.Nome;
            }
            else MessageBox.Show("Usuario não encontrado!");
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnCancelar.PerformClick();
        }
    }
}
