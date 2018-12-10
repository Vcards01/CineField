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
        private Sessão s;

        public Ingresso(int id, Sessão s)
        {
            this.id = id;
            this.s = s;
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

        public Sessão S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }
    }
}
