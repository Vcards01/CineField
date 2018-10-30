using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCinema
{
    public partial class FormLogin : Form
    {
                
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.ToUpper()=="USER"&&txtPassword.Text=="user")
            {
                Form1 form = new Form1(1);
                form.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                form.ShowDialog(this);
            }
            if (txtUsername.Text.ToUpper() == "ADMIN" && txtPassword.Text == "admin")
            {
                Form1 form = new Form1();
                form.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                form.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Por favor digite um usuario e senha validos", "Senha ou Usuario incoreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
