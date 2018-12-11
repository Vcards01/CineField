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
    public partial class FormGerLoja : Form
    {
        private bool salvar = true;
        private bool editavel;
        private ProdutosDAO DAO = new ProdutosDAO();
        public FormGerLoja()
        {
            InitializeComponent();
        }

        public FormGerLoja(bool editavel, Produtos p)
        {
           
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();
            txtID.Text = p.Id.ToString();
            txtNome.Text = p.Nome;
            txtTipo.Text = p.Tipo;
            Console.WriteLine(p.Preco);
            if(100 > p.Preco)
            {
                txtPreço.Text = "00"+ p.Preco.ToString();
            }
            else if (1000 > p.Preco)
            {
                txtPreço.Text = "0" + p.Preco.ToString();
            }
            else
            {
                txtPreço.Text = p.Preco.ToString();
            }
            
            if (editavel == false)
            {
                txtNome.Enabled = false;
                txtPreço.Enabled = false;
                txtTipo.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtNome.Text)) || string.IsNullOrEmpty(txtPreço.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, não deixe nenhum campo em branco", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtPreço.Text) <= 0)
            {
                MessageBox.Show("Por favor,digite um valor maior que 0", "Preço invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Produtos p = new Produtos();

                p.Nome = txtNome.Text;
                p.Tipo = txtTipo.Text;
                p.Preco = double.Parse(txtPreço.Text);
                if (salvar)
                {
                    DAO.Create(p);
                    Dispose();
                }
                if (editavel)
                {
                    p.Id = int.Parse(txtID.Text);
                    DAO.Update(p);
                    Dispose();

                }

            }
            if (!salvar && !editavel)
            {
                Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormGerLoja_Load(object sender, EventArgs e)
        {

        }
    }
}
