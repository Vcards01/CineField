using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCinema;
using ProjetoCinema.Model;

namespace ProjetoCinema.BD
{
    public partial class VenderIngresso : Form
    {
        List<Produtos> data = new List<Produtos>();
        ProdutosDAO dao = new ProdutosDAO();
        Sessão sessão;
        private Venda v = new Venda();
        private int qtdd = 0;
        private int qtddp = 0;
        private double precoIngreço;
        private double precoTotal;

        //Construtor Padrão
        public VenderIngresso()
        {
            InitializeComponent();
        }
        //Construtor que recebe uma sessão
        public VenderIngresso(Sessão s)
        {
            InitializeComponent();
            sessão = s;
            txtCodigoSessão.Text = s.Id.ToString();
            txtFilmeNome.Text = s.Filme.Nome;
            txtTotal.Text = 0.ToString("c");
            precoIngreço = s.PrecoInteira/100;
            Quantidade();
            LoadDataBase();
            Fill();
        }
        private void VenderIngresso_Load(object sender, EventArgs e)
        {

        }
        //Set a quantidade de ingressos
        private void Quantidade()
        {
            txtQuantidade.Text = qtdd.ToString();
        }
        //Carrega todos os produtos para um lista
        private void LoadDataBase()
        {
            data = dao.ListAll();
        }
        //Preenche o Data Grid com os produtos
        private void Fill()
        {
            dgvProdutos.Rows.Clear();
            foreach (Produtos a in data)
                  
                    dgvProdutos.Rows.Add(a.Nome, a.Tipo, (a.Preco / 100).ToString("c"),qtddp);
        }
        //Adiciona ingressos
        private void btnMais_Click(object sender, EventArgs e)
        {
            SessaoDAO DAOs = new SessaoDAO();
            qtdd += 1;
            Quantidade();
            ValorTotal(precoIngreço);
            sessão.LugaresDisponiveis -= 1;
            DAOs.Update(sessão);
                     
        }
        //Remove ingressos
        private void btnRmvIngreço_Click(object sender, EventArgs e)
        {
            qtdd -= 1;
            Quantidade();
            ReduzirTotal(precoIngreço);
        }
        //Atualiza o valor total da compra
        private void ValorTotal(double valor)
        {
            precoTotal += valor;
            txtTotal.Text = precoTotal.ToString("c");
        }
        //Atualiza o valor total da compra
        private void ReduzirTotal(double valor)
        {
            precoTotal -= valor;
            txtTotal.Text = precoTotal.ToString("c");
        }
        //Adiciona produtos ao carrinho
        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string key =dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            Produtos p = dao.FindByName(key);
            List<Produtos> data = dao.ListAll();
            for (int i = 0; i < data.Count; i++)
            {
                if (p.Id == data[i].Id)
                {
                    ValorTotal(p.Preco / 100);
                    qtddp += 1;
                    Fill();
                }

            }
            

        }
        //Remove produtos do carrinho
        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            string key = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            Produtos p = dao.FindByName(key);
            for (int i = 0; i < data.Count; i++)
            {
                if (p.Id == data[i].Id)
                {
                    ReduzirTotal(p.Preco / 100);
                    qtddp -= 1;
                    Fill();
                }

            }
           
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            VendaDAO DAOV = new VendaDAO();
            Venda v = new Venda();
            v.Valor1 = precoTotal;
            v.Data = DateTime.Now.ToShortDateString();
            v.Hora = DateTime.Now.ToShortTimeString();
            DAOV.Create(v);
            Dispose();
        }
    }
}
