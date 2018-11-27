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
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cqtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnRmvIngreço = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.LbFilmeNome);
            this.panel1.Controls.Add(this.txtCodigoSessão);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 79);
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
            this.txtTotal.Location = new System.Drawing.Point(502, 97);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(231, 46);
            this.txtTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 81);
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
            this.gpProdutos.Location = new System.Drawing.Point(0, 4);
            this.gpProdutos.Name = "gpProdutos";
            this.gpProdutos.Size = new System.Drawing.Size(462, 279);
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
            this.Cqtd});
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(456, 260);
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
            // Cqtd
            // 
            this.Cqtd.HeaderText = "Quantidade";
            this.Cqtd.Name = "Cqtd";
            this.Cqtd.ReadOnly = true;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(502, 149);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(99, 23);
            this.btnRemoverProduto.TabIndex = 8;
            this.btnRemoverProduto.Text = "Remover Produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnRmvIngreço
            // 
            this.btnRmvIngreço.Location = new System.Drawing.Point(617, 149);
            this.btnRmvIngreço.Name = "btnRmvIngreço";
            this.btnRmvIngreço.Size = new System.Drawing.Size(116, 23);
            this.btnRmvIngreço.TabIndex = 9;
            this.btnRmvIngreço.Text = "Remover Ingresso";
            this.btnRmvIngreço.UseVisualStyleBackColor = true;
            this.btnRmvIngreço.Click += new System.EventHandler(this.btnRmvIngreço_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(530, 327);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(159, 23);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // VenderIngresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 362);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRmvIngreço);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.panel1);
            this.Name = "VenderIngresso";
            this.Text = "VenderIngresso";
            this.Load += new System.EventHandler(this.VenderIngresso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPreço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cqtd;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnRmvIngreço;
        private System.Windows.Forms.Button btnFinalizar;
    }
}