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
    public partial class FormGerFuncionario : Form
    {
        private bool salvar = true;
        private bool editavel;
        FuncionarioDAO DAO = new FuncionarioDAO();
        
        public FormGerFuncionario()
        {
            InitializeComponent();
        }

        public FormGerFuncionario(bool editavel, Funcionario f)
        {
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();

            txtNome.Text = f.Nome;
            txtCPF.Text = f.Cpf.ToString();
            txtIdade.Text = f.Idade.ToString();
            txtSenha.Text = f.Senha;
            if (f.Sexo == "Masculino")
            {
                rbMasculino.Checked=true;
            }
            if(f.Sexo == "Feminino")
            {
                rbFeminino.Checked = true;
            }
            if(f.Sexo == "Outro")
            {
                rbOutro.Checked = true;
            }

            if (editavel == false)
            {
                txtNome.Enabled = false;
                txtIdade.Enabled = false;
                txtCPF.Enabled = false;
                rbFeminino.Enabled = false;
                rbMasculino.Enabled = false;
                rbOutro.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();

            f.Nome = txtNome.Text;
            f.Cpf = long.Parse(txtCPF.Text);
            f.Idade = int.Parse(txtIdade.Text);
            f.Senha = txtSenha.Text;
            if (rbMasculino.Checked == true)
            {
                f.Sexo = "Masculino";
            }
            if (rbFeminino.Checked == true)
            {
                f.Sexo = "Feminino";
            }
            if (rbOutro.Checked == true)
            {
                f.Sexo = "Outro";
            }

            if (salvar)
            {
                DAO.Create(f);
                Dispose();
            }
            if (editavel)
            {
                f.Cpf = long.Parse(txtCPF.Text);
                DAO.Update(f);
                Dispose();
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

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
