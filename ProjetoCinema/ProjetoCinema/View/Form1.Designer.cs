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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnFundo = new System.Windows.Forms.Panel();
            this.tpTopo = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnFilme = new System.Windows.Forms.ToolStripButton();
            this.btnIngresso = new System.Windows.Forms.ToolStripButton();
            this.btnAlgo = new System.Windows.Forms.ToolStripButton();
            this.btnAdm = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbBemVindo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbHoras = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpTopo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnFundo);
            this.panel1.Controls.Add(this.tpTopo);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 441);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(0, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 28);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ProjetoCinema.Properties.Resources.Sem_Título_21;
            this.panel3.Location = new System.Drawing.Point(12, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 21);
            this.panel3.TabIndex = 2;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(39, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(62, 13);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "CINEFIELD";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(873, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnFundo
            // 
            this.pnFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.pnFundo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnFundo.BackgroundImage")));
            this.pnFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnFundo.Location = new System.Drawing.Point(0, 111);
            this.pnFundo.Name = "pnFundo";
            this.pnFundo.Size = new System.Drawing.Size(896, 300);
            this.pnFundo.TabIndex = 5;
            // 
            // tpTopo
            // 
            this.tpTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpTopo.AutoSize = false;
            this.tpTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tpTopo.Dock = System.Windows.Forms.DockStyle.None;
            this.tpTopo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tpTopo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.btnFilme,
            this.btnIngresso,
            this.btnAlgo,
            this.btnAdm});
            this.tpTopo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tpTopo.Location = new System.Drawing.Point(0, 48);
            this.tpTopo.Name = "tpTopo";
            this.tpTopo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tpTopo.Size = new System.Drawing.Size(900, 66);
            this.tpTopo.TabIndex = 4;
            this.tpTopo.Text = "toolStrip1";
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = false;
            this.btnHome.BackgroundImage = global::ProjetoCinema.Properties.Resources.home_filled_building;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Margin = new System.Windows.Forms.Padding(100, 10, 0, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.ToolTipText = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFilme
            // 
            this.btnFilme.AutoSize = false;
            this.btnFilme.BackgroundImage = global::ProjetoCinema.Properties.Resources.FilmIcon;
            this.btnFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.btnFilme.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnFilme.Margin = new System.Windows.Forms.Padding(100, 10, 0, 2);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(40, 40);
            this.btnFilme.ToolTipText = "Filme";
            this.btnFilme.Click += new System.EventHandler(this.btnFilme_Click);
            // 
            // btnIngresso
            // 
            this.btnIngresso.AutoSize = false;
            this.btnIngresso.BackgroundImage = global::ProjetoCinema.Properties.Resources.IngressoIcon;
            this.btnIngresso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.btnIngresso.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnIngresso.Margin = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.btnIngresso.Name = "btnIngresso";
            this.btnIngresso.Size = new System.Drawing.Size(40, 40);
            this.btnIngresso.Text = "toolStripButton2";
            this.btnIngresso.ToolTipText = "Ingressos";
            // 
            // btnAlgo
            // 
            this.btnAlgo.AutoSize = false;
            this.btnAlgo.BackgroundImage = global::ProjetoCinema.Properties.Resources.pipocaIcon;
            this.btnAlgo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.btnAlgo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnAlgo.Margin = new System.Windows.Forms.Padding(100, 10, 0, 2);
            this.btnAlgo.Name = "btnAlgo";
            this.btnAlgo.Size = new System.Drawing.Size(40, 40);
            this.btnAlgo.Text = "toolStripButton3";
            this.btnAlgo.ToolTipText = "AlgumaCoisa";
            // 
            // btnAdm
            // 
            this.btnAdm.AutoSize = false;
            this.btnAdm.BackgroundImage = global::ProjetoCinema.Properties.Resources.ADMIcon;
            this.btnAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.btnAdm.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnAdm.Margin = new System.Windows.Forms.Padding(100, 10, 0, 2);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(40, 40);
            this.btnAdm.Text = "toolStripButton1";
            this.btnAdm.ToolTipText = "Administração";
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbBemVindo,
            this.lbDate,
            this.lbHoras});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 30);
            this.statusStrip1.TabIndex = 3;
            // 
            // lbBemVindo
            // 
            this.lbBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lbBemVindo.ForeColor = System.Drawing.Color.White;
            this.lbBemVindo.Name = "lbBemVindo";
            this.lbBemVindo.Size = new System.Drawing.Size(154, 25);
            this.lbBemVindo.Text = "Bem Vindo ao CINEFIELD    |";
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Image = ((System.Drawing.Image)(resources.GetObject("lbDate.Image")));
            this.lbDate.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.lbDate.Name = "lbDate";
            this.lbDate.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.lbDate.Size = new System.Drawing.Size(53, 25);
            this.lbDate.Text = "Data |";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDate.ToolTipText = "Data";
            // 
            // lbHoras
            // 
            this.lbHoras.BackColor = System.Drawing.Color.Transparent;
            this.lbHoras.ForeColor = System.Drawing.Color.White;
            this.lbHoras.Image = ((System.Drawing.Image)(resources.GetObject("lbHoras.Image")));
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(49, 25);
            this.lbHoras.Text = "Hora";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.fecharToolStripMenuItem,
            this.retirarValorToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // retirarValorToolStripMenuItem
            // 
            this.retirarValorToolStripMenuItem.Name = "retirarValorToolStripMenuItem";
            this.retirarValorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.retirarValorToolStripMenuItem.Text = "Retirar valor";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(896, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 441);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                                                                ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpTopo.ResumeLayout(false);
            this.tpTopo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbBemVindo;
        private System.Windows.Forms.ToolStripStatusLabel lbDate;
        private System.Windows.Forms.ToolStripStatusLabel lbHoras;
        private System.Windows.Forms.ToolStrip tpTopo;
        private System.Windows.Forms.ToolStripButton btnFilme;
        private System.Windows.Forms.ToolStripButton btnIngresso;
        private System.Windows.Forms.ToolStripButton btnAlgo;
        private System.Windows.Forms.ToolStripButton btnAdm;
        private System.Windows.Forms.Panel pnFundo;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarValorToolStripMenuItem;
    }
}

