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
        private DateTime Duração;
        Dictionary<int, Sessão> sessoes = new Dictionary<int, Sessão>();

        public void AddSessao(Sessão s)
        {
            sessoes.Add(s.Id, s);
        }
        public void RmvSessao(Sessão s)
        {
            sessoes.Remove(s.Id);
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

        public DateTime Duração1
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
    }
}
