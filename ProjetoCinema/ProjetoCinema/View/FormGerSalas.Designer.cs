namespace ProjetoCinema
{
    partial class FormGerSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerSalas));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.NmLugares = new System.Windows.Forms.NumericUpDown();
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnMeio = new System.Windows.Forms.Panel();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NmLugares)).BeginInit();
            this.pnBaixo.SuspendLayout();
            this.pnTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(117, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 20);
            this.txtCodigo.TabIndex = 19;
            // 
            // lbCodigo
            // 
            this.lbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(34, 45);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(77, 13);
            this.lbCodigo.TabIndex = 17;
            this.lbCodigo.Text = "Código da sala";
            // 
            // lbGenero
            // 
            this.lbGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(263, 83);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(96, 13);
            this.lbGenero.TabIndex = 15;
            this.lbGenero.Text = "Numero de lugares";
            // 
            // NmLugares
            // 
            this.NmLugares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NmLugares.Location = new System.Drawing.Point(365, 81);
            this.NmLugares.Name = "NmLugares";
            this.NmLugares.Size = new System.Drawing.Size(42, 20);
            this.NmLugares.TabIndex = 20;
            // 
            // pnBaixo
            // 
            this.pnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBaixo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnBaixo.Controls.Add(this.btnCancelar);
            this.pnBaixo.Controls.Add(this.btnSalvar);
            this.pnBaixo.Location = new System.Drawing.Point(0, 129);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(493, 42);
            this.pnBaixo.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelar.Location = new System.Drawing.Point(298, 10);
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
            this.btnSalvar.Location = new System.Drawing.Point(103, 10);
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
            this.pnTopo.Controls.Add(this.pnMeio);
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(493, 42);
            this.pnTopo.TabIndex = 11;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(202, 5);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(87, 31);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Salas";
            // 
            // pnMeio
            // 
            this.pnMeio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMeio.BackgroundImage = global::ProjetoCinema.Properties.Resources.cinza1;
            this.pnMeio.Location = new System.Drawing.Point(0, 39);
            this.pnMeio.Name = "pnMeio";
            this.pnMeio.Size = new System.Drawing.Size(490, 94);
            this.pnMeio.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(34, 86);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(72, 13);
            this.lbNome.TabIndex = 21;
            this.lbNome.Text = "Nome da sala";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(111, 20);
            this.txtNome.TabIndex = 22;
            // 
            // FormGerSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 169);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.NmLugares);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.pnBaixo);
            this.Controls.Add(this.pnTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerSalas";
            this.Text = "Gerenciar Salas";
            ((System.ComponentModel.ISupportInitialize)(this.NmLugares)).EndInit();
            this.pnBaixo.ResumeLayout(false);
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pnMeio;
        private System.Windows.Forms.NumericUpDown NmLugares;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}