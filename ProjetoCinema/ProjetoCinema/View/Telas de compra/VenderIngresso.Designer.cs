namespace ProjetoCinema.BD
{
    partial class VenderIngresso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMais = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.LbQuantidade = new System.Windows.Forms.Label();
            this.txtFilmeNome = new System.Windows.Forms.TextBox();
            this.LbFilmeNome = new System.Windows.Forms.Label();
            this.txtCodigoSessão = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpProdutos = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnRmvIngreço = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crmv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMais);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.LbQuantidade);
            this.panel1.Controls.Add(this.txtFilmeNome);
            this.panel1.Controls.Add(this.LbFilmeNome);
            this.panel1.Controls.Add(this.txtCodigoSessão);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 93);
            this.panel1.TabIndex = 0;
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(642, 26);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(75, 23);
            this.btnMais.TabIndex = 6;
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(541, 26);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(76, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // LbQuantidade
            // 
            this.LbQuantidade.AutoSize = true;
            this.LbQuantidade.Location = new System.Drawing.Point(520, 9);
            this.LbQuantidade.Name = "LbQuantidade";
            this.LbQuantidade.Size = new System.Drawing.Size(110, 13);
            this.LbQuantidade.TabIndex = 4;
            this.LbQuantidade.Text = "Quantidade Ingressos";
            // 
            // txtFilmeNome
            // 
            this.txtFilmeNome.Location = new System.Drawing.Point(216, 25);
            this.txtFilmeNome.Name = "txtFilmeNome";
            this.txtFilmeNome.ReadOnly = true;
            this.txtFilmeNome.Size = new System.Drawing.Size(249, 20);
            this.txtFilmeNome.TabIndex = 3;
            // 
            // LbFilmeNome
            // 
            this.LbFilmeNome.AutoSize = true;
            this.LbFilmeNome.Location = new System.Drawing.Point(213, 9);
            this.LbFilmeNome.Name = "LbFilmeNome";
            this.LbFilmeNome.Size = new System.Drawing.Size(34, 13);
            this.LbFilmeNome.TabIndex = 2;
            this.LbFilmeNome.Text = "Filme:";
            // 
            // txtCodigoSessão
            // 
            this.txtCodigoSessão.Location = new System.Drawing.Point(31, 26);
            this.txtCodigoSessão.Name = "txtCodigoSessão";
            this.txtCodigoSessão.ReadOnly = true;
            this.txtCodigoSessão.Size = new System.Drawing.Size(109, 20);
            this.txtCodigoSessão.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo da sessão";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(487, 226);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(231, 46);
            this.txtTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gpProdutos);
            this.panel2.Location = new System.Drawing.Point(1, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 286);
            this.panel2.TabIndex = 7;
            // 
            // gpProdutos
            // 
            this.gpProdutos.Controls.Add(this.dgvProdutos);
            this.gpProdutos.Location = new System.Drawing.Point(0, 22);
            this.gpProdutos.Name = "gpProdutos";
            this.gpProdutos.Size = new System.Drawing.Size(462, 261);
            this.gpProdutos.TabIndex = 0;
            this.gpProdutos.TabStop = false;
            this.gpProdutos.Text = "Alimentação";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNome,
            this.cTipo,
            this.cPreço,
            this.Cadd});
            this.dgvProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.Size = new System.Drawing.Size(456, 242);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(487, 278);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(99, 23);
            this.btnRemoverProduto.TabIndex = 8;
            this.btnRemoverProduto.Text = "Remover Produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnRmvIngreço
            // 
            this.btnRmvIngreço.Location = new System.Drawing.Point(602, 278);
            this.btnRmvIngreço.Name = "btnRmvIngreço";
            this.btnRmvIngreço.Size = new System.Drawing.Size(116, 23);
            this.btnRmvIngreço.TabIndex = 9;
            this.btnRmvIngreço.Text = "Remover Ingresso";
            this.btnRmvIngreço.UseVisualStyleBackColor = true;
            this.btnRmvIngreço.Click += new System.EventHandler(this.btnRmvIngreço_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(530, 307);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(159, 23);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(573, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCompra);
            this.groupBox1.Location = new System.Drawing.Point(466, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 112);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\\";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Crmv});
            this.dgvCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompra.Location = new System.Drawing.Point(3, 16);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowHeadersVisible = false;
            this.dgvCompra.Size = new System.Drawing.Size(268, 93);
            this.dgvCompra.TabIndex = 1;
            this.dgvCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProjetoCinema.Properties.Resources.images_Snq_1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // Cadd
            // 
            this.Cadd.HeaderText = "Adicionar";
            this.Cadd.Name = "Cadd";
            this.Cadd.ReadOnly = true;
            this.Cadd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cadd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cadd.Text = "ADD";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Crmv
            // 
            this.Crmv.HeaderText = "Remover";
            this.Crmv.Name = "Crmv";
            this.Crmv.ReadOnly = true;
            this.Crmv.Width = 60;
            // 
            // VenderIngresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRmvIngreço);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenderIngresso";
            this.Text = "VenderIngresso";
            this.Load += new System.EventHandler(this.VenderIngresso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigoSessão;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmeNome;
        private System.Windows.Forms.Label LbFilmeNome;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label LbQuantidade;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpProdutos;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnRmvIngreço;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPreço;
        private System.Windows.Forms.DataGridViewButtonColumn Cadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Crmv;
    }
}