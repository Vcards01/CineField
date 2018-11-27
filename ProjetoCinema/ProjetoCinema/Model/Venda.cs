using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCinema.Model;

namespace ProjetoCinema
{
   public class Venda
    {
        private string hora;
        private string data;
        private double Valor;
        private int idVenda;
        
        
       
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

        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public double Valor1
        {
            get
            {
                return Valor;
            }

            set
            {
                Valor = value;
            }
        }
    }
}
