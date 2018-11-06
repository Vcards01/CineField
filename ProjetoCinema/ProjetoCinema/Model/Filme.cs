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
        private string sinopse;
        private DateTime duração;
        private List<Sessão> sessoes = new List<Sessão>();

        public Filme(int id, string nome, string genero, string sinopse, DateTime duração)
        {
            this.id = id;
            this.nome = nome;
            this.genero = genero;
            this.sinopse = sinopse;
            this.duração = duração;
        }
        public Filme()
        {

        }

        public void AddSessao(Sessão s)
        {
            sessoes.Add(s);
        }
        public void RmvSessao(Sessão s)
        {
            sessoes.Remove(s);
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

        public DateTime Duração
        {
            get
            {
                return Duração;
            }

            set
            {
                Duração = value;
            }
        }

        public string Sinopse
        {
            get
            {
                return sinopse;
            }

            set
            {
                sinopse = value;
            }
        }
    }
}
