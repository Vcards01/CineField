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
using ProjetoCinema.BD;

namespace ProjetoCinema.View
{
    public partial class FormAbrirCaixa : Form
    {
        public FormAbrirCaixa()
        {
            InitializeComponent();
        }
        

        private void FormAbrirCaixa_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            CaixaDAO DAO = new CaixaDAO();
            Caixa x = new Caixa();
            x.AbrirCaixa(float.Parse(txtInicial.Text));
            DAO.Create(x);
            Dispose();
        }
    }
}
