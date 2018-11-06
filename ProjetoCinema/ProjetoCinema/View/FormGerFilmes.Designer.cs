namespace ProjetoCinema
{
    partial class FormGerFilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerFilmes));
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbDuração = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnBaixo.SuspendLayout();
            this.pnTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(72, 60);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(300, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(31, 63);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(33, 13);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Titulo";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(31, 94);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(42, 13);
            this.lbGenero.TabIndex = 4;
            this.lbGenero.Text = "Genero";
            // 
            // lbDuração
            // 
            this.lbDuração.AutoSize = true;
            this.lbDuração.Location = new System.Drawing.Point(207, 94);
            this.lbDuração.Name = "lbDuração";
            this.lbDuração.Size = new System.Drawing.Size(48, 13);
            this.lbDuração.TabIndex = 5;
            this.lbDuração.Text = "Duração";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(33, 123);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 6;
            this.lbCodigo.Text = "Código";
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Drama",
            "Suspense",
            "Comédia",
            "Comédia romântica",
            "Ficção científica",
            "Terror",
            "Desenhos de longa metragem",
            "Documentários"});
            this.cbGenero.Location = new System.Drawing.Point(72, 91);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(72, 120);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // dtpHorario
            // 
            this.dtpHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpHorario.Checked = false;
            this.dtpHorario.CustomFormat = "HH: mm: ss tt ";
            this.dtpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorario.Location = new System.Drawing.Point(265, 88);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.ShowUpDown = true;
            this.dtpHorario.Size = new System.Drawing.Size(107, 20);
            this.dtpHorario.TabIndex = 29;
            this.dtpHorario.Value = new System.DateTime(2018, 10, 28, 0, 0, 0, 0);
            // 
            // pnBaixo
            // 
            this.pnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBaixo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnBaixo.Controls.Add(this.btnCancelar);
            this.pnBaixo.Controls.Add(this.btnSalvar);
            this.pnBaixo.Location = new System.Drawing.Point(0, 160);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(456, 42);
            this.pnBaixo.TabIndex = 1;
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
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnTopo.Controls.Add(this.lbTitulo);
            this.pnTopo.Controls.Add(this.panel1);
            this.pnTopo.Location = new System.Drawing.Point(0, 1);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(456, 42);
            this.pnTopo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(174, 5);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(100, 31);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Filmes";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoCinema.Properties.Resources.cinza1;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 124);
            this.panel1.TabIndex = 2;
            // 
            // FormGerFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 202);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbDuração);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.pnBaixo);
            this.Controls.Add(this.pnTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerFilmes";
            this.Text = "Gerenciar Filmes";
            this.pnBaixo.ResumeLayout(false);
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbDuração;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpHorario;
    }
}