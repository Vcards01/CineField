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
    public partial class FormAdmFuncionario : Form
    {
        public FormAdmFuncionario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormGerFuncionario form = new FormGerFuncionario();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormGerFuncionario form = new FormGerFuncionario(true);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FormGerFuncionario form = new FormGerFuncionario(false);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
