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
    public partial class FormGerSessao : Form
    {
        private SessaoDAO DAO = new SessaoDAO();
        private FilmeDAO DAOf = new FilmeDAO();
        private SalaDAO DAOs = new SalaDAO();
        private bool salvar= true;
        private bool editavel;
        public FormGerSessao()
        {
            
            InitializeComponent();
        }
        private void FillComboBox()
        {
            
            cbFilme.DataSource = DAOs.ListAll();
            cbSala.DataSource = DAOf.ListAll();
        }
        public FormGerSessao(bool editavel,Sessão s)
        {
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();
            TxtCod.Text = s.Id.ToString();
            cbFilme.Text = s.Filme.Nome;
            cbSala.Text = s.Sala.Nome;
            dtpHorario.Text = s.Horario.ToShortTimeString();
            NmLugares.Value = s.LugaresDisponiveis;
            if (editavel == false)
            {
                TxtCod.Enabled = false;
                cbFilme.Enabled = false;
                cbSala.Enabled = false;
                dtpHorario.Enabled = false;
                dtpHorario.Enabled = false;
                NmLugares.Enabled = false;
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Sessão s;
            
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
