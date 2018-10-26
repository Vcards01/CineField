namespace ProjetoCinema
{
    partial class FormIngressos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpFilmes = new System.Windows.Forms.GroupBox();
            this.Filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFilmes = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.pnFilmesBaixo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxMeia = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpFilmes.SuspendLayout();
            this.pnFilmes.SuspendLayout();
            this.pnFilmesBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filme,
            this.cSala,
            this.cHorario});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(508, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // gpFilmes
            // 
            this.gpFilmes.BackColor = System.Drawing.Color.Transparent;
            this.gpFilmes.Controls.Add(this.dataGridView1);
            this.gpFilmes.Location = new System.Drawing.Point(-2, 67);
            this.gpFilmes.Name = "gpFilmes";
            this.gpFilmes.Size = new System.Drawing.Size(514, 185);
            this.gpFilmes.TabIndex = 4;
            this.gpFilmes.TabStop = false;
            this.gpFilmes.Text = "Sessões";
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
            this.cSala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cSala.HeaderText = "Sala";
            this.cSala.Name = "cSala";
            this.cSala.ReadOnly = true;
            this.cSala.Width = 50;
            // 
            // cHorario
            // 
            this.cHorario.HeaderText = "Horário";
            this.cHorario.Name = "cHorario";
            this.cHorario.ReadOnly = true;
            // 
            // pnFilmes
            // 
            this.pnFilmes.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnFilmes.Controls.Add(this.textBox1);
            this.pnFilmes.Controls.Add(this.lbFiltro);
            this.pnFilmes.Location = new System.Drawing.Point(-2, 0);
            this.pnFilmes.Name = "pnFilmes";
            this.pnFilmes.Size = new System.Drawing.Size(514, 61);
            this.pnFilmes.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lbFiltro.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbFiltro.Location = new System.Drawing.Point(35, 20);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(32, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtrar";
            // 
            // pnFilmesBaixo
            // 
            this.pnFilmesBaixo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnFilmesBaixo.Controls.Add(this.button1);
            this.pnFilmesBaixo.Controls.Add(this.checkBoxMeia);
            this.pnFilmesBaixo.Location = new System.Drawing.Point(-2, 249);
            this.pnFilmesBaixo.Name = "pnFilmesBaixo";
            this.pnFilmesBaixo.Size = new System.Drawing.Size(514, 61);
            this.pnFilmesBaixo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reservar Lugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxMeia
            // 
            this.checkBoxMeia.AutoSize = true;
            this.checkBoxMeia.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMeia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMeia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxMeia.Location = new System.Drawing.Point(412, 20);
            this.checkBoxMeia.Name = "checkBoxMeia";
            this.checkBoxMeia.Size = new System.Drawing.Size(66, 24);
            this.checkBoxMeia.TabIndex = 0;
            this.checkBoxMeia.Text = "Meia";
            this.checkBoxMeia.UseVisualStyleBackColor = false;
            // 
            // FormIngressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 310);
            this.Controls.Add(this.pnFilmes);
            this.Controls.Add(this.pnFilmesBaixo);
            this.Controls.Add(this.gpFilmes);
            this.Name = "FormIngressos";
            this.Text = "FormIngressos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpFilmes.ResumeLayout(false);
            this.pnFilmes.ResumeLayout(false);
            this.pnFilmes.PerformLayout();
            this.pnFilmesBaixo.ResumeLayout(false);
            this.pnFilmesBaixo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFilmes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnFilmesBaixo;
        private System.Windows.Forms.GroupBox gpFilmes;
        private System.Windows.Forms.CheckBox checkBoxMeia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHorario;
        private System.Windows.Forms.Button button1;
    }
}