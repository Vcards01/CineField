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
    public partial class Administração : Form
    {
        public Administração()
        {
            InitializeComponent();
        }
        private void AbrirForm(object form)
        {
            if (this.pnFundo.Controls.Count > 0)
            {
                this.pnFundo.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnFundo.Controls.Add(f);
            pnFundo.Tag = f;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            pnFundo.Visible = true;
        }


        private void btnGerFilme_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormAdmFilmes());
            
        }

        private void btnGerSala_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormAdmSalas());
           
        }

        private void btnGerSessões_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormAdmSessao());
        }

        private void btnGerLoja_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormAdmLoja());
        }

       

        private void Administração_Load(object sender, EventArgs e)
        {

        }
    }
}
