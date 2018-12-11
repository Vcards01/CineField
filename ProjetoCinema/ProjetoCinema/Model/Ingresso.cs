using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Model
{
   public class Ingresso
    {
        private int id;
        private int sessão;
        private string filme;
        private string sala;
        private string horario;

        public Ingresso(int id, int sessão, string filme, string sala, string horario)
        {
            this.id = id;
            this.sessão = sessão;
            this.filme = filme;
            this.sala = sala;
            this.horario = horario;
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

        public int Sessão
        {
            get
            {
                return sessão;
            }

            set
            {
                sessão = value;
            }
        }

        public string Filme
        {
            get
            {
                return filme;
            }

            set
            {
                filme = value;
            }
        }

        public string Sala
        {
            get
            {
                return sala;
            }

            set
            {
                sala = value;
            }
        }

        public string Horario
        {
            get
            {
                return horario;
            }

            set
            {
                horario = value;
            }
        }
    }
}
