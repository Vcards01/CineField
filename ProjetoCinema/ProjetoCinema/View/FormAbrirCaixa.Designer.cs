namespace ProjetoCinema.View
{
    partial class FormAbrirCaixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.lbAberto = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Inicial";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(100, 86);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lbAberto
            // 
            this.lbAberto.AutoSize = true;
            this.lbAberto.BackColor = System.Drawing.Color.Transparent;
            this.lbAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAberto.Location = new System.Drawing.Point(23, 46);
            this.lbAberto.Name = "lbAberto";
            this.lbAberto.Size = new System.Drawing.Size(240, 13);
            this.lbAberto.TabIndex = 3;
            this.lbAberto.Text = "O caixa de hoje ja foi aberto, então sera reaberto!";
            this.lbAberto.Visible = false;
            // 
            // txtInicial
            // 
            this.txtInicial.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtInicial.Location = new System.Drawing.Point(89, 43);
            this.txtInicial.Mask = "$0000.00";
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(101, 20);
            this.txtInicial.TabIndex = 35;
            this.txtInicial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FormAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 121);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.lbAberto);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbrirCaixa";
            this.Text = "FormAbrirCaixa";
            this.Load += new System.EventHandler(this.FormAbrirCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lbAberto;
        private System.Windows.Forms.MaskedTextBox txtInicial;
    }
}