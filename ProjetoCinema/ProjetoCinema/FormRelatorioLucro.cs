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
using ProjetoCinema.Model;

namespace ProjetoCinema
{
    public partial class FormRelatorioLucro : Form
    {
        public FormRelatorioLucro()
        {
            InitializeComponent();
        }

        private void FormRelatorioLucro_Load(object sender, EventArgs e)
        {
            CaixaDAO dao = new CaixaDAO();
            List<Caixa> list = dao.ListAll();
            RelatorioLucro report = new RelatorioLucro();
            report.SetDataSource(list);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
