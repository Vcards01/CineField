namespace ProjetoCinema.View
{
    partial class SelectLugar
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
            this.pnCadeiras = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnCadeiras
            // 
            this.pnCadeiras.Location = new System.Drawing.Point(58, -2);
            this.pnCadeiras.Name = "pnCadeiras";
            this.pnCadeiras.Size = new System.Drawing.Size(400, 380);
            this.pnCadeiras.TabIndex = 0;
            // 
            // SelectLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 377);
            this.Controls.Add(this.pnCadeiras);
            this.Name = "SelectLugar";
            this.Text = "SelectLugar";
            this.Load += new System.EventHandler(this.SelectLugar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnCadeiras;
    }
}