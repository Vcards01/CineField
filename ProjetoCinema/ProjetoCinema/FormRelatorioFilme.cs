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
    public partial class FormRelatorioFilme : Form
    {
        public FormRelatorioFilme()
        {
            InitializeComponent();
        }

        private void FormRelatorioFilme_Load(object sender, EventArgs e)
        {
            FilmeDAO dao = new FilmeDAO();
            List<Filme> list = dao.ListAll();
            RelatorioFilme report = new RelatorioFilme();
            report.SetDataSource(list);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
