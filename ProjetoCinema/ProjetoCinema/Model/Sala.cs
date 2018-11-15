using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    public class Sala
    {
        private int id;
        private int qtddLugares=30;
        private List<Sessão> sessoes = new List<Sessão>();

        public Sala(int id, int qtddLugares)
        {
            this.id = id;
            this.qtddLugares = qtddLugares;
        }
        public Sala()
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
    }
}
