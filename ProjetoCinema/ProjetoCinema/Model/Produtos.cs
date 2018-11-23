using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    public class Produtos
    {
        private int id;
        private string nome;
        private string tipo;
        private double preco;
        List<Venda> vendas = new List<Venda>();

        public Produtos()
        {

        }

        public void add(Venda v)
        {
            vendas.Add(v);
        }
        public void rmv(Venda v)
        {
            vendas.Remove(v);
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

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Produtos(string nome, string tipo, double preco)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
        }

    }
}
