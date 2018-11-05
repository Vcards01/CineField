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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        public Form1(int flag)
        { 
            InitializeComponent();
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString().ToUpper()+" |";
            lbHoras.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo fechar o sistema?", "Encerrar o programa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                this.Close();
            }
            
            
            
        }

        private void btnFilme_Click(object sender, EventArgs e)
        {
            FormEmCartaz child = new FormEmCartaz();
            child.MdiParent = this;
            child.Show();
        }
    }
}
