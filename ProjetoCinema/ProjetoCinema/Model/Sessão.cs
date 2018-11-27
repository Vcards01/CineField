using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
   public class Sessão
    {
        private int id;
        private DateTime horario;
        private Filme filme;
        private Sala sala;
        private int lugaresdisponiveis;
        private float precoInteira;
        private float precoMeia;
        

        public Sessão(int id, DateTime horario, Filme filme, Sala sala)
        {
            this.id = id;
            this.horario = horario;
            this.filme = filme;
            this.sala = sala;
        }
        public Sessão()
        {

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

        public int LugaresDisponiveis
        {
            get
            {
                return lugaresdisponiveis;
            }

            set
            {
                lugaresdisponiveis = value;
            }
        }

        public float PrecoInteira
        {
            get
            {
                return precoInteira;
            }

            set
            {
                precoInteira = value;
            }
        }

        public float PrecoMeia
        {
            get
            {
                return precoMeia;
            }

            set
            {
                precoMeia = value;
            }
        }
    }
}
