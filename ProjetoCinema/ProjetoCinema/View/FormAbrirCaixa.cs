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
            CaixaDAO dao = new CaixaDAO();
            Caixa c = dao.FindbyDate(DateTime.Now.ToShortDateString());
            if(c!=null)
            {
                txtInicial.Visible = false;
                lbAberto.Visible = true;
            }
            
        }
        

        private void FormAbrirCaixa_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            CaixaDAO dao = new CaixaDAO();
            Caixa c = dao.FindbyDate(DateTime.Now.ToShortDateString());
            if(c==null)
            {
                Caixa x = new Caixa();
                x.AbrirCaixa(float.Parse(txtInicial.Text)/100);
                dao.Create(x);
                MessageBox.Show("Caixa aberto com sucesso", "Caixa aberto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reabrindo caixa", "Ja existe um caixa para o dia de hoje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
            Dispose();
        }
    }
}
