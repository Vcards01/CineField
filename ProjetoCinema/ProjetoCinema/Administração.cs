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

        

        private void btnGerFilme_Click(object sender, EventArgs e)
        {
            FormAdmFilmes form = new FormAdmFilmes();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnGerSala_Click(object sender, EventArgs e)
        {
            FormAdmSalas form = new FormAdmSalas();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnGerSessões_Click(object sender, EventArgs e)
        {
            FormAdmSessao form = new FormAdmSessao();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnGerLoja_Click(object sender, EventArgs e)
        {
            FormAdmLoja form = new FormAdmLoja();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnGerFuncionarios_Click(object sender, EventArgs e)
        {
            FormAdmFuncionario form = new FormAdmFuncionario();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
