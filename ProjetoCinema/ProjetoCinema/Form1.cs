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
        
        private void btnFerramentas_Click(object sender, EventArgs e)
        {

            Administração form = new Administração();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);

        }

        private void btnFilme_Click(object sender, EventArgs e)
        {
            FormEmCartaz filmes = new FormEmCartaz();
            filmes.ShowDialog();
        }

        private void btIngresso_Click(object sender, EventArgs e)
        {
            FormIngressos form = new FormIngressos();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnFilme_MouseEnter(object sender, EventArgs e)
        {
            btnFilme.FlatAppearance.BorderSize = 1;
            btnFilme.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void btnFilme_MouseLeave(object sender, EventArgs e)
        {
            btnFilme.FlatAppearance.BorderSize = 0;
            btnFilme.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void btIngresso_MouseEnter(object sender, EventArgs e)
        {
            btIngresso.FlatAppearance.BorderSize = 1;
            btIngresso.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void btIngresso_MouseLeave(object sender, EventArgs e)
        {
            btIngresso.FlatAppearance.BorderSize = 0;
            btIngresso.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void btnAlimentação_MouseEnter(object sender, EventArgs e)
        {
            btnAlimentação.FlatAppearance.BorderSize = 1;
            btnAlimentação.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void btnAlimentação_MouseLeave(object sender, EventArgs e)
        {
            btnAlimentação.FlatAppearance.BorderSize = 0;
            btnAlimentação.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void btnFerramentas_MouseEnter(object sender, EventArgs e)
        {
            btnFerramentas.FlatAppearance.BorderSize = 1;
            btnFerramentas.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void btnFerramentas_MouseLeave(object sender, EventArgs e)
        {
            btnFerramentas.FlatAppearance.BorderSize = 0;
            btnFerramentas.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void btnAlimentação_Click(object sender, EventArgs e)
        {
            FormComida comida = new FormComida();
            comida.ShowDialog();
        }
    }
}
