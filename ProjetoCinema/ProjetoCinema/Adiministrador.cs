using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Adiministrador:Funcionario
    {
        Dictionary<long, Funcionario> Funcionarios = new Dictionary<long, Funcionario>();

        public Adiministrador(string nome, long cpf, int idade, string sexo) : base(nome, cpf, idade, sexo)
        {
            
        }
        public void AddFuncionario(Funcionario f)
        {
            Funcionarios.Add(f.Cpf, f);
        }
        public void RmvFuncionario(long cpf)
        {
            Funcionarios.Remove(cpf);
        }
        
    }
}
