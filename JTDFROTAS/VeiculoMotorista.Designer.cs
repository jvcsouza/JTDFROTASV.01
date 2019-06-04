namespace JTDFROTAS
{
    partial class VeiculoMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiculoMotorista));
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscaMoto = new System.Windows.Forms.Button();
            this.txtMotorista = new System.Windows.Forms.Label();
            this.txtCodMotorista = new System.Windows.Forms.TextBox();
            this.btnBuscaVeiculo = new System.Windows.Forms.Button();
            this.txtVeiculo = new System.Windows.Forms.Label();
            this.txtCodVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionar.Location = new System.Drawing.Point(159, 142);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(93, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscaVeiculo);
            this.groupBox1.Controls.Add(this.txtVeiculo);
            this.groupBox1.Controls.Add(this.txtCodVeiculo);
            this.groupBox1.Controls.Add(this.btnBuscaMoto);
            this.groupBox1.Controls.Add(this.txtMotorista);
            this.groupBox1.Controls.Add(this.txtCodMotorista);
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar Vinculo:";
            // 
            // btnBuscaMoto
            // 
            this.btnBuscaMoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscaMoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaMoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaMoto.Image = global::JTDFROTAS.Properties.Resources.iconSearch;
            this.btnBuscaMoto.Location = new System.Drawing.Point(54, 51);
            this.btnBuscaMoto.Name = "btnBuscaMoto";
            this.btnBuscaMoto.Size = new System.Drawing.Size(29, 24);
            this.btnBuscaMoto.TabIndex = 28;
            this.btnBuscaMoto.UseVisualStyleBackColor = false;
            this.btnBuscaMoto.Click += new System.EventHandler(this.btnBuscaMoto_Click);
            // 
            // txtMotorista
            // 
            this.txtMotorista.BackColor = System.Drawing.Color.White;
            this.txtMotorista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotorista.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotorista.Location = new System.Drawing.Point(89, 49);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.Padding = new System.Windows.Forms.Padding(3);
            this.txtMotorista.Size = new System.Drawing.Size(163, 26);
            this.txtMotorista.TabIndex = 26;
            this.txtMotorista.TextChanged += new System.EventHandler(this.liberaVinculo);
            // 
            // txtCodMotorista
            // 
            this.txtCodMotorista.Location = new System.Drawing.Point(14, 51);
            this.txtCodMotorista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodMotorista.Name = "txtCodMotorista";
            this.txtCodMotorista.Size = new System.Drawing.Size(48, 24);
            this.txtCodMotorista.TabIndex = 27;
            this.txtCodMotorista.TextChanged += new System.EventHandler(this.txtCodMotorista_TextChanged);
            // 
            // btnBuscaVeiculo
            // 
            this.btnBuscaVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscaVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaVeiculo.Image = global::JTDFROTAS.Properties.Resources.iconSearch;
            this.btnBuscaVeiculo.Location = new System.Drawing.Point(54, 102);
            this.btnBuscaVeiculo.Name = "btnBuscaVeiculo";
            this.btnBuscaVeiculo.Size = new System.Drawing.Size(29, 24);
            this.btnBuscaVeiculo.TabIndex = 31;
            this.btnBuscaVeiculo.UseVisualStyleBackColor = false;
            this.btnBuscaVeiculo.Click += new System.EventHandler(this.btnBuscaVeiculo_Click);
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.BackColor = System.Drawing.Color.White;
            this.txtVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVeiculo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVeiculo.Location = new System.Drawing.Point(89, 100);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Padding = new System.Windows.Forms.Padding(3);
            this.txtVeiculo.Size = new System.Drawing.Size(163, 26);
            this.txtVeiculo.TabIndex = 29;
            this.txtVeiculo.TextChanged += new System.EventHandler(this.liberaVinculo);
            // 
            // txtCodVeiculo
            // 
            this.txtCodVeiculo.Location = new System.Drawing.Point(14, 102);
            this.txtCodVeiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodVeiculo.Name = "txtCodVeiculo";
            this.txtCodVeiculo.Size = new System.Drawing.Size(48, 24);
            this.txtCodVeiculo.TabIndex = 30;
            this.txtCodVeiculo.TextChanged += new System.EventHandler(this.txtCodVeiculo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Veiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Motorista:";
            // 
            // VeiculoMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 198);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VeiculoMotorista";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vinculo Auxiliar";
            this.Load += new System.EventHandler(this.VeiculoMotorista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscaMoto;
        private System.Windows.Forms.Label txtMotorista;
        private System.Windows.Forms.TextBox txtCodMotorista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscaVeiculo;
        private System.Windows.Forms.Label txtVeiculo;
        private System.Windows.Forms.TextBox txtCodVeiculo;
    }
}