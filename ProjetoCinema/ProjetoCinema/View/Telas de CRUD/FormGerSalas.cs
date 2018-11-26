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
            txtNome.Text = s.Nome;       
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
            s.Nome = txtNome.Text;
            if (salvar)
            {
                DAO.Create(s);
                Dispose();
            }
            if (editavel)
            {
                
                s.Id = int.Parse(txtCodigo.Text);
                DAO.Update(s);
                GetSessao(s);
                updateSessões(s);
                Dispose();
            }
            if (!salvar && !editavel)
            {
                Dispose();
            }
        }
        private void GetSessao(Sala sa)
        {
            SessaoDAO dao = new SessaoDAO();
            List<Sessão> s = dao.FindBySala(sa.Id);
            foreach(Sessão se in s)
            {
                sa.AddSessao(se);
            }

        }
        private void updateSessões(Sala s)
        {
            SessaoDAO dao = new SessaoDAO();
            foreach (Sessão a in s.GetList())
            {
                a.LugaresDisponiveis = s.QtddLugares;
                dao.Update(a);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormGerSalas_Load(object sender, EventArgs e)
        {

        }
    }
}
