namespace ProjetoCinema
{
    partial class FormAdmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmFuncionario));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpFilmes = new System.Windows.Forms.GroupBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFilmes = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.pnFilmesBaixo = new System.Windows.Forms.Panel();
            this.gpFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.pnFilmes.SuspendLayout();
            this.pnFilmesBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExcluir.Location = new System.Drawing.Point(483, 25);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 28);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVisualizar.Location = new System.Drawing.Point(339, 25);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(136, 28);
            this.btnVisualizar.TabIndex = 17;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditar.Location = new System.Drawing.Point(195, 25);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 28);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNovo.Location = new System.Drawing.Point(51, 25);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(136, 28);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gpFilmes
            // 
            this.gpFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFilmes.BackColor = System.Drawing.Color.Transparent;
            this.gpFilmes.Controls.Add(this.dgvFuncionario);
            this.gpFilmes.Location = new System.Drawing.Point(0, 74);
            this.gpFilmes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpFilmes.Name = "gpFilmes";
            this.gpFilmes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpFilmes.Size = new System.Drawing.Size(685, 236);
            this.gpFilmes.TabIndex = 14;
            this.gpFilmes.TabStop = false;
            this.gpFilmes.Text = "Funcionarios";
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNome,
            this.cCpf,
            this.cIdade,
            this.cSexo});
            this.dgvFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionario.Location = new System.Drawing.Point(4, 19);
            this.dgvFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(677, 213);
            this.dgvFuncionario.TabIndex = 0;
            // 
            // cNome
            // 
            this.cNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNome.HeaderText = "Nome";
            this.cNome.Name = "cNome";
            this.cNome.ReadOnly = true;
            // 
            // cCpf
            // 
            this.cCpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cCpf.HeaderText = "CPF";
            this.cCpf.Name = "cCpf";
            this.cCpf.ReadOnly = true;
            // 
            // cIdade
            // 
            this.cIdade.HeaderText = "Idade";
            this.cIdade.Name = "cIdade";
            this.cIdade.ReadOnly = true;
            // 
            // cSexo
            // 
            this.cSexo.HeaderText = "Sexo";
            this.cSexo.Name = "cSexo";
            this.cSexo.ReadOnly = true;
            // 
            // pnFilmes
            // 
            this.pnFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFilmes.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnFilmes.Controls.Add(this.textBox1);
            this.pnFilmes.Controls.Add(this.lbFiltro);
            this.pnFilmes.Location = new System.Drawing.Point(0, 0);
            this.pnFilmes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnFilmes.Name = "pnFilmes";
            this.pnFilmes.Size = new System.Drawing.Size(685, 75);
            this.pnFilmes.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(97, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lbFiltro
            // 
            this.lbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lbFiltro.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbFiltro.Location = new System.Drawing.Point(47, 25);
            this.lbFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(44, 17);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtrar";
            // 
            // pnFilmesBaixo
            // 
            this.pnFilmesBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFilmesBaixo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnFilmesBaixo.Controls.Add(this.btnExcluir);
            this.pnFilmesBaixo.Controls.Add(this.btnNovo);
            this.pnFilmesBaixo.Controls.Add(this.btnVisualizar);
            this.pnFilmesBaixo.Controls.Add(this.btnEditar);
            this.pnFilmesBaixo.Location = new System.Drawing.Point(0, 306);
            this.pnFilmesBaixo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnFilmesBaixo.Name = "pnFilmesBaixo";
            this.pnFilmesBaixo.Size = new System.Drawing.Size(685, 75);
            this.pnFilmesBaixo.TabIndex = 15;
            // 
            // FormAdmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 386);
            this.Controls.Add(this.pnFilmes);
            this.Controls.Add(this.pnFilmesBaixo);
            this.Controls.Add(this.gpFilmes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmFuncionario";
            this.Text = "Administrar Funcionarios";
            this.gpFilmes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
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
        private System.Windows.Forms.GroupBox gpFilmes;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSexo;
    }
}