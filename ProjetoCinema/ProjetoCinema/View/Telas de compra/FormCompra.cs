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




namespace ProjetoCinema.View
{
    public partial class FormCompra : Form
    {
        List<Filme> data = new List<Filme>();

        public FormCompra()
        {

            InitializeComponent();
            pnSessões.Visible = false;
            LoadDatabase();
            Fill("");
            dgvFilmes.CurrentCell = dgvFilmes.Rows[0].Cells[0];

        }
       private void LoadDatabase()
        {
            FilmeDAO DAO = new FilmeDAO();
            data = DAO.ListAll();
            
        }
        private void Fill(string filter)
        {
            dgvFilmes.Rows.Clear();
            foreach (Filme a in data)
                dgvFilmes.Rows.Add(a.Nome, a.Duracao, a.Genero);
        }
        private void Fill(Filme f)
        {
            dgvSessoes.Rows.Clear();
            List<Sessão> s = f.listSessao();
            foreach (Sessão a in s)
                dgvSessoes.Rows.Add(a.Filme.Nome,a.Sala.Id,a.Horario,a.LugaresDisponiveis);
        }
        public Filme GetFilme()
        {
            
            FilmeDAO DAO = new FilmeDAO();
            Filme f = DAO.FindByName(dgvFilmes.CurrentRow.Cells[0].Value.ToString());
            return f;
        }
        private void FillList(Filme f)
        {
            SessaoDAO DAO = new SessaoDAO();
            List<Sessão> sessoes = DAO.FindByFilme(f.Id);
            foreach (Sessão s in sessoes)
            {
                f.AddSessao(s);

            }
        }
        private void CleanList(Filme f)
        {
            SessaoDAO DAO = new SessaoDAO();
            List<Sessão> sessoes = DAO.FindByFilme(f.Id);
            foreach (Sessão s in sessoes)
            {
                f.RmvSessao(s);

            }
        }
       
        private void btnNext_Click(object sender, EventArgs e)
         {
           
         }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            pnSessões.Visible = true;
            pnFilmes.Visible = false;
            Filme f = GetFilme();
            FillList(f);
            Fill(f);
            
           
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pnSessões.Visible = false;
            pnFilmes.Visible = true;
            Filme f = GetFilme();
            CleanList(f);
            Fill("");
        }

        private void btnCancelarF_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
