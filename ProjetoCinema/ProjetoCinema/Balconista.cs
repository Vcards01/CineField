using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Balconista : Funcionario
    {
        private List<Venda> vendas = new List<Venda>();
        public Balconista(string nome, long cpf, int idade, string sexo) : base(nome, cpf, idade, sexo)
        {
        }
        public int QtddVendas()
        {
            return vendas.Count;
        }
    }
}
