using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Sala
    {
        private int numeroSala;
        private int Nrlugares;
        private Dictionary<int, Sessao> Sessões = new Dictionary<int, Sessao>();

        public int NumeroSala
        {
            get
            {
                return numeroSala;
            }

            set
            {
                numeroSala = value;
            }
        }

        public int Nrlugares1
        {
            get
            {
                return Nrlugares;
            }

            set
            {
                Nrlugares = value;
            }
        }
    }
}
