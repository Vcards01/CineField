namespace ProjetoCinema
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMeio = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFerramentas = new System.Windows.Forms.Button();
            this.btnAlimentação = new System.Windows.Forms.Button();
            this.btIngresso = new System.Windows.Forms.Button();
            this.btnFilme = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnBaixo.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pnBaixo);
            this.panel1.Controls.Add(this.pnMeio);
            this.panel1.Controls.Add(this.pnTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 441);
            this.panel1.TabIndex = 0;
            // 
            // pnBaixo
            // 
            this.pnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBaixo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnBaixo.Controls.Add(this.lbHora);
            this.pnBaixo.Controls.Add(this.lbdata);
            this.pnBaixo.Controls.Add(this.label1);
            this.pnBaixo.Location = new System.Drawing.Point(0, 403);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(896, 38);
            this.pnBaixo.TabIndex = 0;
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbHora.Location = new System.Drawing.Point(840, 16);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(30, 13);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "Hora";
            // 
            // lbdata
            // 
            this.lbdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdata.AutoSize = true;
            this.lbdata.BackColor = System.Drawing.Color.Transparent;
            this.lbdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbdata.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbdata.Location = new System.Drawing.Point(772, 16);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(30, 13);
            this.lbdata.TabIndex = 1;
            this.lbdata.Text = "Data";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo ao CINEFIELD";
            // 
            // pnMeio
            // 
            this.pnMeio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMeio.BackgroundImage = global::ProjetoCinema.Properties.Resources.logoo;
            this.pnMeio.Location = new System.Drawing.Point(0, 61);
            this.pnMeio.Name = "pnMeio";
            this.pnMeio.Size = new System.Drawing.Size(896, 347);
            this.pnMeio.TabIndex = 1;
            // 
            // pnTop
            // 
            this.pnTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTop.BackColor = System.Drawing.Color.Transparent;
            this.pnTop.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnTop.Controls.Add(this.panel3);
            this.pnTop.Controls.Add(this.btnFerramentas);
            this.pnTop.Controls.Add(this.btnAlimentação);
            this.pnTop.Controls.Add(this.btIngresso);
            this.pnTop.Controls.Add(this.btnFilme);
            this.pnTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(896, 61);
            this.pnTop.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackgroundImage = global::ProjetoCinema.Properties.Resources.Loguinho;
            this.panel3.Location = new System.Drawing.Point(386, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 57);
            this.panel3.TabIndex = 4;
            // 
            // btnFerramentas
            // 
            this.btnFerramentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFerramentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFerramentas.FlatAppearance.BorderSize = 0;
            this.btnFerramentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFerramentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFerramentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerramentas.Image = global::ProjetoCinema.Properties.Resources.ADMIcon;
            this.btnFerramentas.Location = new System.Drawing.Point(722, 5);
            this.btnFerramentas.Name = "btnFerramentas";
            this.btnFerramentas.Size = new System.Drawing.Size(50, 50);
            this.btnFerramentas.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnFerramentas, "Administração");
            this.btnFerramentas.UseVisualStyleBackColor = true;
            this.btnFerramentas.Click += new System.EventHandler(this.btnFerramentas_Click);
            this.btnFerramentas.MouseEnter += new System.EventHandler(this.btnFerramentas_MouseEnter);
            this.btnFerramentas.MouseLeave += new System.EventHandler(this.btnFerramentas_MouseLeave);
            // 
            // btnAlimentação
            // 
            this.btnAlimentação.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAlimentação.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlimentação.FlatAppearance.BorderSize = 0;
            this.btnAlimentação.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlimentação.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlimentação.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimentação.Image = global::ProjetoCinema.Properties.Resources.pipocaIcon;
            this.btnAlimentação.Location = new System.Drawing.Point(610, 5);
            this.btnAlimentação.Name = "btnAlimentação";
            this.btnAlimentação.Size = new System.Drawing.Size(50, 50);
            this.btnAlimentação.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAlimentação, "Alimentação");
            this.btnAlimentação.UseVisualStyleBackColor = true;
            this.btnAlimentação.MouseEnter += new System.EventHandler(this.btnAlimentação_MouseEnter);
            this.btnAlimentação.MouseLeave += new System.EventHandler(this.btnAlimentação_MouseLeave);
            // 
            // btIngresso
            // 
            this.btIngresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btIngresso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIngresso.FlatAppearance.BorderSize = 0;
            this.btIngresso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btIngresso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btIngresso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresso.Image = global::ProjetoCinema.Properties.Resources.IngressoIcon;
            this.btIngresso.Location = new System.Drawing.Point(236, 5);
            this.btIngresso.Name = "btIngresso";
            this.btIngresso.Size = new System.Drawing.Size(50, 50);
            this.btIngresso.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btIngresso, "Ingressos");
            this.btIngresso.UseVisualStyleBackColor = true;
            this.btIngresso.Click += new System.EventHandler(this.btIngresso_Click);
            this.btIngresso.MouseEnter += new System.EventHandler(this.btIngresso_MouseEnter);
            this.btIngresso.MouseLeave += new System.EventHandler(this.btIngresso_MouseLeave);
            // 
            // btnFilme
            // 
            this.btnFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilme.FlatAppearance.BorderSize = 0;
            this.btnFilme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFilme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilme.Image = global::ProjetoCinema.Properties.Resources.FilmIcon;
            this.btnFilme.Location = new System.Drawing.Point(124, 5);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(50, 50);
            this.btnFilme.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnFilme, "Filmes em Cartaz");
            this.btnFilme.UseVisualStyleBackColor = true;
            this.btnFilme.Click += new System.EventHandler(this.btnFilme_Click);
            this.btnFilme.MouseEnter += new System.EventHandler(this.btnFilme_MouseEnter);
            this.btnFilme.MouseLeave += new System.EventHandler(this.btnFilme_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 441);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnBaixo.ResumeLayout(false);
            this.pnBaixo.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFilme;
        private System.Windows.Forms.Button btnFerramentas;
        private System.Windows.Forms.Button btnAlimentação;
        private System.Windows.Forms.Button btIngresso;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnMeio;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

