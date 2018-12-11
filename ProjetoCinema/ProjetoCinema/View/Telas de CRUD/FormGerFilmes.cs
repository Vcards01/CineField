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
            txtHoras.Text = f.Duracao.ToString();
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
            if ((string.IsNullOrEmpty(txtTitulo.Text))|| (string.IsNullOrEmpty(cbGenero.Text)))
            {
                MessageBox.Show("Por favor, não deixe nenhum campo em branco", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtHoras.Text=="00:00")
            {
                MessageBox.Show("Por favor,digite uma duração maior que 0", "Duração invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtTitulo.Text is string)
            {
                Filme f = new Filme();
                f.Nome = txtTitulo.Text;
                f.Genero = cbGenero.Text;
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    f.Sinopse = "Sinopse não disponivel";
                }
                else
                {
                    f.Sinopse = textBox1.Text;
                }
                f.Duracao = txtHoras.Text;
                f.QtddVendida = 0;
                if (salvar)
                {
                    DAO.Create(f);
                    Dispose();
                }
                if (editavel)
                {
                    f.Id = int.Parse(txtCodigo.Text);
                    DAO.Update(f);
                    Dispose();
                }
                if (!salvar && !editavel)
                {
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("Por favor, não digite numeros no campo titulo", "Campos inconsistentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
