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
            current_time_lbl.Font = new Font("Digital-7", 24, FontStyle.Regular);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnMenu.Width==189 && pnMenu.Height==396)
            {
                pnMenu.Width = 40;
                pnMenu.Height = 396;
            }
            else
            {
                pnMenu.Width = 189;
                pnMenu.Height = 396;
            }
        }
    }
}
