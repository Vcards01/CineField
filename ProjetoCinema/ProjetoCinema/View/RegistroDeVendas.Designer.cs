namespace ProjetoCinema.View
{
    partial class RegistroDeVendas
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
            this.GpVendas = new System.Windows.Forms.GroupBox();
            this.DgvVendas = new System.Windows.Forms.DataGridView();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.GpVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // GpVendas
            // 
            this.GpVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpVendas.Controls.Add(this.DgvVendas);
            this.GpVendas.Location = new System.Drawing.Point(-1, 33);
            this.GpVendas.Name = "GpVendas";
            this.GpVendas.Size = new System.Drawing.Size(919, 338);
            this.GpVendas.TabIndex = 0;
            this.GpVendas.TabStop = false;
            this.GpVendas.Text = "Vendas Efetuadas";
            // 
            // DgvVendas
            // 
            this.DgvVendas.AllowUserToAddRows = false;
            this.DgvVendas.AllowUserToDeleteRows = false;
            this.DgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CId,
            this.CDataVenda,
            this.CHora,
            this.CValor});
            this.DgvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvVendas.Location = new System.Drawing.Point(3, 16);
            this.DgvVendas.Name = "DgvVendas";
            this.DgvVendas.ReadOnly = true;
            this.DgvVendas.Size = new System.Drawing.Size(913, 319);
            this.DgvVendas.TabIndex = 0;
            // 
            // CId
            // 
            this.CId.HeaderText = "ID";
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            // 
            // CDataVenda
            // 
            this.CDataVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDataVenda.HeaderText = "Data";
            this.CDataVenda.Name = "CDataVenda";
            this.CDataVenda.ReadOnly = true;
            // 
            // CHora
            // 
            this.CHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CHora.HeaderText = "Hora";
            this.CHora.Name = "CHora";
            this.CHora.ReadOnly = true;
            // 
            // CValor
            // 
            this.CValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CValor.HeaderText = "Valor";
            this.CValor.Name = "CValor";
            this.CValor.ReadOnly = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(606, 372);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(208, 14);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(40, 13);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusca.Location = new System.Drawing.Point(254, 11);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(471, 20);
            this.txtBusca.TabIndex = 3;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.Location = new System.Drawing.Point(254, 372);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // RegistroDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 400);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.GpVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroDeVendas";
            this.Text = "RegistroDeVendas";
            this.Load += new System.EventHandler(this.RegistroDeVendas_Load);
            this.GpVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpVendas;
        private System.Windows.Forms.DataGridView DgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CValor;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnSair;
    }
}