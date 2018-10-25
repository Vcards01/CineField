namespace ProjetoCinema.InterfacesGraficas
{
    partial class FormTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnTopo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIngressos = new System.Windows.Forms.Button();
            this.btnFilmes = new System.Windows.Forms.Button();
            this.pnCentro = new System.Windows.Forms.Panel();
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.lbApresentação = new System.Windows.Forms.Label();
            this.LBdata = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.pnTopo.SuspendLayout();
            this.pnBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnTopo.Controls.Add(this.button2);
            this.pnTopo.Controls.Add(this.button1);
            this.pnTopo.Controls.Add(this.panel2);
            this.pnTopo.Controls.Add(this.btnIngressos);
            this.pnTopo.Controls.Add(this.btnFilmes);
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(761, 66);
            this.pnTopo.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ProjetoCinema.Properties.Resources.ADMIcon;
            this.button2.Location = new System.Drawing.Point(595, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProjetoCinema.Properties.Resources.pipocaIcon;
            this.button1.Location = new System.Drawing.Point(489, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ProjetoCinema.Properties.Resources.Loguinho;
            this.panel2.Location = new System.Drawing.Point(327, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 53);
            this.panel2.TabIndex = 2;
            // 
            // btnIngressos
            // 
            this.btnIngressos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnIngressos.BackColor = System.Drawing.Color.Transparent;
            this.btnIngressos.FlatAppearance.BorderSize = 0;
            this.btnIngressos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngressos.Image = global::ProjetoCinema.Properties.Resources.IngressoIcon;
            this.btnIngressos.Location = new System.Drawing.Point(221, 7);
            this.btnIngressos.Name = "btnIngressos";
            this.btnIngressos.Size = new System.Drawing.Size(50, 50);
            this.btnIngressos.TabIndex = 1;
            this.btnIngressos.UseVisualStyleBackColor = false;
            // 
            // btnFilmes
            // 
            this.btnFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFilmes.BackColor = System.Drawing.Color.Transparent;
            this.btnFilmes.FlatAppearance.BorderSize = 0;
            this.btnFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmes.Image = global::ProjetoCinema.Properties.Resources.FilmIcon;
            this.btnFilmes.Location = new System.Drawing.Point(115, 7);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(50, 50);
            this.btnFilmes.TabIndex = 0;
            this.btnFilmes.UseVisualStyleBackColor = false;
            // 
            // pnCentro
            // 
            this.pnCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCentro.BackgroundImage")));
            this.pnCentro.Location = new System.Drawing.Point(0, 63);
            this.pnCentro.Name = "pnCentro";
            this.pnCentro.Size = new System.Drawing.Size(761, 266);
            this.pnCentro.TabIndex = 2;
            // 
            // pnBaixo
            // 
            this.pnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBaixo.Controls.Add(this.lbHora);
            this.pnBaixo.Controls.Add(this.LBdata);
            this.pnBaixo.Controls.Add(this.lbApresentação);
            this.pnBaixo.Location = new System.Drawing.Point(0, 330);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(761, 32);
            this.pnBaixo.TabIndex = 4;
            // 
            // lbApresentação
            // 
            this.lbApresentação.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbApresentação.AutoSize = true;
            this.lbApresentação.BackColor = System.Drawing.Color.Transparent;
            this.lbApresentação.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbApresentação.Location = new System.Drawing.Point(12, 10);
            this.lbApresentação.Name = "lbApresentação";
            this.lbApresentação.Size = new System.Drawing.Size(130, 13);
            this.lbApresentação.TabIndex = 0;
            this.lbApresentação.Text = "Bem vindo ao CINEFIELD";
            // 
            // LBdata
            // 
            this.LBdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBdata.AutoSize = true;
            this.LBdata.BackColor = System.Drawing.Color.Transparent;
            this.LBdata.ForeColor = System.Drawing.Color.Aquamarine;
            this.LBdata.Location = new System.Drawing.Point(653, 10);
            this.LBdata.Name = "LBdata";
            this.LBdata.Size = new System.Drawing.Size(28, 13);
            this.LBdata.TabIndex = 1;
            this.LBdata.Text = "data";
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbHora.Location = new System.Drawing.Point(702, 10);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(28, 13);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "hora";
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 362);
            this.Controls.Add(this.pnBaixo);
            this.Controls.Add(this.pnTopo);
            this.Controls.Add(this.pnCentro);
            this.Name = "FormTelaPrincipal";
            this.Text = "FormTelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTopo.ResumeLayout(false);
            this.pnBaixo.ResumeLayout(false);
            this.pnBaixo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnCentro;
        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button btnIngressos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label LBdata;
        private System.Windows.Forms.Label lbApresentação;
    }
}