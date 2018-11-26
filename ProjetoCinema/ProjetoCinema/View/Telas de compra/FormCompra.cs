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
        int Flag = 0;
        public FormCompra()
        {

            InitializeComponent();
            pnlugares.Visible = false;
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
                dgvSessoes.Rows.Add(a.Id,a.Filme.Nome,a.Sala.Id,a.Horario,a.LugaresDisponiveis);
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
       private Sessão GetSession()
        {
            dgvSessoes.CurrentCell = dgvFilmes.Rows[0].Cells[0];
            SessaoDAO DAo = new SessaoDAO();
            Sessão s = DAo.Read(int.Parse(dgvSessoes.CurrentRow.Cells[0].Value.ToString()));
            return s;
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
        void ButtonClick(object sender, EventArgs e)
        {
           
            Button currentButton = (Button)sender;
            if (Flag==0)
            {
                currentButton.BackgroundImage = Properties.Resources.armchair__1_;
                currentButton.BackgroundImageLayout = ImageLayout.Stretch;
                Flag = 1;
            }
            else
            {
                currentButton.BackgroundImage = Properties.Resources.armchair__3_;
                currentButton.BackgroundImageLayout = ImageLayout.Stretch;
                Flag = 0;
            }
            
        }
        private Button addButton(int i)
        {
            Button b = new Button();
            b.Name = "Assento" + i.ToString();
            b.BackgroundImage = Properties.Resources.armchair__1_;
            b.BackgroundImageLayout = ImageLayout.Stretch;
            b.Width = 50;
            b.Height = 50;
            b.FlatStyle = FlatStyle.Flat;
            b.Margin = new Padding(5);

            return b;
        }
        private void FormCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnProximoS_Click(object sender, EventArgs e)
        {
            pnlugares.Visible = true;
            pnSessões.Visible = false;
            Sessão s = GetSession();
            for (int i = 0; i < s.LugaresDisponiveis/2; i++)
            {
                Button b = addButton(i);
                pnCadeiras.Controls.Add(b);
                b.Click += new System.EventHandler(this.ButtonClick);

            }
            for (int i = 0; i < s.LugaresDisponiveis / 2; i++)
            {
                Button b = addButton(i);
                pnAssentos2.Controls.Add(b);
                b.Click += new System.EventHandler(this.ButtonClick);

            }
        }
    }
}
