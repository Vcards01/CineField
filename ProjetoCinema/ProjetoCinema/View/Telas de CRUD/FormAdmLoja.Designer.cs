namespace ProjetoCinema
{
    partial class FormAdmLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmLoja));
            this.gpLoja = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnFilmes = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.pnFilmesBaixo = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpLoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnFilmes.SuspendLayout();
            this.pnFilmesBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpLoja
            // 
            this.gpLoja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpLoja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.gpLoja.Controls.Add(this.dgvProdutos);
            this.gpLoja.Location = new System.Drawing.Point(3, 63);
            this.gpLoja.Name = "gpLoja";
            this.gpLoja.Size = new System.Drawing.Size(534, 189);
            this.gpLoja.TabIndex = 14;
            this.gpLoja.TabStop = false;
            this.gpLoja.Text = "Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNome,
            this.cTipo,
            this.cPreço});
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(528, 170);
            this.dgvProdutos.TabIndex = 0;
            // 
            // pnFilmes
            // 
            this.pnFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFilmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnFilmes.Controls.Add(this.textBox1);
            this.pnFilmes.Controls.Add(this.lbFiltro);
            this.pnFilmes.Location = new System.Drawing.Point(3, 248);
            this.pnFilmes.Name = "pnFilmes";
            this.pnFilmes.Size = new System.Drawing.Size(534, 58);
            this.pnFilmes.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Location = new System.Drawing.Point(83, 17);
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
            this.lbFiltro.Location = new System.Drawing.Point(45, 20);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(32, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtrar";
            // 
            // pnFilmesBaixo
            // 
            this.pnFilmesBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFilmesBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnFilmesBaixo.Controls.Add(this.btnExcluir);
            this.pnFilmesBaixo.Controls.Add(this.btnNovo);
            this.pnFilmesBaixo.Controls.Add(this.btnEditar);
            this.pnFilmesBaixo.Controls.Add(this.btnVisualizar);
            this.pnFilmesBaixo.Location = new System.Drawing.Point(3, 3);
            this.pnFilmesBaixo.Name = "pnFilmesBaixo";
            this.pnFilmesBaixo.Size = new System.Drawing.Size(534, 61);
            this.pnFilmesBaixo.TabIndex = 15;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExcluir.Location = new System.Drawing.Point(405, 22);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNovo.Location = new System.Drawing.Point(30, 22);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditar.Location = new System.Drawing.Point(151, 22);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVisualizar.Location = new System.Drawing.Point(280, 22);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(102, 23);
            this.btnVisualizar.TabIndex = 17;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cNome
            // 
            this.cNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNome.HeaderText = "Nome";
            this.cNome.Name = "cNome";
            this.cNome.ReadOnly = true;
            // 
            // cTipo
            // 
            this.cTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTipo.HeaderText = "Tipo";
            this.cTipo.Name = "cTipo";
            this.cTipo.ReadOnly = true;
            // 
            // cPreço
            // 
            this.cPreço.HeaderText = "Preço";
            this.cPreço.Name = "cPreço";
            this.cPreço.ReadOnly = true;
            // 
            // FormAdmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCinema.Properties.Resources.Sem_Título_22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 309);
            this.Controls.Add(this.pnFilmes);
            this.Controls.Add(this.pnFilmesBaixo);
            this.Controls.Add(this.gpLoja);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdmLoja";
            this.Text = "Administrar Loja";
            this.gpLoja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnFilmes.ResumeLayout(false);
            this.pnFilmes.PerformLayout();
            this.pnFilmesBaixo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnFilmes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Panel pnFilmesBaixo;
        private System.Windows.Forms.GroupBox gpLoja;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPreço;
    }
}