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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMais = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.LbQuantidade = new System.Windows.Forms.Label();
            this.txtFilmeNome = new System.Windows.Forms.TextBox();
            this.btnRmvIngreço = new System.Windows.Forms.Button();
            this.LbFilmeNome = new System.Windows.Forms.Label();
            this.txtCodigoSessão = new System.Windows.Forms.TextBox();
            this.lbCodSessão = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.gpProdutos = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crmv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.gpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMais);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.LbQuantidade);
            this.panel1.Controls.Add(this.txtFilmeNome);
            this.panel1.Controls.Add(this.btnRmvIngreço);
            this.panel1.Controls.Add(this.LbFilmeNome);
            this.panel1.Controls.Add(this.txtCodigoSessão);
            this.panel1.Controls.Add(this.lbCodSessão);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 93);
            this.panel1.TabIndex = 0;
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.Transparent;
            this.btnMais.BackgroundImage = global::ProjetoCinema.Properties.Resources.plus_PNG121;
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMais.FlatAppearance.BorderSize = 0;
            this.btnMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMais.Location = new System.Drawing.Point(685, 36);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(40, 40);
            this.btnMais.TabIndex = 6;
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(590, 37);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(76, 38);
            this.txtQuantidade.TabIndex = 5;
            // 
            // LbQuantidade
            // 
            this.LbQuantidade.AutoSize = true;
            this.LbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQuantidade.Location = new System.Drawing.Point(520, 9);
            this.LbQuantidade.Name = "LbQuantidade";
            this.LbQuantidade.Size = new System.Drawing.Size(204, 25);
            this.LbQuantidade.TabIndex = 4;
            this.LbQuantidade.Text = "Quantidade Ingressos";
            // 
            // txtFilmeNome
            // 
            this.txtFilmeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilmeNome.Location = new System.Drawing.Point(210, 37);
            this.txtFilmeNome.Name = "txtFilmeNome";
            this.txtFilmeNome.ReadOnly = true;
            this.txtFilmeNome.Size = new System.Drawing.Size(249, 38);
            this.txtFilmeNome.TabIndex = 3;
            // 
            // btnRmvIngreço
            // 
            this.btnRmvIngreço.BackColor = System.Drawing.Color.Transparent;
            this.btnRmvIngreço.BackgroundImage = global::ProjetoCinema.Properties.Resources.Minus;
            this.btnRmvIngreço.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRmvIngreço.FlatAppearance.BorderSize = 0;
            this.btnRmvIngreço.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvIngreço.Location = new System.Drawing.Point(735, 35);
            this.btnRmvIngreço.Name = "btnRmvIngreço";
            this.btnRmvIngreço.Size = new System.Drawing.Size(40, 40);
            this.btnRmvIngreço.TabIndex = 9;
            this.btnRmvIngreço.UseVisualStyleBackColor = false;
            this.btnRmvIngreço.Click += new System.EventHandler(this.btnRmvIngreço_Click);
            // 
            // LbFilmeNome
            // 
            this.LbFilmeNome.AutoSize = true;
            this.LbFilmeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFilmeNome.Location = new System.Drawing.Point(208, 9);
            this.LbFilmeNome.Name = "LbFilmeNome";
            this.LbFilmeNome.Size = new System.Drawing.Size(65, 25);
            this.LbFilmeNome.TabIndex = 2;
            this.LbFilmeNome.Text = "Filme:";
            // 
            // txtCodigoSessão
            // 
            this.txtCodigoSessão.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSessão.Location = new System.Drawing.Point(31, 37);
            this.txtCodigoSessão.Name = "txtCodigoSessão";
            this.txtCodigoSessão.ReadOnly = true;
            this.txtCodigoSessão.Size = new System.Drawing.Size(109, 38);
            this.txtCodigoSessão.TabIndex = 1;
            // 
            // lbCodSessão
            // 
            this.lbCodSessão.AutoSize = true;
            this.lbCodSessão.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodSessão.Location = new System.Drawing.Point(11, 9);
            this.lbCodSessão.Name = "lbCodSessão";
            this.lbCodSessão.Size = new System.Drawing.Size(170, 25);
            this.lbCodSessão.TabIndex = 0;
            this.lbCodSessão.Text = "Codigo da sessão";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(545, 332);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(240, 46);
            this.txtTotal.TabIndex = 1;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(593, 283);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(148, 46);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "TOTAL";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(626, 424);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(159, 23);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(545, 424);
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
            this.groupBox1.Location = new System.Drawing.Point(472, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 177);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\\";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Crmv});
            this.dgvCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompra.Location = new System.Drawing.Point(3, 16);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowHeadersVisible = false;
            this.dgvCompra.Size = new System.Drawing.Size(364, 158);
            this.dgvCompra.TabIndex = 1;
            this.dgvCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellContentClick);
            // 
            // gpProdutos
            // 
            this.gpProdutos.Controls.Add(this.dgvProdutos);
            this.gpProdutos.Location = new System.Drawing.Point(1, 94);
            this.gpProdutos.Name = "gpProdutos";
            this.gpProdutos.Size = new System.Drawing.Size(462, 368);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Size = new System.Drawing.Size(456, 349);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProjetoCinema.Properties.Resources.images_Snq_1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
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
            this.ClientSize = new System.Drawing.Size(872, 530);
            this.Controls.Add(this.gpProdutos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenderIngresso";
            this.Text = "VenderIngresso";
            this.Load += new System.EventHandler(this.VenderIngresso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.gpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigoSessão;
        private System.Windows.Forms.Label lbCodSessão;
        private System.Windows.Forms.TextBox txtFilmeNome;
        private System.Windows.Forms.Label LbFilmeNome;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label LbQuantidade;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnRmvIngreço;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox gpProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPreço;
        private System.Windows.Forms.DataGridViewButtonColumn Cadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Crmv;
    }
}