using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Model
{
   public class Caixa
    {
        private int id;
        private String data;
        private double valorInicial;
        private double lucro;
        private double valorAtual;

        public Caixa(String data, double valorInicial, double lucro, double valorAtual)
        {
            this.data = data;
            this.valorInicial = valorInicial;
            this.lucro = lucro;
            this.valorAtual = valorAtual; 

        }
        public Caixa()
        {

        }
        public void AbrirCaixa(float inicial)
        {
            ValorInicial=inicial;
            Lucro = 0;
            ValorAtual = inicial + Lucro;
            Data = DateTime.Now.ToShortDateString();

        }
        public void RetirarValor(double valor)
        {
            ValorAtual -= valor;
           
        }
        public void AddValor(double valor)
        {
            ValorAtual += valor;
            Lucro= valorAtual - ValorInicial;
        }
        public void FecharCaixa()
        {
            Lucro = valorAtual - ValorInicial;
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

        public double ValorInicial
        {
            get
            {
                return valorInicial;
            }

            set
            {
                valorInicial = value;
            }
        }

        public double Lucro
        {
            get
            {
                return lucro;
            }

            set
            {
                lucro = value;
            }
        }

        public double ValorAtual
        {
            get
            {
                return valorAtual;
            }

            set
            {
                valorAtual = value;
            }
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
