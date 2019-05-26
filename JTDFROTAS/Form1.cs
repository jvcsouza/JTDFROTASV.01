﻿using System;
using JTDFROTAS.geralVeiculos;
using System.Windows.Forms;
using JTDFROTAS.Classes;
using JTDFROTAS.Pessoa;
using JTDFROTAS.geralSistema.origemDestino;

namespace JTDFROTAS
{
    public partial class Form1 : Form
    {
        public static Form container;
        public Form1()
        {
            container = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin(Bar, statusBarUser);
            //login.MdiParent = this;
            login.ShowDialog();
        }

        private bool childrenAberto(String formName)
        {
            foreach(Form form in MdiChildren)
            {
                if (form.Text == formName)
                {
                    form.Focus();
                    return true;
                }
            }
            return false;
        }

        private void btnCadMarca_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Marca"))
                return;
            ConsultaMarca consMarca = new ConsultaMarca();
            consMarca.MdiParent = this;
            consMarca.Show();
        }

        private void txtSair_Click(object sender, EventArgs e)
        {
            foreach(Form item in this.MdiChildren)
            {
                item.Dispose();
            }
            Bar.Visible = false;
            Form1_Load(null, null);
        }

        private void TimerUpdateDate_Tick(object sender, EventArgs e)
        {
            statusBarDate.Text = DateTime.Now.ToLongDateString().ToUpper();
            statusBarHours.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCadModelo_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Modelo"))
                return;
            ConsultaModelo cm = new ConsultaModelo();
            cm.MdiParent = this;
            cm.Show();
        }

        private void btnCadFisica_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Pessoa"))
                return;
            FormPessoa fPessoa = new FormPessoa();
            fPessoa.MdiParent = this;
            fPessoa.Show();
        }

        private void btnCadUF_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Estado"))
                return;
            ConsultaUF consUF = new ConsultaUF();
            consUF.MdiParent = this;
            consUF.Show();
        }

        private void btnCadCidade_Click(object sender, EventArgs e)
        {
            if (childrenAberto("Consultar Cidade"))
                return;
            ConsultaCidade consCidade = new ConsultaCidade();
            consCidade.MdiParent = this;
            consCidade.Show();
        }
    }
}