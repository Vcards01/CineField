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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duraFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinopse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnVendido = new System.Windows.Forms.Button();
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
            gpFilmes.Location = new System.Drawing.Point(43, 63);
            gpFilmes.Name = "gpFilmes";
            gpFilmes.Size = new System.Drawing.Size(788, 285);
            gpFilmes.TabIndex = 23;
            gpFilmes.TabStop = false;
            gpFilmes.Text = "Filmes";
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.AllowUserToDeleteRows = false;
            this.dgvFilmes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.dgvFilmes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFilmes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFilmes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilmes.EnableHeadersVisualStyles = false;
            this.dgvFilmes.GridColor = System.Drawing.Color.SlateBlue;
            this.dgvFilmes.Location = new System.Drawing.Point(3, 16);
            this.dgvFilmes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFilmes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFilmes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFilmes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFilmes.RowTemplate.Height = 24;
            this.dgvFilmes.Size = new System.Drawing.Size(782, 266);
            this.dgvFilmes.TabIndex = 13;
            this.dgvFilmes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilmes_CellContentClick);
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
            this.duraFilme.HeaderText = "Duração";
            this.duraFilme.Name = "duraFilme";
            this.duraFilme.ReadOnly = true;
            this.duraFilme.Width = 70;
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
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.Controls.Add(this.lbTitulo);
            this.pnTopo.Location = new System.Drawing.Point(43, 3);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(788, 51);
            this.pnTopo.TabIndex = 21;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(314, 7);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(151, 31);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Em Cartaz";
            // 
            // btnVendido
            // 
            this.btnVendido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVendido.Location = new System.Drawing.Point(734, 354);
            this.btnVendido.Name = "btnVendido";
            this.btnVendido.Size = new System.Drawing.Size(94, 23);
            this.btnVendido.TabIndex = 24;
            this.btnVendido.Text = "Mais Vendido";
            this.btnVendido.UseVisualStyleBackColor = true;
            this.btnVendido.Click += new System.EventHandler(this.btnVendido_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.BackgroundImage = global::ProjetoCinema.Properties.Resources.Sem_Título_500;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(832, 389);
            this.Controls.Add(this.btnVendido);
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
        private System.Windows.Forms.Button btnVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn duraFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn genFilme;
        private System.Windows.Forms.DataGridViewButtonColumn Sinopse;
    }
}