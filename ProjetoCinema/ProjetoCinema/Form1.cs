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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdata.Text = DateTime.Now.ToShortDateString();
            lbHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Configurações config = new Configurações();
            config.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sessoes ses = new Sessoes();
            ses.ShowDialog();
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
