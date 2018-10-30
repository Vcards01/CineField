namespace ProjetoCinema
{
    partial class FormPrintIngresso
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
            this.gpFilmes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnFilmes = new System.Windows.Forms.Panel();
            this.lbl_ingresso = new System.Windows.Forms.Label();
            this.pnFilmesBaixo = new System.Windows.Forms.Panel();
            this.i = new System.Windows.Forms.Button();
            this.gpFilmes.SuspendLayout();
            this.pnFilmes.SuspendLayout();
            this.pnFilmesBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFilmes
            // 
            this.gpFilmes.BackColor = System.Drawing.Color.Transparent;
            this.gpFilmes.Controls.Add(this.label2);
            this.gpFilmes.Controls.Add(this.label1);
            this.gpFilmes.Location = new System.Drawing.Point(1, 68);
            this.gpFilmes.Name = "gpFilmes";
            this.gpFilmes.Size = new System.Drawing.Size(511, 325);
            this.gpFilmes.TabIndex = 7;
            this.gpFilmes.TabStop = false;
            this.gpFilmes.Text = "Ingresso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aqui você pega seu ingresso no futuro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pnFilmes
            // 
            this.pnFilmes.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnFilmes.Controls.Add(this.lbl_ingresso);
            this.pnFilmes.Location = new System.Drawing.Point(1, 1);
            this.pnFilmes.Name = "pnFilmes";
            this.pnFilmes.Size = new System.Drawing.Size(511, 61);
            this.pnFilmes.TabIndex = 6;
            // 
            // lbl_ingresso
            // 
            this.lbl_ingresso.AutoSize = true;
            this.lbl_ingresso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ingresso.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingresso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ingresso.Location = new System.Drawing.Point(131, 17);
            this.lbl_ingresso.Name = "lbl_ingresso";
            this.lbl_ingresso.Size = new System.Drawing.Size(240, 29);
            this.lbl_ingresso.TabIndex = 0;
            this.lbl_ingresso.Text = "Pegue seu ingresso";
            // 
            // pnFilmesBaixo
            // 
            this.pnFilmesBaixo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnFilmesBaixo.Controls.Add(this.i);
            this.pnFilmesBaixo.Location = new System.Drawing.Point(1, 393);
            this.pnFilmesBaixo.Name = "pnFilmesBaixo";
            this.pnFilmesBaixo.Size = new System.Drawing.Size(511, 61);
            this.pnFilmesBaixo.TabIndex = 8;
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(25, 20);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(102, 23);
            this.i.TabIndex = 1;
            this.i.Text = "Imprimir ingresso!";
            this.i.UseVisualStyleBackColor = true;
            // 
            // FormPrintIngresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 451);
            this.Controls.Add(this.pnFilmes);
            this.Controls.Add(this.pnFilmesBaixo);
            this.Controls.Add(this.gpFilmes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrintIngresso";
            this.Text = "FormPrintIngresso";
            this.gpFilmes.ResumeLayout(false);
            this.gpFilmes.PerformLayout();
            this.pnFilmes.ResumeLayout(false);
            this.pnFilmes.PerformLayout();
            this.pnFilmesBaixo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFilmes;
        private System.Windows.Forms.Panel pnFilmesBaixo;
        private System.Windows.Forms.Button i;
        private System.Windows.Forms.GroupBox gpFilmes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ingresso;
    }
}