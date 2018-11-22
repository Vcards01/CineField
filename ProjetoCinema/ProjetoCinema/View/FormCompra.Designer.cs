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
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gênero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duração = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Filtrolbl = new System.Windows.Forms.Label();
            this.pnBaixo.SuspendLayout();
            this.pnTopo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBaixo
            // 
            this.pnBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBaixo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnBaixo.Controls.Add(this.btnCancelar);
            this.pnBaixo.Controls.Add(this.btnNext);
            this.pnBaixo.Location = new System.Drawing.Point(-3, 299);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(849, 42);
            this.pnBaixo.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelar.Location = new System.Drawing.Point(277, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.Location = new System.Drawing.Point(473, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next ->";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnTopo.Controls.Add(this.Filtrolbl);
            this.pnTopo.Controls.Add(this.textBox1);
            this.pnTopo.Controls.Add(this.panel2);
            this.pnTopo.Controls.Add(this.panel1);
            this.pnTopo.Location = new System.Drawing.Point(-3, -3);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(849, 42);
            this.pnTopo.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoCinema.Properties.Resources.cinza1;
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 267);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(361, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 264);
            this.panel2.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título,
            this.Gênero,
            this.Duração});
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 264);
            this.dataGridView1.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(218, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 38;
            // 
            // Título
            // 
            this.Título.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            // 
            // Gênero
            // 
            this.Gênero.HeaderText = "Gênero";
            this.Gênero.Name = "Gênero";
            // 
            // Duração
            // 
            this.Duração.HeaderText = "Duração";
            this.Duração.Name = "Duração";
            this.Duração.Width = 60;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 38;
            // 
            // Filtrolbl
            // 
            this.Filtrolbl.AutoSize = true;
            this.Filtrolbl.BackColor = System.Drawing.Color.Transparent;
            this.Filtrolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrolbl.ForeColor = System.Drawing.Color.White;
            this.Filtrolbl.Location = new System.Drawing.Point(15, 12);
            this.Filtrolbl.Name = "Filtrolbl";
            this.Filtrolbl.Size = new System.Drawing.Size(43, 16);
            this.Filtrolbl.TabIndex = 39;
            this.Filtrolbl.Text = "Filtro";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnBaixo);
            this.Controls.Add(this.pnTopo);
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            this.pnBaixo.ResumeLayout(false);
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Label Filtrolbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gênero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duração;
    }
}