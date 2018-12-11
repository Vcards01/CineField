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
    public partial class FormAdmSalas : Form
    {
        private SalaDAO DAO = new SalaDAO();
        List<Sala> data = new List<Sala>();
        
        public FormAdmSalas()
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
            dgvSalas.Rows.Clear();
            foreach (Sala a in data)
                if (filter == "")

                    dgvSalas.Rows.Add(a.Id, a.Nome, a.QtddLugares);

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormGerSalas form = new FormGerSalas();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Sala s = DAO.Read((int.Parse(dgvSalas.CurrentRow.Cells[0].Value.ToString())));
            FormGerSalas form = new FormGerSalas(true,s);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDatabase();
            Fill("");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Sala s = DAO.Read((int.Parse(dgvSalas.CurrentRow.Cells[0].Value.ToString())));
            FormGerSalas form = new FormGerSalas(false,s);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Sala s = DAO.Read((int.Parse(dgvSalas.CurrentRow.Cells[0].Value.ToString())));
            SessaoDAO daos = new SessaoDAO();
            List < Sessão > list= daos.FindBySala(s.Id);
            if(list.Count>0)
            {
                MessageBox.Show("Impossivel apagar sala,pois existem sesões em andamento nela", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DAO.Delete(s.Id);
                LoadDatabase();
                Fill("");
            }
            
        }

        private void FormAdmSalas_Load(object sender, EventArgs e)
        {

        }
    }
}
