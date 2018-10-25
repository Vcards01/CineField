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
            this.pnMeio = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btIngresso = new System.Windows.Forms.Button();
            this.btnFilme = new System.Windows.Forms.Button();
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnBaixo.SuspendLayout();
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
            this.pnTop.Controls.Add(this.button3);
            this.pnTop.Controls.Add(this.button2);
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ProjetoCinema.Properties.Resources.ADMIcon;
            this.button3.Location = new System.Drawing.Point(722, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ProjetoCinema.Properties.Resources.pipocaIcon;
            this.button2.Location = new System.Drawing.Point(610, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btIngresso
            // 
            this.btIngresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btIngresso.FlatAppearance.BorderSize = 0;
            this.btIngresso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresso.Image = global::ProjetoCinema.Properties.Resources.IngressoIcon;
            this.btIngresso.Location = new System.Drawing.Point(236, 5);
            this.btIngresso.Name = "btIngresso";
            this.btIngresso.Size = new System.Drawing.Size(50, 50);
            this.btIngresso.TabIndex = 1;
            this.btIngresso.UseVisualStyleBackColor = true;
            // 
            // btnFilme
            // 
            this.btnFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFilme.FlatAppearance.BorderSize = 0;
            this.btnFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilme.Image = global::ProjetoCinema.Properties.Resources.FilmIcon;
            this.btnFilme.Location = new System.Drawing.Point(124, 5);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(50, 50);
            this.btnFilme.TabIndex = 0;
            this.btnFilme.UseVisualStyleBackColor = true;
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
            // lbdata
            // 
            this.lbdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdata.AutoSize = true;
            this.lbdata.BackColor = System.Drawing.Color.Transparent;
            this.lbdata.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbdata.Location = new System.Drawing.Point(772, 16);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(30, 13);
            this.lbdata.TabIndex = 1;
            this.lbdata.Text = "Data";
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
            this.pnTop.ResumeLayout(false);
            this.pnBaixo.ResumeLayout(false);
            this.pnBaixo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFilme;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btIngresso;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnMeio;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbdata;
    }
}

