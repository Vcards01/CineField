namespace ProjetoCinema
{
    partial class FormGerSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerSessao));
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMeio = new System.Windows.Forms.Panel();
            this.txtPreço = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.lbCod = new System.Windows.Forms.Label();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSala = new System.Windows.Forms.Label();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.lbLugares = new System.Windows.Forms.Label();
            this.txtLugares = new System.Windows.Forms.TextBox();
            this.pnBaixo.SuspendLayout();
            this.pnTopo.SuspendLayout();
            this.pnMeio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBaixo
            // 
            this.pnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnBaixo.Controls.Add(this.btnCancelar);
            this.pnBaixo.Controls.Add(this.btnSalvar);
            this.pnBaixo.Location = new System.Drawing.Point(-1, 150);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(505, 42);
            this.pnBaixo.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelar.Location = new System.Drawing.Point(292, 8);
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
            this.btnSalvar.Location = new System.Drawing.Point(139, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnTopo.Controls.Add(this.lbTitulo);
            this.pnTopo.Controls.Add(this.panel1);
            this.pnTopo.Location = new System.Drawing.Point(-1, 0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(505, 34);
            this.pnTopo.TabIndex = 21;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(196, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(126, 31);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Sessões";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoCinema.Properties.Resources.cinza1;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 124);
            this.panel1.TabIndex = 2;
            // 
            // pnMeio
            // 
            this.pnMeio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMeio.Controls.Add(this.txtLugares);
            this.pnMeio.Controls.Add(this.lbLugares);
            this.pnMeio.Controls.Add(this.txtPreço);
            this.pnMeio.Controls.Add(this.label3);
            this.pnMeio.Controls.Add(this.TxtCod);
            this.pnMeio.Controls.Add(this.lbCod);
            this.pnMeio.Controls.Add(this.cbFilme);
            this.pnMeio.Controls.Add(this.label2);
            this.pnMeio.Controls.Add(this.lbSala);
            this.pnMeio.Controls.Add(this.dtpHorario);
            this.pnMeio.Controls.Add(this.label1);
            this.pnMeio.Controls.Add(this.cbSala);
            this.pnMeio.Location = new System.Drawing.Point(-1, 34);
            this.pnMeio.Name = "pnMeio";
            this.pnMeio.Size = new System.Drawing.Size(505, 115);
            this.pnMeio.TabIndex = 30;
            // 
            // txtPreço
            // 
            this.txtPreço.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPreço.Location = new System.Drawing.Point(134, 79);
            this.txtPreço.Mask = "$00.00";
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(62, 20);
            this.txtPreço.TabIndex = 34;
            this.txtPreço.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Preço Entrada";
            // 
            // TxtCod
            // 
            this.TxtCod.Enabled = false;
            this.TxtCod.Location = new System.Drawing.Point(321, 52);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(46, 20);
            this.TxtCod.TabIndex = 31;
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(275, 55);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(40, 13);
            this.lbCod.TabIndex = 30;
            this.lbCod.Text = "Codigo";
            // 
            // cbFilme
            // 
            this.cbFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Location = new System.Drawing.Point(95, 25);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(161, 21);
            this.cbFilme.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Horario";
            // 
            // lbSala
            // 
            this.lbSala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbSala.AutoSize = true;
            this.lbSala.Location = new System.Drawing.Point(275, 28);
            this.lbSala.Name = "lbSala";
            this.lbSala.Size = new System.Drawing.Size(28, 13);
            this.lbSala.TabIndex = 24;
            this.lbSala.Text = "Sala";
            // 
            // dtpHorario
            // 
            this.dtpHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpHorario.Checked = false;
            this.dtpHorario.CustomFormat = "HH: mm";
            this.dtpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorario.Location = new System.Drawing.Point(105, 53);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.ShowUpDown = true;
            this.dtpHorario.Size = new System.Drawing.Size(58, 20);
            this.dtpHorario.TabIndex = 28;
            this.dtpHorario.Value = new System.DateTime(2018, 10, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Filme";
            // 
            // cbSala
            // 
            this.cbSala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(309, 25);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(164, 21);
            this.cbSala.TabIndex = 27;
            // 
            // lbLugares
            // 
            this.lbLugares.AutoSize = true;
            this.lbLugares.Location = new System.Drawing.Point(278, 83);
            this.lbLugares.Name = "lbLugares";
            this.lbLugares.Size = new System.Drawing.Size(45, 13);
            this.lbLugares.TabIndex = 35;
            this.lbLugares.Text = "Lugares";
            // 
            // txtLugares
            // 
            this.txtLugares.Location = new System.Drawing.Point(321, 83);
            this.txtLugares.Name = "txtLugares";
            this.txtLugares.ReadOnly = true;
            this.txtLugares.Size = new System.Drawing.Size(46, 20);
            this.txtLugares.TabIndex = 36;
            this.txtLugares.Visible = false;
            // 
            // FormGerSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 193);
            this.Controls.Add(this.pnMeio);
            this.Controls.Add(this.pnBaixo);
            this.Controls.Add(this.pnTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerSessao";
            this.Text = "Gerenciar Sessões";
            this.Load += new System.EventHandler(this.FormGerSessao_Load);
            this.pnBaixo.ResumeLayout(false);
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.pnMeio.ResumeLayout(false);
            this.pnMeio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMeio;
        private System.Windows.Forms.ComboBox cbFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSala;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPreço;
        private System.Windows.Forms.TextBox txtLugares;
        private System.Windows.Forms.Label lbLugares;
    }
}