using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCinema.Model;

namespace ProjetoCinema
{
    public partial class FormRelatorioIngresso : Form
    {
        List<Ingresso> list;
        public FormRelatorioIngresso()
        {
            InitializeComponent();
        }
        public FormRelatorioIngresso(List<Ingresso>l)
        {
            list = l;
            InitializeComponent();
        }

        private void FormRelatorioIngresso_Load(object sender, EventArgs e)
        {
            
            RelatorioIngresso report = new RelatorioIngresso();
            report.SetDataSource(list);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
