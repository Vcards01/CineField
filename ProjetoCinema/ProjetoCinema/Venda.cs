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
        private List<Item> itens = new List<Item>();

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
