namespace ProjetoCinema.View
{
    partial class FormCompra
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.tituloFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duraFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSessoes = new System.Windows.Forms.DataGridView();
            this.pnFilmes = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarF = new System.Windows.Forms.Button();
            this.btnNextF = new System.Windows.Forms.Button();
            this.Filtrolbl = new System.Windows.Forms.Label();
            this.pnSessões = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltarS = new System.Windows.Forms.Button();
            this.btnProximoS = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.CSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLugares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gpFilmes = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            gpFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoes)).BeginInit();
            this.pnFilmes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnSessões.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFilmes
            // 
            gpFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            gpFilmes.Controls.Add(this.dgvFilmes);
            gpFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gpFilmes.ForeColor = System.Drawing.Color.White;
            gpFilmes.Location = new System.Drawing.Point(-129, 73);
            gpFilmes.Name = "gpFilmes";
            gpFilmes.Size = new System.Drawing.Size(581, 57);
            gpFilmes.TabIndex = 40;
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
            this.tituloFilme,
            this.duraFilme,
            this.genFilme});
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
            this.dgvFilmes.Size = new System.Drawing.Size(575, 38);
            this.dgvFilmes.TabIndex = 13;
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
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            groupBox1.Controls.Add(this.dgvSessoes);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(-120, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(563, 100);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filmes";
            // 
            // dgvSessoes
            // 
            this.dgvSessoes.AllowUserToAddRows = false;
            this.dgvSessoes.AllowUserToDeleteRows = false;
            this.dgvSessoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.dgvSessoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CSala,
            this.CHorario,
            this.CFilme,
            this.CLugares});
            this.dgvSessoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSessoes.EnableHeadersVisualStyles = false;
            this.dgvSessoes.GridColor = System.Drawing.Color.SlateBlue;
            this.dgvSessoes.Location = new System.Drawing.Point(3, 16);
            this.dgvSessoes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSessoes.Name = "dgvSessoes";
            this.dgvSessoes.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSessoes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSessoes.RowTemplate.Height = 24;
            this.dgvSessoes.Size = new System.Drawing.Size(557, 81);
            this.dgvSessoes.TabIndex = 13;
            // 
            // pnFilmes
            // 
            this.pnFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFilmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.pnFilmes.Controls.Add(gpFilmes);
            this.pnFilmes.Controls.Add(this.textBox1);
            this.pnFilmes.Controls.Add(this.panel1);
            this.pnFilmes.Controls.Add(this.Filtrolbl);
            this.pnFilmes.Location = new System.Drawing.Point(249, 41);
            this.pnFilmes.Name = "pnFilmes";
            this.pnFilmes.Size = new System.Drawing.Size(337, 258);
            this.pnFilmes.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(11, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnCancelarF);
            this.panel1.Controls.Add(this.btnNextF);
            this.panel1.Location = new System.Drawing.Point(142, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 32);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelarF
            // 
            this.btnCancelarF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelarF.Location = new System.Drawing.Point(-139, 5);
            this.btnCancelarF.Name = "btnCancelarF";
            this.btnCancelarF.Size = new System.Drawing.Size(75, 24);
            this.btnCancelarF.TabIndex = 3;
            this.btnCancelarF.Text = "Cancelar";
            this.btnCancelarF.UseVisualStyleBackColor = true;
            this.btnCancelarF.Click += new System.EventHandler(this.btnCancelarF_Click);
            // 
            // btnNextF
            // 
            this.btnNextF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextF.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextF.Location = new System.Drawing.Point(89, 5);
            this.btnNextF.Name = "btnNextF";
            this.btnNextF.Size = new System.Drawing.Size(75, 24);
            this.btnNextF.TabIndex = 2;
            this.btnNextF.Text = "Next ->";
            this.btnNextF.UseVisualStyleBackColor = false;
            this.btnNextF.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // Filtrolbl
            // 
            this.Filtrolbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Filtrolbl.AutoSize = true;
            this.Filtrolbl.BackColor = System.Drawing.Color.Transparent;
            this.Filtrolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrolbl.ForeColor = System.Drawing.Color.White;
            this.Filtrolbl.Location = new System.Drawing.Point(-38, 43);
            this.Filtrolbl.Name = "Filtrolbl";
            this.Filtrolbl.Size = new System.Drawing.Size(43, 16);
            this.Filtrolbl.TabIndex = 39;
            this.Filtrolbl.Text = "Filtro";
            // 
            // pnSessões
            // 
            this.pnSessões.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSessões.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.pnSessões.Controls.Add(this.panel2);
            this.pnSessões.Controls.Add(groupBox1);
            this.pnSessões.Controls.Add(this.textBox2);
            this.pnSessões.Controls.Add(this.lbFiltro);
            this.pnSessões.Location = new System.Drawing.Point(249, 74);
            this.pnSessões.Name = "pnSessões";
            this.pnSessões.Size = new System.Drawing.Size(337, 224);
            this.pnSessões.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnVoltarS);
            this.panel2.Controls.Add(this.btnProximoS);
            this.panel2.Location = new System.Drawing.Point(97, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 32);
            this.panel2.TabIndex = 41;
            // 
            // btnVoltarS
            // 
            this.btnVoltarS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltarS.Location = new System.Drawing.Point(-99, 5);
            this.btnVoltarS.Name = "btnVoltarS";
            this.btnVoltarS.Size = new System.Drawing.Size(75, 24);
            this.btnVoltarS.TabIndex = 3;
            this.btnVoltarS.Text = "< Voltar";
            this.btnVoltarS.UseVisualStyleBackColor = true;
            this.btnVoltarS.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnProximoS
            // 
            this.btnProximoS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProximoS.BackColor = System.Drawing.SystemColors.Control;
            this.btnProximoS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProximoS.Location = new System.Drawing.Point(129, 5);
            this.btnProximoS.Name = "btnProximoS";
            this.btnProximoS.Size = new System.Drawing.Size(75, 24);
            this.btnProximoS.TabIndex = 2;
            this.btnProximoS.Text = "Next ->";
            this.btnProximoS.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(12, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 20);
            this.textBox2.TabIndex = 38;
            // 
            // lbFiltro
            // 
            this.lbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.ForeColor = System.Drawing.Color.White;
            this.lbFiltro.Location = new System.Drawing.Point(-37, 19);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(43, 16);
            this.lbFiltro.TabIndex = 39;
            this.lbFiltro.Text = "Filtro";
            // 
            // CSala
            // 
            this.CSala.HeaderText = "Sala";
            this.CSala.Name = "CSala";
            this.CSala.ReadOnly = true;
            // 
            // CHorario
            // 
            this.CHorario.HeaderText = "Horario";
            this.CHorario.Name = "CHorario";
            this.CHorario.ReadOnly = true;
            this.CHorario.Width = 207;
            // 
            // CFilme
            // 
            this.CFilme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CFilme.HeaderText = "Filme";
            this.CFilme.Name = "CFilme";
            this.CFilme.ReadOnly = true;
            // 
            // CLugares
            // 
            this.CLugares.HeaderText = "Lugares";
            this.CLugares.Name = "CLugares";
            this.CLugares.ReadOnly = true;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.BackgroundImage = global::ProjetoCinema.Properties.Resources.Tema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(816, 350);
            this.Controls.Add(this.pnFilmes);
            this.Controls.Add(this.pnSessões);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            gpFilmes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoes)).EndInit();
            this.pnFilmes.ResumeLayout(false);
            this.pnFilmes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnSessões.ResumeLayout(false);
            this.pnSessões.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarF;
        private System.Windows.Forms.Button btnNextF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnFilmes;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn duraFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn genFilme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Filtrolbl;
        private System.Windows.Forms.Panel pnSessões;
        private System.Windows.Forms.DataGridView dgvSessoes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVoltarS;
        private System.Windows.Forms.Button btnProximoS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLugares;
    }
}