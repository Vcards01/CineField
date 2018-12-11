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
    public partial class FormGerSessao : Form
    {
        private SessaoDAO DAO = new SessaoDAO();
        private FilmeDAO DAOf = new FilmeDAO();
        private SalaDAO DAOs = new SalaDAO();
        private bool salvar= true;
        private bool editavel=false;
        public FormGerSessao()
        {
            
            InitializeComponent();
            FillComboBox();
        }
        private void FillComboBox()
        {

            List<Filme> f = DAOf.ListAll();
            List<Sala> s = DAOs.ListAll();
            for (int i=0;i<f.Count;i++)
            {
                cbFilme.Items.Insert(i,f[i].Nome);
            }
            for(int i=0;i<s.Count;i++)
            {
                cbSala.Items.Insert(i, s[i].Nome);
            }
            
        }
        public FormGerSessao(bool editavel,Sessão s)
        {
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();
            FillComboBox();
            TxtCod.Text = s.Id.ToString();
            cbFilme.Text = s.Filme.Nome;
            cbSala.Text = s.Sala.Nome;
            dtpHorario.Text = s.Horario.ToString();
            if(s.PrecoEntrada<100)
            {
                txtPreço.Text = "00"+s.PrecoEntrada.ToString();
            }
            else if (s.PrecoEntrada < 1000)
            {
                txtPreço.Text = "0"+ s.PrecoEntrada.ToString();
            }
            else
            {
                txtPreço.Text = s.PrecoEntrada.ToString();
            }
            txtLugares.Visible = true;
            txtLugares.Text = s.LugaresDisponiveis.ToString();        

            if (editavel == false)
            {
                TxtCod.Enabled = false;
                cbFilme.Enabled = false;
                cbSala.Enabled = false;
                dtpHorario.Enabled = false;
                txtPreço.Enabled = false;
                
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(cbFilme.Text))||string.IsNullOrEmpty(cbSala.Text)||string.IsNullOrEmpty(txtPreço.Text))
            {
                MessageBox.Show("Por favor, não deixe nenhum campo em branco", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(double.Parse(txtPreço.Text)<=0)
            {
                MessageBox.Show("Por favor,digite um valor maior que 0", "Preço invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dtpHorario.Text== "00: 00")
            {
                MessageBox.Show("Por favor,digite um horario maior que 0", "Horario invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Sessão s = new Sessão();
                s.Filme = DAOf.FindByName(cbFilme.Text);
                s.Sala = DAOs.FindByName(cbSala.Text);
                s.Horario = dtpHorario.Text;
                s.PrecoEntrada = (float.Parse(txtPreço.Text));


                if (salvar)
                {
                    s.LugaresDisponiveis = s.Sala.QtddLugares;
                    DAO.Create(s);
                    Dispose();
                }
                if (editavel)
                {
                    s.LugaresDisponiveis = int.Parse(txtLugares.Text);
                    s.Filme.RmvSessao(s);
                    s.Id = int.Parse(TxtCod.Text);
                    DAO.Update(s);
                    s.Filme.AddSessao(s);
                    Dispose();
                }
                if (!salvar && !editavel)
                {
                    Dispose();
                }
            }
            
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormGerSessao_Load(object sender, EventArgs e)
        {

        }
    }
}
