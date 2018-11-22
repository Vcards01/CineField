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
    public partial class FormAdmSessao : Form
    {
        SessaoDAO DAO = new SessaoDAO();
        List<Sessão> data = new List<Sessão>();
        public FormAdmSessao()
        {
            InitializeComponent();
            LoadDatabase();
            Fill("");
        }
        private void LoadDatabase()
        {
            data = DAO.ListAll();
            
        }
        private void Fill(string filter)
        {
            dgvSessao.Rows.Clear();
            foreach (Sessão a in data)
                if (filter == "")
                    dgvSessao.Rows.Add(a.Filme.Nome,a.Sala.Nome,a.Horario,a.LugaresDisponiveis);

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormGerSessao form = new FormGerSessao();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Sessão s;
            FormGerSessao form = new FormGerSessao();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FormGerSessao form = new FormGerSessao();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmSessao_Load(object sender, EventArgs e)
        {

        }
    }
}
