using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Venda
    {
        
        private double soma;
        private int idVenda;
        private Funcionario f;
        private List<Item> itens = new List<Item>();
        
        public void add(Item i)
        {
            itens.Add(i);
        }
        public void rmv(Item i)
        {
            itens.Remove(i);
        }
        public int IdVenda
        {
            get
            {
                return idVenda;
            }

            set
            {
                idVenda = value;
            }
        }

        internal Funcionario F
        {
            get
            {
                return f;
            }

            set
            {
                f = value;
            }
        }

        public double ValorTotal()
        {
            for(int i=0;i<itens.Count;i++)
            {
                soma = soma + itens[i].Preco;
            }
            return soma;
        }
    }
}
