using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Sessao
    {
        private int numeroSessao;
        private TimeSpan horario;
        private Filme filme;
        private Sala sala;
        public Sessao(Filme f,Sala s)
        {
            filme = f;
            sala = s;
        }

        public int NumeroSessao
        {
            get
            {
                return numeroSessao;
            }

            set
            {
                numeroSessao = value;
            }
        }

        public TimeSpan Horario
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
