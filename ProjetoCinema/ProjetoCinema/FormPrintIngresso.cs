using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCinema
{
    public partial class FormPrintIngresso : Form
    {
        public FormPrintIngresso()
        {
            InitializeComponent();
        }

        private void i_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja comprar algo para comer ou não?", "Encerrar compra?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                FormComida form = new FormComida();
                form.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                form.ShowDialog(this);
            }
            else
            {
                Dispose();
            }
        }
    }
}
