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
    public partial class FormIngressos : Form
    {
        public FormIngressos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReserva form = new FormReserva();
            form.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            form.ShowDialog(this);
        }
    }
}
