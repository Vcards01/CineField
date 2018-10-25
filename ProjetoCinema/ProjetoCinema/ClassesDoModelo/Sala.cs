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
        private Dictionary<int, Sessao> Sessões = new Dictionary<int, Sessao>();
    }
}
