using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCinema;
using ProjetoCinema.BD;

namespace ProjetoCinema
{
    public partial class FormAdmFilmes : Form
    {
        List<Filme> data = new List<Filme>();
        private FilmeDAO DAO = new FilmeDAO();
        public FormAdmFilmes()
        {
            InitializeComponent();
            LoadDatabase();
            Fill("");
        }
        private void LoadDatabase()
        {
            data = DAO.ListAll();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormGerFilmes form = new FormGerFilmes();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Filme f = DAO.Read(int.Parse(dgvFilmes.CurrentRow.Cells[0].Value.ToString()));
            FormGerFilmes form = new FormGerFilmes(true,f);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Filme f = DAO.Read(int.Parse(dgvFilmes.CurrentRow.Cells[0].Value.ToString()));
            FormGerFilmes form = new FormGerFilmes(false,f);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
        private void Fill(string filter)
        {
           dgvFilmes.Rows.Clear();
            foreach (Filme a in data)

                if (filter == "" ||a.Nome.ToUpper().Contains(filter.ToUpper()) || a.Genero.ToUpper().Contains(filter.ToUpper()))
                    dgvFilmes.Rows.Add(a.Id,a.Nome,a.Genero,a.Duracao);

        }
        private void FormAdmFilmes_Load(object sender, EventArgs e)
        {
            Fill("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Filme f = DAO.Read(int.Parse(dgvFilmes.CurrentRow.Cells[0].Value.ToString()));
            DAO.Delete(f.Id);
            LoadDatabase();
            Fill("");
        }
    }
}
