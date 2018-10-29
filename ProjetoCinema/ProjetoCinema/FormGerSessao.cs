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
    public partial class FormGerSessao : Form
    {
        private bool salvar= true;
        private bool editavel;
        public FormGerSessao()
        {
            InitializeComponent();
        }
        public FormGerSessao(bool editavel)
        {
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();
            if (editavel == false)
            {
                cbFilme.Enabled = false;
                cbSala.Enabled = false;
                dtpHorario.Enabled = false;
                
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
