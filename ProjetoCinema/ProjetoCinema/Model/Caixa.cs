using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Model
{
    class Caixa
    {
        private DateTime data;
        private float valorInicial;
        private float lucro;
        private float valorAtual;

        public Caixa(DateTime data, float valorInicial, float lucro, float valorAtual)
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

        }
        public float RetirarValor(float valor)
        {
            ValorAtual -= valor;
            return valorAtual;
        }
        public void FecharCaixa()
        {
            
        }

        public DateTime Data
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

        public float ValorInicial
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

        public float Lucro
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

        public float ValorAtual
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
    }
}
