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
        List<Ingresso> list = new List<Ingresso>();

        public void AddIngresso(Ingresso i)
        {
            list.Add(i);
        }
        public void RmvIngresso(Ingresso i)
        {
            list.Remove(i);
        }
        public List<Ingresso> GetList()
        {
            return list;
        }

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
