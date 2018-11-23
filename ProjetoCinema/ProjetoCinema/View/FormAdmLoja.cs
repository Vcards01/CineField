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
    public partial class FormAdmLoja : Form
    {
        List<Produtos> data = new List<Produtos>();
        private ProdutosDAO DAO = new ProdutosDAO();
        public FormAdmLoja()
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
            FormGerLoja form = new FormGerLoja();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produtos p = DAO.Read(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
            FormGerLoja form = new FormGerLoja(true,p);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Produtos p = DAO.Read(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
            FormGerLoja form = new FormGerLoja(false, p);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produtos p = DAO.Read(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
            DAO.Delete(p.Nome);
        }
        private void Fill(string filter)
        {
            dgvProdutos.Rows.Clear();
            foreach (Produtos a in data)

                if (filter == "" || a.Nome.ToUpper().Contains(filter.ToUpper()) || a.Tipo.ToUpper().Contains(filter.ToUpper()))
                    dgvProdutos.Rows.Add(a.Nome, a.Tipo,(a.Preco/100).ToString("c"));
        }
        private void FormAdmLoja_Load(object sender, EventArgs e)
        {
            Fill("");
        }
    }
}
