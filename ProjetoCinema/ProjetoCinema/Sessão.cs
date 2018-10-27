using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    class Sessão
    {
        private int id;
        private DateTime horario;
        private Filme filme;
        private Sala sala;
        List<Ingresso> ingressos = new List<Ingresso>();

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

        public DateTime Horario
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

        internal Filme Filme
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

        internal Sala Sala
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
    }
}
