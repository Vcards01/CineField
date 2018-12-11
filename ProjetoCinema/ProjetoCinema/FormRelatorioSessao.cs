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
    public partial class FormRelatorioSessao : Form
    {
        public FormRelatorioSessao()
        {
            InitializeComponent();
        }

        private void FormRelatorioSessao_Load(object sender, EventArgs e)
        {
            SessaoDAO dao = new SessaoDAO();
            List<Sessão> list = dao.ListAll();
            RelatorioSessões report = new RelatorioSessões();
            report.SetDataSource(list);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
