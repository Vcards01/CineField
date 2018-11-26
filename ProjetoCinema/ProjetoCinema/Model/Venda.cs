using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
   public class Venda
    {
        
        private double soma;
        private int idVenda;
        private Funcionario f;
        
        
       
        public int IdVenda
        {
            get
            {
                return idVenda;
            }

            set
            {
                idVenda = value;
            }
        }

        internal Funcionario F
        {
            get
            {
                return f;
            }

            set
            {
                f = value;
            }
        }

        
    }
}
