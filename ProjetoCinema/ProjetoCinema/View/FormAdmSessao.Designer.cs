namespace ProjetoCinema
{
    partial class FormAdmSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmSessao));
            this.gpFilmes = new System.Windows.Forms.GroupBox();
            this.dgvSessao = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnFilmes = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.pnFilmesBaixo = new System.Windows.Forms.Panel();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLugares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessao)).BeginInit();
            this.pnFilmes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFilmes
            // 
            this.gpFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpFilmes.BackColor = System.Drawing.Color.Transparent;
            this.gpFilmes.Controls.Add(this.dgvSessao);
            this.gpFilmes.Location = new System.Drawing.Point(6, 67);
            this.gpFilmes.Name = "gpFilmes";
            this.gpFilmes.Size = new System.Drawing.Size(373, 176);
            this.gpFilmes.TabIndex = 7;
            this.gpFilmes.TabStop = false;
            this.gpFilmes.Text = "Sessões";
            // 
            // dgvSessao
            // 
            this.dgvSessao.AllowUserToAddRows = false;
            this.dgvSessao.AllowUserToDeleteRows = false;
            this.dgvSessao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvSessao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CId,
            this.Filme,
            this.cSala,
            this.cHorario,
            this.cLugares});
            this.dgvSessao.Location = new System.Drawing.Point(3, 16);
            this.dgvSessao.Name = "dgvSessao";
            this.dgvSessao.ReadOnly = true;
            this.dgvSessao.Size = new System.Drawing.Size(373, 164);
            this.dgvSessao.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Location = new System.Drawing.Point(385, 73);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(385, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizar.Location = new System.Drawing.Point(385, 170);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(102, 23);
            this.btnVisualizar.TabIndex = 10;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(385, 220);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pnFilmes
            // 
            this.pnFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFilmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnFilmes.Controls.Add(this.textBox1);
            this.pnFilmes.Controls.Add(this.lbFiltro);
            this.pnFilmes.Location = new System.Drawing.Point(6, 6);
            this.pnFilmes.Name = "pnFilmes";
            this.pnFilmes.Size = new System.Drawing.Size(499, 61);
            this.pnFilmes.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Location = new System.Drawing.Point(65, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbFiltro
            // 
            this.lbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lbFiltro.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbFiltro.Location = new System.Drawing.Point(27, 20);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(32, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtrar";
            // 
            // pnFilmesBaixo
            // 
            this.pnFilmesBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFilmesBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnFilmesBaixo.Location = new System.Drawing.Point(6, 247);
            this.pnFilmesBaixo.Name = "pnFilmesBaixo";
            this.pnFilmesBaixo.Size = new System.Drawing.Size(499, 58);
            this.pnFilmesBaixo.TabIndex = 8;
            // 
            // CId
            // 
            this.CId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CId.HeaderText = "ID";
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            this.CId.Width = 25;
            // 
            // Filme
            // 
            this.Filme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Filme.HeaderText = "Filme";
            this.Filme.Name = "Filme";
            this.Filme.ReadOnly = true;
            // 
            // cSala
            // 
            this.cSala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cSala.HeaderText = "Sala";
            this.cSala.Name = "cSala";
            this.cSala.ReadOnly = true;
            // 
            // cHorario
            // 
            this.cHorario.HeaderText = "Horário";
            this.cHorario.Name = "cHorario";
            this.cHorario.ReadOnly = true;
            this.cHorario.Width = 50;
            // 
            // cLugares
            // 
            this.cLugares.HeaderText = "Lugares ";
            this.cLugares.Name = "cLugares";
            this.cLugares.ReadOnly = true;
            this.cLugares.Width = 50;
            // 
            // FormAdmSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.BackgroundImage = global::ProjetoCinema.Properties.Resources.Sem_Título_22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 310);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pnFilmes);
            this.Controls.Add(this.pnFilmesBaixo);
            this.Controls.Add(this.gpFilmes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdmSessao";
            this.Text = "Administrar Sessões";
            this.Load += new System.EventHandler(this.FormAdmSessao_Load);
            this.gpFilmes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessao)).EndInit();
            this.pnFilmes.ResumeLayout(false);
            this.pnFilmes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFilmes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Panel pnFilmesBaixo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpFilmes;
        private System.Windows.Forms.DataGridView dgvSessao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLugares;
    }
}