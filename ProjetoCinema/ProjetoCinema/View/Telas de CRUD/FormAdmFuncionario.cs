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
using ProjetoCinema;

namespace ProjetoCinema
{
    public partial class FormAdmFuncionario : Form
    {
        List<Funcionario> data = new List<Funcionario>();
        private FuncionarioDAO DAO = new FuncionarioDAO();
        public FormAdmFuncionario()
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
            FormGerFuncionario form = new FormGerFuncionario();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario f = DAO.Read((long.Parse(dgvFuncionario.CurrentRow.Cells[1].Value.ToString())));
            FormGerFuncionario form = new FormGerFuncionario(true,f);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Funcionario f = DAO.Read((long.Parse(dgvFuncionario.CurrentRow.Cells[1].Value.ToString())));
            FormGerFuncionario form = new FormGerFuncionario(false,f);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void Fill(string filter)
        {
            dgvFuncionario.Rows.Clear();
            foreach (Funcionario a in data)

                if (filter == "" || a.Nome.ToUpper().Contains(filter.ToUpper()))
                    dgvFuncionario.Rows.Add(a.Nome, a.Cpf, a.Idade,a.Sexo);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario f = DAO.Read((long.Parse(dgvFuncionario.CurrentRow.Cells[1].Value.ToString())));
            DAO.Delete(f.Cpf);
            LoadDatabase();
            Fill("");
        }
    }
}
