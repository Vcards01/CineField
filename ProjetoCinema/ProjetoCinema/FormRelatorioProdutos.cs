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
    public partial class FormRelatorioProdutos : Form
    {
        public FormRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ProdutosDAO dao = new ProdutosDAO();
            List<Produtos> list = dao.ListAll();
            RelatorioProduto report = new RelatorioProduto();
            report.SetDataSource(list);
            crystalReportViewer1.ReportSource = report;

        }
    }
}
