using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCinema.BD;

namespace ProjetoCinema
{
    public partial class FormGerSalas : Form
    {
        private SalaDAO DAO = new SalaDAO();
        private bool salvar = true;
        private bool editavel = false;
        public FormGerSalas()
        {
            InitializeComponent();
        }
        public FormGerSalas(bool editavel,Sala s)
        {
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();
            txtCodigo.Text = s.Id.ToString();
            NmLugares.Value = s.QtddLugares;
            if (editavel == false)
            {
                txtCodigo.Enabled = false;
                NmLugares.Enabled=false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Sala s = new Sala();
            s.QtddLugares=int.Parse(NmLugares.Value.ToString());
            if (salvar)
            {
                DAO.Create(s);
                Dispose();
            }
            if (editavel)
            {
                s.Id = int.Parse(txtCodigo.Text);
                DAO.Update(s);
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
