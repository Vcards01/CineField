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
    public partial class FormEmCartaz : Form
    {
        List<Filme> data = new List<Filme>();
        private FilmeDAO DAO = new FilmeDAO();

        public FormEmCartaz()
        {
            InitializeComponent();
            LoadDatabase();
        }
        private void LoadDatabase()
        {
            data = DAO.ListAll();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormIngressos ing = new FormIngressos();
            ing.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            ing.ShowDialog();
        }

        private void FormEmCartaz_Load(object sender, EventArgs e)
        {
            Fill("");
        }
        private void Fill(string filter)
        {
            
        }
    }
}
