namespace ProjetoCinema
{
    partial class Home
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
            System.Windows.Forms.GroupBox gpFilmes;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duraFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinopse = new System.Windows.Forms.DataGridViewButtonColumn();
            gpFilmes = new System.Windows.Forms.GroupBox();
            gpFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.pnTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFilmes
            // 
            gpFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gpFilmes.Controls.Add(this.dgvFilmes);
            gpFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gpFilmes.ForeColor = System.Drawing.Color.White;
            gpFilmes.Location = new System.Drawing.Point(303, 43);
            gpFilmes.MaximumSize = new System.Drawing.Size(517, 800);
            gpFilmes.Name = "gpFilmes";
            gpFilmes.Size = new System.Drawing.Size(517, 260);
            gpFilmes.TabIndex = 23;
            gpFilmes.TabStop = false;
            gpFilmes.Text = "Filmes";
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.AllowUserToAddRows = false;
            this.dgvFilmes.AllowUserToDeleteRows = false;
            this.dgvFilmes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.dgvFilmes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilmes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.tituloFilme,
            this.duraFilme,
            this.genFilme,
            this.Sinopse});
            this.dgvFilmes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilmes.EnableHeadersVisualStyles = false;
            this.dgvFilmes.GridColor = System.Drawing.Color.SlateBlue;
            this.dgvFilmes.Location = new System.Drawing.Point(3, 16);
            this.dgvFilmes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFilmes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFilmes.RowTemplate.Height = 24;
            this.dgvFilmes.Size = new System.Drawing.Size(511, 241);
            this.dgvFilmes.TabIndex = 13;
            this.dgvFilmes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilmes_CellContentClick);
            // 
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.Controls.Add(this.lbTitulo);
            this.pnTopo.Location = new System.Drawing.Point(303, 3);
            this.pnTopo.MaximumSize = new System.Drawing.Size(517, 51);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(517, 51);
            this.pnTopo.TabIndex = 21;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(178, 7);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(151, 31);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Em Cartaz";
            // 
            // CID
            // 
            this.CID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Width = 30;
            // 
            // tituloFilme
            // 
            this.tituloFilme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloFilme.HeaderText = "Titulo";
            this.tituloFilme.Name = "tituloFilme";
            this.tituloFilme.ReadOnly = true;
            // 
            // duraFilme
            // 
            this.duraFilme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duraFilme.HeaderText = "Duração";
            this.duraFilme.Name = "duraFilme";
            this.duraFilme.ReadOnly = true;
            // 
            // genFilme
            // 
            this.genFilme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genFilme.HeaderText = "Genero";
            this.genFilme.Name = "genFilme";
            this.genFilme.ReadOnly = true;
            // 
            // Sinopse
            // 
            this.Sinopse.HeaderText = "Sinopse";
            this.Sinopse.Name = "Sinopse";
            this.Sinopse.ReadOnly = true;
            this.Sinopse.Text = "Ver";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(832, 389);
            this.Controls.Add(this.pnTopo);
            this.Controls.Add(gpFilmes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            gpFilmes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn duraFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn genFilme;
        private System.Windows.Forms.DataGridViewButtonColumn Sinopse;
    }
}