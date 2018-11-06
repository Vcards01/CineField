using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Balconista : Funcionario
    {
        
        public Balconista(string nome, long cpf, int idade, string senha, string sexo) : base(nome, cpf, idade,senha, sexo)
        {
        }
        
    }
}
