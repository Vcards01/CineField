using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Funcionario
    {
        private string nome;
        private long cpf;
        private int idade;
        private string senha;
        private string sexo;
        List<Venda> vendas = new List<Venda>();

        public void add(Venda v)
        {
            vendas.Add(v);
        }
        public void rmv(Venda v)
        {
            vendas.Remove(v);
        }

        public Funcionario(string nome, long cpf, int idade, string senha, string sexo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.sexo = sexo;
        }
        public Funcionario()
        {

        }
        public int QtddVendas()
        {
            return vendas.Count;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }
        
    }
}
