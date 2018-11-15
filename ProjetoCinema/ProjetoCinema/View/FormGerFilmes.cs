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
    public partial class FormGerFilmes : Form
    {
        private bool salvar=true;
        private bool editavel = false;
        private FilmeDAO DAO = new FilmeDAO();

        public FormGerFilmes()
        {
            InitializeComponent();
        }
        public FormGerFilmes(bool editavel,Filme f)
        {
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();
            txtCodigo.Text = f.Id.ToString();
            txtHoras.Text = f.Duracao;
            txtTitulo.Text = f.Nome;
            cbGenero.Text = f.Genero;
            textBox1.Text = f.Sinopse;
            if(editavel==false)
            {
                txtTitulo.Enabled = false;
                txtCodigo.Enabled = false;
                cbGenero.Enabled = false;
                txtHoras.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Filme f = new Filme();
            f.Id = int.Parse(txtCodigo.Text);
            f.Nome = txtTitulo.Text;
            f.Genero = cbGenero.Text;
            f.Sinopse = textBox1.Text;
            f.Duracao = txtHoras.Text;
            if(salvar)
            {
                DAO.Create(f);
                Dispose();
            }
            if(editavel)
            {
                DAO.Update(f);
                Dispose();
            }
            if(!salvar&&!editavel)
            {
                Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormGerFilmes_Load(object sender, EventArgs e)
        {

        }
    }
}
