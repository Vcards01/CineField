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
            //pnlugares.Visible = false;
            pnSessões.Visible = false;
            LoadDatabase();
            Fill("");
            dgvFilmes.CurrentCell = dgvFilmes.Rows[0].Cells[0];

        }
        //Carrega tds os filmes
       private void LoadDatabase()
        {
            FilmeDAO DAO = new FilmeDAO();
            data = DAO.ListAll();
            
        }
        //Prenche o DataGride de filmes
        private void Fill(string filter)
        {
            dgvFilmes.Rows.Clear();
            foreach (Filme a in data)
                if (filter == "" || a.Nome.ToUpper().Contains(filter.ToUpper()))
                    dgvFilmes.Rows.Add(a.Nome, a.Duracao, a.Genero);
        }
        //Prenche o DataGride de sessões
        private void Fill(Filme f)
        {
            dgvSessoes.Rows.Clear();
            List<Sessão> s = f.listSessao();
            foreach (Sessão a in s)
               
                    dgvSessoes.Rows.Add(a.Id,a.Filme.Nome,a.Sala.Id,a.Horario,a.LugaresDisponiveis);
        }
        //Retorna um Filme para prencher o DataGrid
       public Filme GetFilme()
        {
            
            FilmeDAO DAO = new FilmeDAO();
            Filme f = DAO.FindByName(dgvFilmes.CurrentRow.Cells[0].Value.ToString());
            return f;
        }
        //Preenche a lista de sessões dos filmes
       private void FillList(Filme f)
        {
            SessaoDAO DAO = new SessaoDAO();
            List<Sessão> sessoes = DAO.FindByFilme(f.Id);
            foreach (Sessão s in sessoes)
            {
                f.AddSessao(s);

            }
        }
        //Esvazia a lista de sessões dos filmes
       private void CleanList(Filme f)
        {
            SessaoDAO DAO = new SessaoDAO();
            List<Sessão> sessoes = DAO.FindByFilme(f.Id);
            foreach (Sessão s in sessoes)
            {
                f.RmvSessao(s);

            }
        }
       
       //Abre o painel se sessões e carrega o DataGrid Sessões
       private void btnNext_Click_1(object sender, EventArgs e)
        {
            pnSessões.Visible = true;
            pnFilmes.Visible = false;
            Filme f = GetFilme();
            FillList(f);
            Fill(f);
                              
        }
        //Retorna ao painel de filmes 
       private void btnVoltar_Click(object sender, EventArgs e)
        {
            pnSessões.Visible = false;
            pnFilmes.Visible = true;
            Filme f = GetFilme();
            CleanList(f);
            Fill("");
        }
        //Fecha o Painel de filmes
       private void btnCancelarF_Click(object sender, EventArgs e)
        {
            Dispose();
        }
       
      
       
       private void btnProximoS_Click(object sender, EventArgs e)
        {
            SessaoDAO DAo = new SessaoDAO();
            pnSessões.Visible = false;
            pnFilmes.Visible = true;
            Sessão s = DAo.Read(int.Parse(dgvSessoes.CurrentRow.Cells[0].Value.ToString()));
            VenderIngresso V = new VenderIngresso(s);
            V.StartPosition = FormStartPosition.CenterParent;
            V.ShowDialog(this);
           
        }
        private void FormCompra_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Fill(textBox1.Text);
        }
    }
}
