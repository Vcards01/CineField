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
            DateTime date = DateTime.Now;
            date.ToString();
            this.current_time_lbl.Text = date.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current_time_lbl.Font = new Font("Digital-7", 10, FontStyle.Regular);
            titleLabel.Font = new Font("Magneto", 24, FontStyle.Regular);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnMenu.Width==189 && pnMenu.Height==434)
            {
                pnMenu.Width = 40;
                pnMenu.Height = 434;
            }
            else
            {
                pnMenu.Width = 189;
                pnMenu.Height = 434;
            }
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
    }
}
