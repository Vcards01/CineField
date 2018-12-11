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
        
        List<Produtos>comprados= new List<Produtos>();
        List<Produtos> data = new List<Produtos>();
        ProdutosDAO dao = new ProdutosDAO();
        Sessão sessão;
        private Venda v = new Venda();
        private int qtdd = 0;
        private static int count = 1;
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
            Console.WriteLine(s.LugaresDisponiveis);
            txtCodigoSessão.Text = s.Id.ToString();
            txtFilmeNome.Text = s.Filme.Nome;
            txtTotal.Text = 0.ToString("c");
            precoIngreço = s.PrecoEntrada;
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
                  
                    dgvProdutos.Rows.Add(a.Nome, a.Tipo, (a.Preco/100).ToString("c"));
        }
        private void FillCompra()
        {
            dgvCompra.Rows.Clear();
            foreach (Produtos a in comprados)

                dgvCompra.Rows.Add(a.Nome, a.Quantidade);
        }
        //Adiciona ingressos
        private void btnMais_Click(object sender, EventArgs e)
        {
            if(sessão.LugaresDisponiveis>0)
            {
                SessaoDAO DAOs = new SessaoDAO();
                qtdd += 1;
                Quantidade();
                ValorTotal(precoIngreço);
                sessão.LugaresDisponiveis -= 1;
                DAOs.Update(sessão);
                v.AddIngresso(new Ingresso(count, sessão.Id,sessão.Filme.Nome,sessão.Sala.Nome,sessão.Horario));
                count++;
            }
            else
            {
                MessageBox.Show("Sem lugares disponiveis", "Sala cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                     
        }
        //Remove ingressos
        private void btnRmvIngreço_Click(object sender, EventArgs e)
        {
            if(qtdd==0)
            {
                MessageBox.Show("Sem itens no carrinho", "Impossivel Remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (qtdd > 0 )
            {
                qtdd -= 1;
                Quantidade();
                ReduzirTotal(precoIngreço);
            }
           
           
        }
        //Atualiza o valor total da compra
        private void ValorTotal(double valor)
        {
            precoTotal += valor / 100;
            txtTotal.Text = precoTotal.ToString("c");
        }
        //Atualiza o valor total da compra
        private void ReduzirTotal(double valor)
        {
            precoTotal -= valor/100;
            txtTotal.Text = precoTotal.ToString("c");
        }
        //Verifica se produto ja esta no carrinho
        private bool verifica(Produtos p)
        {
            int flag = 0;
            for (int i = 0; i < comprados.Count; i++)
            {
                if (comprados[i].Id == p.Id)
                {
                    flag = 0;
                    comprados[i].Quantidade += 1;
                    ValorTotal(comprados[i].Preco);
                    break;

                }
                else
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Adiciona produtos ao carrinho
        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           string key =dgvProdutos.CurrentRow.Cells[0].Value.ToString();
           Produtos p = dao.FindByName(key);
            if (comprados.Count == 0)
            {
                comprados.Add(p);
                p.Quantidade = 1;
                ValorTotal(p.Preco);
            }
            else
            {

                if (!verifica(p))
                {
                    p.Quantidade = 1;
                    comprados.Add(p);
                    ValorTotal(p.Preco);

                }
               
            }
            FillCompra();

        }
        //Remove produtos do carrinho
        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string key = dgvCompra.CurrentRow.Cells[0].Value.ToString();

            for(int i=0;i<comprados.Count;i++)
            {
                if (comprados[i].Nome == key)
                {
                    if (comprados[i].Quantidade > 1)
                    {
                        comprados[i].Quantidade -= 1;
                        ReduzirTotal(comprados[i].Preco);
                    }
                    else
                    {
                        ReduzirTotal(comprados[i].Preco);
                        comprados.Remove(comprados[i]);
                        
                    }
                }
                FillCompra();
            }
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FilmeDAO DAOF = new FilmeDAO();
            VendaDAO DAOV = new VendaDAO();
            CaixaDAO DaoC = new CaixaDAO();
            SessaoDAO DaoS = new SessaoDAO();
            v.Valor1 = precoTotal*100;
            v.Data = DateTime.Now.ToShortDateString();
            v.Hora = DateTime.Now.ToShortTimeString();
            sessão.Filme.QtddVendida += qtdd;
            sessão.IngressosVendidos1 += qtdd;
            DaoS.updateQI(sessão);
            DAOF.Update(sessão.Filme);
            DAOV.Create(v);
           
            foreach(Produtos p in comprados)
            {
                Produtos x=dao.Read(p.Id);
                x.Quantidade += p.Quantidade;
                dao.UpdateQTd(x);
            }
            Caixa c = DaoC.FindbyDate(DateTime.Now.ToShortDateString());
            c.AddValor(precoTotal);
            DaoC.Update(c);
            if(qtdd>0)
            {
                FormRelatorioIngresso f = new FormRelatorioIngresso(v.GetList());
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog(this);
            }
            
            
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}
