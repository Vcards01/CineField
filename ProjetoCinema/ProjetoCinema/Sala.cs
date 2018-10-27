using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Sala
    {
        private int id;
        private int qtddLugares;
        Dictionary<int, Sessão> sessoes = new Dictionary<int, Sessão>();

        public int QtddLugares
        {
            get
            {
                return qtddLugares;
            }

            set
            {
                qtddLugares = value;
            }
        }

        public void AddSessao(Sessão s)
        {
            sessoes.Add(s.Id, s);
        }
        public void RmvSessao(int id)
        {
            sessoes.Remove(Id);
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
