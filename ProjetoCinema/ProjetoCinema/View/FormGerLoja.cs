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
    public partial class FormGerLoja : Form
    {
        private bool salvar = true;
        private bool editavel;
        public FormGerLoja()
        {
            InitializeComponent();
        }

        public FormGerLoja(bool editavel)
        {
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();
            if (editavel == false)
            {
                txtNome.Enabled = false;
                txtPreço.Enabled = false;
                txtTipo.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (salvar)
            {
                Dispose();
            }
            if (editavel)
            {
                Dispose();
            }
            if (!salvar && !editavel)
            {
                Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
