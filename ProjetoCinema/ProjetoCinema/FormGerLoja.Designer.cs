namespace ProjetoCinema
{
    partial class FormGerLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerLoja));
            this.lbDuração = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.lbAlimentação = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtPreço = new System.Windows.Forms.MaskedTextBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.pnBaixo.SuspendLayout();
            this.pnTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDuração
            // 
            this.lbDuração.AutoSize = true;
            this.lbDuração.Location = new System.Drawing.Point(207, 93);
            this.lbDuração.Name = "lbDuração";
            this.lbDuração.Size = new System.Drawing.Size(35, 13);
            this.lbDuração.TabIndex = 16;
            this.lbDuração.Text = "Preço";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(31, 93);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(28, 13);
            this.lbGenero.TabIndex = 15;
            this.lbGenero.Text = "Tipo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 20);
            this.txtNome.TabIndex = 13;
            // 
            // pnBaixo
            // 
            this.pnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBaixo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnBaixo.Controls.Add(this.btnCancelar);
            this.pnBaixo.Controls.Add(this.btnSalvar);
            this.pnBaixo.Location = new System.Drawing.Point(0, 130);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(456, 42);
            this.pnBaixo.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelar.Location = new System.Drawing.Point(280, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalvar.Location = new System.Drawing.Point(85, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnTopo
            // 
            this.pnTopo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnTopo.Controls.Add(this.lbAlimentação);
            this.pnTopo.Controls.Add(this.panel1);
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(456, 42);
            this.pnTopo.TabIndex = 11;
            // 
            // lbAlimentação
            // 
            this.lbAlimentação.AutoSize = true;
            this.lbAlimentação.BackColor = System.Drawing.Color.Transparent;
            this.lbAlimentação.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlimentação.ForeColor = System.Drawing.Color.White;
            this.lbAlimentação.Location = new System.Drawing.Point(131, 5);
            this.lbAlimentação.Name = "lbAlimentação";
            this.lbAlimentação.Size = new System.Drawing.Size(174, 31);
            this.lbAlimentação.TabIndex = 3;
            this.lbAlimentação.Text = "Alimentação";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoCinema.Properties.Resources.cinza1;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 124);
            this.panel1.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(31, 62);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "Nome";
            // 
            // txtPreço
            // 
            this.txtPreço.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPreço.Location = new System.Drawing.Point(248, 90);
            this.txtPreço.Mask = "$00.00";
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(124, 20);
            this.txtPreço.TabIndex = 19;
            this.txtPreço.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.txtTipo.Location = new System.Drawing.Point(72, 90);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(121, 21);
            this.txtTipo.TabIndex = 20;
            // 
            // FormGerLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 170);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtPreço);
            this.Controls.Add(this.lbDuração);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pnBaixo);
            this.Controls.Add(this.pnTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerLoja";
            this.Text = "Gerenciar Loja";
            this.pnBaixo.ResumeLayout(false);
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDuração;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Label lbAlimentação;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.MaskedTextBox txtPreço;
        private System.Windows.Forms.ComboBox txtTipo;
    }
}