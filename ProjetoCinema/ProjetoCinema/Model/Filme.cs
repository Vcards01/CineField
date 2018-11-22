using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    public class Filme
    {
        private int id;
        private string nome;
        private string genero;
        private string sinopse;
        private string duracao;
        private List<Sessão> sessoes = new List<Sessão>();

        
        public Filme()
        {

        }

        public Filme(int id, string nome, string genero, string sinopse, string duracao)
        {
            this.id = id;
            this.nome = nome;
            this.genero = genero;
            this.sinopse = sinopse;
            this.duracao = duracao;
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
    }
}
