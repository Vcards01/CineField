namespace ProjetoCinema
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextSections_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Início = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_sessao = new System.Windows.Forms.Button();
            this.btn_filme = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.current_time_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjetoCinema.Properties.Resources.movietheater_screen_seats_700x3961;
            this.panel1.Controls.Add(this.nextSections_lbl);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_sessao);
            this.panel1.Controls.Add(this.btn_filme);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 393);
            this.panel1.TabIndex = 0;
            // 
            // nextSections_lbl
            // 
            this.nextSections_lbl.AutoSize = true;
            this.nextSections_lbl.BackColor = System.Drawing.Color.Transparent;
            this.nextSections_lbl.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSections_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextSections_lbl.Location = new System.Drawing.Point(285, 86);
            this.nextSections_lbl.Name = "nextSections_lbl";
            this.nextSections_lbl.Size = new System.Drawing.Size(106, 12);
            this.nextSections_lbl.TabIndex = 9;
            this.nextSections_lbl.Text = "PRÓXIMAS SESSÕES";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(285, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 273);
            this.panel3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filme,
            this.Início});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // Filme
            // 
            this.Filme.HeaderText = "Filme";
            this.Filme.Name = "Filme";
            this.Filme.Width = 250;
            // 
            // Início
            // 
            this.Início.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Início.HeaderText = "Início";
            this.Início.Name = "Início";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ProjetoCinema.Properties.Resources.movie_film_border_hi;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(31, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ingressos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_sessao
            // 
            this.btn_sessao.BackgroundImage = global::ProjetoCinema.Properties.Resources.movie_film_border_hi;
            this.btn_sessao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sessao.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sessao.Location = new System.Drawing.Point(31, 176);
            this.btn_sessao.Name = "btn_sessao";
            this.btn_sessao.Size = new System.Drawing.Size(150, 54);
            this.btn_sessao.TabIndex = 6;
            this.btn_sessao.Text = "Sessões";
            this.btn_sessao.UseVisualStyleBackColor = true;
            // 
            // btn_filme
            // 
            this.btn_filme.BackgroundImage = global::ProjetoCinema.Properties.Resources.movie_film_border_hi;
            this.btn_filme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_filme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filme.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filme.Location = new System.Drawing.Point(31, 105);
            this.btn_filme.Name = "btn_filme";
            this.btn_filme.Size = new System.Drawing.Size(150, 54);
            this.btn_filme.TabIndex = 5;
            this.btn_filme.Text = "Filmes";
            this.btn_filme.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ProjetoCinema.Properties.Resources.movie_film_border_hi;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(32, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Comidas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::ProjetoCinema.Properties.Resources.movietheater_screen_seats_700x3961;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.current_time_lbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 78);
            this.panel2.TabIndex = 0;
            // 
            // current_time_lbl
            // 
            this.current_time_lbl.AutoSize = true;
            this.current_time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.current_time_lbl.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_time_lbl.ForeColor = System.Drawing.Color.Snow;
            this.current_time_lbl.Location = new System.Drawing.Point(422, 25);
            this.current_time_lbl.Name = "current_time_lbl";
            this.current_time_lbl.Size = new System.Drawing.Size(85, 41);
            this.current_time_lbl.TabIndex = 1;
            this.current_time_lbl.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "CINEMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 393);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(680, 459);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label current_time_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label nextSections_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Início;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_sessao;
        private System.Windows.Forms.Button btn_filme;
        private System.Windows.Forms.Button button4;
    }
}

