namespace ProjetoCinema
{
    partial class FormComida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComida));
            this.pnTopo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_bebida = new System.Windows.Forms.Button();
            this.btn_doce = new System.Windows.Forms.Button();
            this.btn_pipoca = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnTopo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopo
            // 
            this.pnTopo.BackgroundImage = global::ProjetoCinema.Properties.Resources.fundo1;
            this.pnTopo.Controls.Add(this.panel2);
            this.pnTopo.Controls.Add(this.dataGridView1);
            this.pnTopo.Controls.Add(this.panel1);
            this.pnTopo.Controls.Add(this.lbTitulo);
            this.pnTopo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.MaximumSize = new System.Drawing.Size(342, 433);
            this.pnTopo.MinimumSize = new System.Drawing.Size(342, 433);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(342, 433);
            this.pnTopo.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(158, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 167);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjetoCinema.Properties.Resources.shopping_cart;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(56, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 53);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.preco});
            this.dataGridView1.Location = new System.Drawing.Point(158, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(185, 170);
            this.dataGridView1.TabIndex = 5;
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item.HeaderText = "ITEM";
            this.item.Name = "item";
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preco.HeaderText = "PREÇO";
            this.preco.Name = "preco";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btn_bebida);
            this.panel1.Controls.Add(this.btn_doce);
            this.panel1.Controls.Add(this.btn_pipoca);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 328);
            this.panel1.TabIndex = 4;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 162);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(33, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "G";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(9, 139);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(34, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "M";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(9, 116);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(32, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "P";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 65);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(33, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "G";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 42);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(34, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "M";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 20);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "P";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_bebida
            // 
            this.btn_bebida.BackgroundImage = global::ProjetoCinema.Properties.Resources.can;
            this.btn_bebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bebida.Location = new System.Drawing.Point(44, 116);
            this.btn_bebida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bebida.Name = "btn_bebida";
            this.btn_bebida.Size = new System.Drawing.Size(56, 68);
            this.btn_bebida.TabIndex = 2;
            this.btn_bebida.UseVisualStyleBackColor = true;
            // 
            // btn_doce
            // 
            this.btn_doce.BackgroundImage = global::ProjetoCinema.Properties.Resources.chocolate;
            this.btn_doce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doce.Location = new System.Drawing.Point(44, 234);
            this.btn_doce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_doce.Name = "btn_doce";
            this.btn_doce.Size = new System.Drawing.Size(56, 73);
            this.btn_doce.TabIndex = 1;
            this.btn_doce.UseVisualStyleBackColor = true;
            // 
            // btn_pipoca
            // 
            this.btn_pipoca.BackgroundImage = global::ProjetoCinema.Properties.Resources.popcorn;
            this.btn_pipoca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pipoca.Location = new System.Drawing.Point(44, 18);
            this.btn_pipoca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_pipoca.Name = "btn_pipoca";
            this.btn_pipoca.Size = new System.Drawing.Size(56, 64);
            this.btn_pipoca.TabIndex = 0;
            this.btn_pipoca.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(82, 7);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(182, 31);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Field Snacks";
            // 
            // FormComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 440);
            this.Controls.Add(this.pnTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(360, 479);
            this.MinimumSize = new System.Drawing.Size(360, 479);
            this.Name = "FormComida";
            this.Text = "Lanches";
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_bebida;
        private System.Windows.Forms.Button btn_doce;
        private System.Windows.Forms.Button btn_pipoca;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    }
}