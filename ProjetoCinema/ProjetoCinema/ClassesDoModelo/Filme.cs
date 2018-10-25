using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Filme
    {
        private int id;
        private string nome;
        private string genero;
        private string duracao;
        private Dictionary<int, Sessao> Sessões = new Dictionary<int, Sessao>();
        
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

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string Duracao
        {
            get
            {
                return duracao;
            }

            set
            {
                duracao = value;
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
    }
}
