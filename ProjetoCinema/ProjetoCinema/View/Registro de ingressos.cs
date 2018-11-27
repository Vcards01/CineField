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
    public partial class Registro_de_ingressos : Form
    {
        List<Filme> data = new List<Filme>();
        FilmeDAO DAO = new FilmeDAO();
        public Registro_de_ingressos()
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
            foreach (Filme a in data)

                if (filter == "" || a.Nome.ToUpper().Contains(filter))
                    DgvVendas.Rows.Add(a.Id,a.Nome,a.QtddVendida);

        }
        private void Registro_de_ingressos_Load(object sender, EventArgs e)
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
