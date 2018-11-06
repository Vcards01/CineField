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
    public partial class FormAdmFilmes : Form
    {
        public FormAdmFilmes()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormGerFilmes form = new FormGerFilmes();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormGerFilmes form = new FormGerFilmes(true);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FormGerFilmes form = new FormGerFilmes(false);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
