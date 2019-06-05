namespace JTDFROTAS.Movimento
{
    partial class FormViagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViagem));
            this.txtOrigem = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbInfos = new System.Windows.Forms.GroupBox();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtCusto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaCidadeDestino = new System.Windows.Forms.Button();
            this.txtCodDestino = new System.Windows.Forms.TextBox();
            this.btnBuscaCidadeOrigem = new System.Windows.Forms.Button();
            this.txtCodOrigem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.gpbVeiculo = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lsView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gpbInfos.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpbVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrigem
            // 
            this.txtOrigem.BackColor = System.Drawing.Color.White;
            this.txtOrigem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigem.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.Location = new System.Drawing.Point(183, 29);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Padding = new System.Windows.Forms.Padding(3);
            this.txtOrigem.Size = new System.Drawing.Size(272, 26);
            this.txtOrigem.TabIndex = 60;
            this.txtOrigem.TextChanged += new System.EventHandler(this.liberaCalcula);
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.White;
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestino.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(183, 65);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Padding = new System.Windows.Forms.Padding(3);
            this.txtDestino.Size = new System.Drawing.Size(272, 25);
            this.txtDestino.TabIndex = 5;
            this.txtDestino.TextChanged += new System.EventHandler(this.liberaCalcula);
            // 
            // txtDuracao
            // 
            this.txtDuracao.BackColor = System.Drawing.Color.White;
            this.txtDuracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuracao.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracao.Location = new System.Drawing.Point(95, 62);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Padding = new System.Windows.Forms.Padding(3);
            this.txtDuracao.Size = new System.Drawing.Size(166, 26);
            this.txtDuracao.TabIndex = 6;
            // 
            // txtDistancia
            // 
            this.txtDistancia.BackColor = System.Drawing.Color.White;
            this.txtDistancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistancia.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(95, 30);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Padding = new System.Windows.Forms.Padding(3);
            this.txtDistancia.Size = new System.Drawing.Size(166, 26);
            this.txtDistancia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Origem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Destino:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Distancia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Duração:";
            // 
            // gpbInfos
            // 
            this.gpbInfos.Controls.Add(this.label7);
            this.gpbInfos.Controls.Add(this.label8);
            this.gpbInfos.Controls.Add(this.txtDistancia);
            this.gpbInfos.Controls.Add(this.txtDuracao);
            this.gpbInfos.Location = new System.Drawing.Point(183, 107);
            this.gpbInfos.Name = "gpbInfos";
            this.gpbInfos.Size = new System.Drawing.Size(272, 97);
            this.gpbInfos.TabIndex = 13;
            this.gpbInfos.TabStop = false;
            this.gpbInfos.Text = "Informações Adicionais:";
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtCusto);
            this.gpbDados.Controls.Add(this.label10);
            this.gpbDados.Controls.Add(this.label9);
            this.gpbDados.Controls.Add(this.dtEntrega);
            this.gpbDados.Controls.Add(this.btnBuscaCidadeDestino);
            this.gpbDados.Controls.Add(this.txtCodDestino);
            this.gpbDados.Controls.Add(this.btnBuscaCidadeOrigem);
            this.gpbDados.Controls.Add(this.txtOrigem);
            this.gpbDados.Controls.Add(this.txtCodOrigem);
            this.gpbDados.Controls.Add(this.gpbInfos);
            this.gpbDados.Controls.Add(this.label5);
            this.gpbDados.Controls.Add(this.txtDestino);
            this.gpbDados.Controls.Add(this.label6);
            this.gpbDados.Enabled = false;
            this.gpbDados.Location = new System.Drawing.Point(12, 198);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(483, 215);
            this.gpbDados.TabIndex = 14;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados de Viagem:";
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.Color.White;
            this.txtCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusto.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.Location = new System.Drawing.Point(9, 179);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Padding = new System.Windows.Forms.Padding(3);
            this.txtCusto.Size = new System.Drawing.Size(153, 25);
            this.txtCusto.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Custo Aproximado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Previsão de Entrega:";
            // 
            // dtEntrega
            // 
            this.dtEntrega.CustomFormat = "";
            this.dtEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEntrega.Location = new System.Drawing.Point(9, 128);
            this.dtEntrega.Name = "dtEntrega";
            this.dtEntrega.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtEntrega.Size = new System.Drawing.Size(153, 24);
            this.dtEntrega.TabIndex = 8;
            this.dtEntrega.Value = new System.DateTime(2019, 6, 4, 2, 38, 41, 0);
            // 
            // btnBuscaCidadeDestino
            // 
            this.btnBuscaCidadeDestino.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscaCidadeDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCidadeDestino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaCidadeDestino.Image = global::JTDFROTAS.Properties.Resources.iconSearch;
            this.btnBuscaCidadeDestino.Location = new System.Drawing.Point(148, 66);
            this.btnBuscaCidadeDestino.Name = "btnBuscaCidadeDestino";
            this.btnBuscaCidadeDestino.Size = new System.Drawing.Size(29, 24);
            this.btnBuscaCidadeDestino.TabIndex = 7;
            this.btnBuscaCidadeDestino.UseVisualStyleBackColor = false;
            this.btnBuscaCidadeDestino.Click += new System.EventHandler(this.btnBuscaCidadeDestino_Click);
            // 
            // txtCodDestino
            // 
            this.txtCodDestino.Location = new System.Drawing.Point(94, 66);
            this.txtCodDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodDestino.Name = "txtCodDestino";
            this.txtCodDestino.Size = new System.Drawing.Size(68, 24);
            this.txtCodDestino.TabIndex = 6;
            this.txtCodDestino.TextChanged += new System.EventHandler(this.txtCodDestino_TextChanged);
            // 
            // btnBuscaCidadeOrigem
            // 
            this.btnBuscaCidadeOrigem.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscaCidadeOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCidadeOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaCidadeOrigem.Image = global::JTDFROTAS.Properties.Resources.iconSearch;
            this.btnBuscaCidadeOrigem.Location = new System.Drawing.Point(148, 29);
            this.btnBuscaCidadeOrigem.Name = "btnBuscaCidadeOrigem";
            this.btnBuscaCidadeOrigem.Size = new System.Drawing.Size(29, 24);
            this.btnBuscaCidadeOrigem.TabIndex = 5;
            this.btnBuscaCidadeOrigem.UseVisualStyleBackColor = false;
            this.btnBuscaCidadeOrigem.Click += new System.EventHandler(this.btnBuscaCidadeOrigem_Click);
            // 
            // txtCodOrigem
            // 
            this.txtCodOrigem.Location = new System.Drawing.Point(94, 29);
            this.txtCodOrigem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodOrigem.Name = "txtCodOrigem";
            this.txtCodOrigem.Size = new System.Drawing.Size(68, 24);
            this.txtCodOrigem.TabIndex = 4;
            this.txtCodOrigem.TextChanged += new System.EventHandler(this.txtCodOrigem_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCliente);
            this.groupBox3.Controls.Add(this.btnBuscaCliente);
            this.groupBox3.Controls.Add(this.txtCodCliente);
            this.groupBox3.Location = new System.Drawing.Point(12, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 104);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(13, 61);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(3);
            this.txtCliente.Size = new System.Drawing.Size(164, 26);
            this.txtCliente.TabIndex = 28;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaCliente.Image = global::JTDFROTAS.Properties.Resources.iconSearch;
            this.btnBuscaCliente.Location = new System.Drawing.Point(67, 24);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(29, 24);
            this.btnBuscaCliente.TabIndex = 2;
            this.btnBuscaCliente.UseVisualStyleBackColor = false;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(13, 24);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(68, 24);
            this.txtCodCliente.TabIndex = 1;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            // 
            // gpbVeiculo
            // 
            this.gpbVeiculo.Controls.Add(this.btnExcluir);
            this.gpbVeiculo.Controls.Add(this.btnAdicionar);
            this.gpbVeiculo.Controls.Add(this.lsView);
            this.gpbVeiculo.Enabled = false;
            this.gpbVeiculo.Location = new System.Drawing.Point(216, 12);
            this.gpbVeiculo.Name = "gpbVeiculo";
            this.gpbVeiculo.Size = new System.Drawing.Size(279, 180);
            this.gpbVeiculo.TabIndex = 16;
            this.gpbVeiculo.TabStop = false;
            this.gpbVeiculo.Text = "Veiculos/Motorista:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Image = global::JTDFROTAS.Properties.Resources.iconAdc;
            this.btnExcluir.Location = new System.Drawing.Point(244, 63);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(29, 24);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Image = global::JTDFROTAS.Properties.Resources.iconSub;
            this.btnAdicionar.Location = new System.Drawing.Point(244, 33);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(29, 24);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lsView
            // 
            this.lsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsView.HideSelection = false;
            this.lsView.HoverSelection = true;
            this.lsView.Location = new System.Drawing.Point(15, 27);
            this.lsView.MultiSelect = false;
            this.lsView.Name = "lsView";
            this.lsView.Size = new System.Drawing.Size(225, 136);
            this.lsView.TabIndex = 0;
            this.lsView.UseCompatibleStateImageBehavior = false;
            this.lsView.View = System.Windows.Forms.View.Details;
            this.lsView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsView_DrawItem);
            this.lsView.ItemActivate += new System.EventHandler(this.lsView_ItemActivate);
            this.lsView.VisibleChanged += new System.EventHandler(this.lsView_VisibleChanged);
            this.lsView.Leave += new System.EventHandler(this.lsView_Leave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "VEICULO";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MOTORISTA";
            this.columnHeader2.Width = 112;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::JTDFROTAS.Properties.Resources.iconCancel;
            this.btnCancelar.Location = new System.Drawing.Point(99, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 57);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::JTDFROTAS.Properties.Resources.iconSave;
            this.btnGravar.Location = new System.Drawing.Point(18, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 57);
            this.btnGravar.TabIndex = 90;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FormViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 415);
            this.Controls.Add(this.gpbVeiculo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpbDados);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViagem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualiza Viagem";
            this.Load += new System.EventHandler(this.FormViagem_Load);
            this.gpbInfos.ResumeLayout(false);
            this.gpbInfos.PerformLayout();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpbVeiculo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtOrigem;
        private System.Windows.Forms.Label txtDestino;
        private System.Windows.Forms.Label txtDuracao;
        private System.Windows.Forms.Label txtDistancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpbInfos;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Button btnBuscaCidadeDestino;
        private System.Windows.Forms.TextBox txtCodDestino;
        private System.Windows.Forms.Button btnBuscaCidadeOrigem;
        private System.Windows.Forms.TextBox txtCodOrigem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label txtCusto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtEntrega;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.GroupBox gpbVeiculo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView lsView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}