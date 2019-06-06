namespace JTDFROTAS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bar = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.geralSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.origemDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadCidade = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadUF = new System.Windows.Forms.ToolStripMenuItem();
            this.geralVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadVeiculo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadFisica = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadJuridica = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.manutençãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rptViagemCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarHours = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerUpdateDate = new System.Windows.Forms.Timer(this.components);
            this.Bar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2,
            this.toolStripSeparator3,
            this.toolStripDropDownButton3,
            this.toolStripSeparator4,
            this.toolStripDropDownButton4});
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.Bar.Name = "Bar";
            this.Bar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Bar.Size = new System.Drawing.Size(554, 25);
            this.Bar.TabIndex = 1;
            this.Bar.Text = "toolStrip1";
            this.Bar.Visible = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralSistemaToolStripMenuItem,
            this.geralVeículosToolStripMenuItem,
            this.toolStripSeparator2,
            this.estoqueToolStripMenuItem,
            this.pessoaToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripDropDownButton1.Text = "Cadastro";
            // 
            // geralSistemaToolStripMenuItem
            // 
            this.geralSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.origemDestinoToolStripMenuItem});
            this.geralSistemaToolStripMenuItem.Name = "geralSistemaToolStripMenuItem";
            this.geralSistemaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.geralSistemaToolStripMenuItem.Text = "Geral-Sistema";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // origemDestinoToolStripMenuItem
            // 
            this.origemDestinoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadCidade,
            this.btnCadUF});
            this.origemDestinoToolStripMenuItem.Name = "origemDestinoToolStripMenuItem";
            this.origemDestinoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.origemDestinoToolStripMenuItem.Text = "Origem/Destino";
            // 
            // btnCadCidade
            // 
            this.btnCadCidade.Name = "btnCadCidade";
            this.btnCadCidade.Size = new System.Drawing.Size(118, 22);
            this.btnCadCidade.Text = "Cidade";
            this.btnCadCidade.Click += new System.EventHandler(this.btnCadCidade_Click);
            // 
            // btnCadUF
            // 
            this.btnCadUF.Name = "btnCadUF";
            this.btnCadUF.Size = new System.Drawing.Size(118, 22);
            this.btnCadUF.Text = "UF";
            this.btnCadUF.Click += new System.EventHandler(this.btnCadUF_Click);
            // 
            // geralVeículosToolStripMenuItem
            // 
            this.geralVeículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadMarca,
            this.btnCadModelo,
            this.btnCadVeiculo2});
            this.geralVeículosToolStripMenuItem.Name = "geralVeículosToolStripMenuItem";
            this.geralVeículosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.geralVeículosToolStripMenuItem.Text = "Geral-Veículos";
            // 
            // btnCadMarca
            // 
            this.btnCadMarca.Name = "btnCadMarca";
            this.btnCadMarca.Size = new System.Drawing.Size(120, 22);
            this.btnCadMarca.Text = "Marca";
            this.btnCadMarca.Click += new System.EventHandler(this.btnCadMarca_Click);
            // 
            // btnCadModelo
            // 
            this.btnCadModelo.Name = "btnCadModelo";
            this.btnCadModelo.Size = new System.Drawing.Size(120, 22);
            this.btnCadModelo.Text = "Modelo";
            this.btnCadModelo.Click += new System.EventHandler(this.btnCadModelo_Click);
            // 
            // btnCadVeiculo2
            // 
            this.btnCadVeiculo2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadVeiculo});
            this.btnCadVeiculo2.Name = "btnCadVeiculo2";
            this.btnCadVeiculo2.Size = new System.Drawing.Size(120, 22);
            this.btnCadVeiculo2.Text = "Veículo";
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(120, 22);
            this.btnCadVeiculo.Text = "Veiculo";
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peçasToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            this.peçasToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.peçasToolStripMenuItem.Text = "Peças";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadFisica,
            this.btnCadJuridica,
            this.motoristaToolStripMenuItem,
            this.btnListPessoa});
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // btnCadFisica
            // 
            this.btnCadFisica.Name = "btnCadFisica";
            this.btnCadFisica.Size = new System.Drawing.Size(135, 22);
            this.btnCadFisica.Text = "Fisica";
            this.btnCadFisica.Click += new System.EventHandler(this.btnCadFisica_Click);
            // 
            // btnCadJuridica
            // 
            this.btnCadJuridica.Name = "btnCadJuridica";
            this.btnCadJuridica.Size = new System.Drawing.Size(135, 22);
            this.btnCadJuridica.Text = "Juridica";
            this.btnCadJuridica.Click += new System.EventHandler(this.btnCadJuridica_Click);
            // 
            // motoristaToolStripMenuItem
            // 
            this.motoristaToolStripMenuItem.Name = "motoristaToolStripMenuItem";
            this.motoristaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.motoristaToolStripMenuItem.Text = "Motorista";
            // 
            // btnListPessoa
            // 
            this.btnListPessoa.Name = "btnListPessoa";
            this.btnListPessoa.Size = new System.Drawing.Size(135, 22);
            this.btnListPessoa.Text = "Pessoa";
            this.btnListPessoa.Click += new System.EventHandler(this.btnListPessoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem,
            this.viagenToolStripMenuItem});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(91, 22);
            this.toolStripDropDownButton2.Text = "Movimento";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // viagenToolStripMenuItem
            // 
            this.viagenToolStripMenuItem.Name = "viagenToolStripMenuItem";
            this.viagenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viagenToolStripMenuItem.Text = "Viagem";
            this.viagenToolStripMenuItem.Click += new System.EventHandler(this.viagenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.toolStripDropDownButton3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(83, 22);
            this.toolStripDropDownButton3.Text = "Relatórios";
            this.toolStripDropDownButton3.ToolTipText = "Relatórios";
            // 
            // manutençãoToolStripMenuItem1
            // 
            this.manutençãoToolStripMenuItem1.Name = "manutençãoToolStripMenuItem1";
            this.manutençãoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.manutençãoToolStripMenuItem1.Text = "Manutenção";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rptViagemCurso});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Viagem";
            // 
            // rptViagemCurso
            // 
            this.rptViagemCurso.Name = "rptViagemCurso";
            this.rptViagemCurso.Size = new System.Drawing.Size(152, 22);
            this.rptViagemCurso.Text = "Em Curso";
            this.rptViagemCurso.Click += new System.EventHandler(this.rptViagemCurso_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair});
            this.toolStripDropDownButton4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripDropDownButton4.ShowDropDownArrow = false;
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(84, 22);
            this.toolStripDropDownButton4.Text = "Utilidades";
            this.toolStripDropDownButton4.ToolTipText = "Relatórios";
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.btnSair.Size = new System.Drawing.Size(217, 22);
            this.btnSair.Text = "Sair do Sistema";
            this.btnSair.Click += new System.EventHandler(this.txtSair_Click);
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarDate,
            this.statusBarHours,
            this.statusBarUser});
            this.statusBar.Location = new System.Drawing.Point(0, 310);
            this.statusBar.Name = "statusBar";
            this.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusBar.Size = new System.Drawing.Size(554, 27);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarDate
            // 
            this.statusBarDate.Margin = new System.Windows.Forms.Padding(100, 3, 20, 2);
            this.statusBarDate.Name = "statusBarDate";
            this.statusBarDate.Size = new System.Drawing.Size(51, 22);
            this.statusBarDate.Text = "DATA";
            // 
            // statusBarHours
            // 
            this.statusBarHours.Margin = new System.Windows.Forms.Padding(10, 3, 180, 2);
            this.statusBarHours.Name = "statusBarHours";
            this.statusBarHours.Size = new System.Drawing.Size(66, 22);
            this.statusBarHours.Text = "HORAS";
            // 
            // statusBarUser
            // 
            this.statusBarUser.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.statusBarUser.Name = "statusBarUser";
            this.statusBarUser.Size = new System.Drawing.Size(52, 22);
            this.statusBarUser.Text = "USER";
            // 
            // TimerUpdateDate
            // 
            this.TimerUpdateDate.Enabled = true;
            this.TimerUpdateDate.Tick += new System.EventHandler(this.TimerUpdateDate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 337);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.Bar);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JTDFrotas - Sistema de Gestão e Controle de Veículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Bar.ResumeLayout(false);
            this.Bar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Bar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem geralSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCadFisica;
        private System.Windows.Forms.ToolStripMenuItem btnCadJuridica;
        private System.Windows.Forms.ToolStripMenuItem motoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem origemDestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCadCidade;
        private System.Windows.Forms.ToolStripMenuItem btnCadUF;
        private System.Windows.Forms.ToolStripMenuItem geralVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCadMarca;
        private System.Windows.Forms.ToolStripMenuItem btnCadModelo;
        private System.Windows.Forms.ToolStripMenuItem btnCadVeiculo2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rptViagemCurso;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarDate;
        private System.Windows.Forms.Timer TimerUpdateDate;
        private System.Windows.Forms.ToolStripStatusLabel statusBarUser;
        private System.Windows.Forms.ToolStripStatusLabel statusBarHours;
        private System.Windows.Forms.ToolStripMenuItem viagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCadVeiculo;
        private System.Windows.Forms.ToolStripMenuItem btnListPessoa;
    }
}

