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
    public partial class FormAdmLoja : Form
    {
        public FormAdmLoja()
        {
            InitializeComponent();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormGerLoja form = new FormGerLoja();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormGerLoja form = new FormGerLoja(true);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FormGerLoja form = new FormGerLoja(false);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
