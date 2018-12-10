namespace ProjetoCinema.View
{
    partial class Registro_de_ingressos
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
            this.btnSair = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.GpVendas = new System.Windows.Forms.GroupBox();
            this.DgvVendas = new System.Windows.Forms.DataGridView();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFilme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIngresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.Location = new System.Drawing.Point(246, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 21);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusca.Location = new System.Drawing.Point(246, 10);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(471, 20);
            this.txtBusca.TabIndex = 8;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // lbBuscar
            // 
            this.lbBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(200, 13);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(40, 13);
            this.lbBuscar.TabIndex = 7;
            this.lbBuscar.Text = "Buscar";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(595, 329);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 20);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // GpVendas
            // 
            this.GpVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpVendas.Controls.Add(this.DgvVendas);
            this.GpVendas.Location = new System.Drawing.Point(12, 32);
            this.GpVendas.Name = "GpVendas";
            this.GpVendas.Size = new System.Drawing.Size(877, 290);
            this.GpVendas.TabIndex = 5;
            this.GpVendas.TabStop = false;
            this.GpVendas.Text = "Ingressos Vendidos";
            // 
            // DgvVendas
            // 
            this.DgvVendas.AllowUserToAddRows = false;
            this.DgvVendas.AllowUserToDeleteRows = false;
            this.DgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CId,
            this.CFilme,
            this.CIngresso});
            this.DgvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvVendas.Location = new System.Drawing.Point(3, 16);
            this.DgvVendas.Name = "DgvVendas";
            this.DgvVendas.ReadOnly = true;
            this.DgvVendas.Size = new System.Drawing.Size(871, 271);
            this.DgvVendas.TabIndex = 0;
            // 
            // CId
            // 
            this.CId.HeaderText = "ID";
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            // 
            // CFilme
            // 
            this.CFilme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CFilme.HeaderText = "Filme";
            this.CFilme.Name = "CFilme";
            this.CFilme.ReadOnly = true;
            // 
            // CIngresso
            // 
            this.CIngresso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CIngresso.HeaderText = "Quantidade de ingressos vendidos";
            this.CIngresso.Name = "CIngresso";
            this.CIngresso.ReadOnly = true;
            // 
            // Registro_de_ingressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 361);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.GpVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_ingressos";
            this.Text = "Registro_de_ingressos";
            this.Load += new System.EventHandler(this.Registro_de_ingressos_Load);
            this.GpVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox GpVendas;
        private System.Windows.Forms.DataGridView DgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIngresso;
    }
}