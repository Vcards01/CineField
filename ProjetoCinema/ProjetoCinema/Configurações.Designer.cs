namespace ProjetoCinema
{
    partial class Configurações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurações));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFilme = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMenu.BackgroundImage = global::ProjetoCinema.Properties.Resources.movietheater_screen_seats_700x3961;
            this.pnMenu.Controls.Add(this.button2);
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Controls.Add(this.btnFilme);
            this.pnMenu.Location = new System.Drawing.Point(2, -2);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(629, 444);
            this.pnMenu.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Configurações";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Desligar Relógio";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnFilme
            // 
            this.btnFilme.BackColor = System.Drawing.Color.Transparent;
            this.btnFilme.FlatAppearance.BorderSize = 0;
            this.btnFilme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnFilme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnFilme.ForeColor = System.Drawing.Color.White;
            this.btnFilme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilme.Location = new System.Drawing.Point(0, 138);
            this.btnFilme.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(211, 45);
            this.btnFilme.TabIndex = 9;
            this.btnFilme.Text = "Travar Janela";
            this.btnFilme.UseVisualStyleBackColor = false;
            // 
            // Configurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 443);
            this.Controls.Add(this.pnMenu);
            this.Name = "Configurações";
            this.Text = "Configurações";
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFilme;
    }
}