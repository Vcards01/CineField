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
    public partial class FormRelatorioVendasTotais : Form
    {
        public FormRelatorioVendasTotais()
        {
            InitializeComponent();
        }

        private void FormRelatorioVendasTotais_Load(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();
            List<Venda> list = dao.ListAll();
            RelatorioDeVendasTotais report = new RelatorioDeVendasTotais();
            report.SetDataSource(list);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
