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

namespace ProjetoCinema.View
{
    public partial class RegistroDeVendas : Form
    {
        List<Venda> data = new List<Venda>();
        VendaDAO DAO = new VendaDAO();
        public RegistroDeVendas()
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
           DgvVendas.Rows.Clear();
            foreach (Venda a in data)

                if (filter == "" || a.Data.Contains(filter))
                    DgvVendas.Rows.Add(a.IdVenda,a.Data,a.Hora,a.Valor1.ToString("c"));

        }
        private void RegistroDeVendas_Load(object sender, EventArgs e)
        {

        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            Fill(txtBusca.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
