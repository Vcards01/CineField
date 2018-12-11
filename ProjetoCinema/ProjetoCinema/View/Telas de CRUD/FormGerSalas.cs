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
                txtNome.ReadOnly = true;
                NmLugares.ReadOnly=true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtNome.Text)))
            {
                MessageBox.Show("Por favor, não deixe nenhum campo em branco", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(NmLugares.Value<=0)
            {
                MessageBox.Show("Por favor,digite uma quantidade de lugares que 0", "Duração invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Sala s = new Sala();
                s.QtddLugares = int.Parse(NmLugares.Value.ToString());
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
            int newValor = 0;
            SessaoDAO dao = new SessaoDAO();
            foreach (Sessão a in s.GetList())
            {
                newValor= a.LugaresDisponiveis - s.QtddLugares;
                Console.WriteLine(newValor);
                if(newValor<0)
                {
                    a.LugaresDisponiveis = newValor * -1;
                }
                else
                {
                    a.LugaresDisponiveis = newValor;
                }
                
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
