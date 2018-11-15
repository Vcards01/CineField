using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    public class Item
    {
        private double preco;
        List<Venda> vendas = new List<Venda>();

        public void add(Venda v)
        {
            vendas.Add(v);
        }
        public void rmv(Venda v)
        {
            vendas.Remove(v);
        }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }
    }
}
