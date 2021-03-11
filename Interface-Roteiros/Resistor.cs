using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Roteiros
{
    public class Resistor
    {
        private double _corrente;
        private double _potencia;
        private double _tensao;
        public int Resistencia { get; set; }
        public double Tensao
        {
            get
            {
                CalcularTensao();
                return _tensao;
            }
            set => _tensao = value;
        }
        public double Corrente
        {
            get { return _corrente; }
            set { _corrente = value; }
        }
        public double Potencia
        {
            get { return _potencia; }
            set { _potencia = value; }
        }

        public Resistor(int resistencia)
        {
            this.Resistencia = resistencia;
        }

        public void CalcularTensao()
        {
            if (Corrente != 0)
            {
                _tensao = Potencia / Corrente;
            }
            else if (Resistencia != 0)
            {
                _tensao = Math.Sqrt(Potencia * Resistencia);
            }
        }

        public void CalcularCorrente()
        {
            // U = R*i
            if (Tensao != 0 && Resistencia != 0)
            {
                _corrente = Tensao / Resistencia;
            }
            // P = U*i
            else if (Potencia != 0 && Tensao != 0)
            {
                _corrente = Potencia / Tensao;
            }
            // P = R*i²
            else if (Potencia != 0 && Resistencia != 0)
            {
                _corrente = Math.Sqrt(Potencia / Resistencia);
            }
        }

        public void CalcularPotencia()
        {
            // P = U*i
            if (Tensao != 0 && Corrente != 0)
            {
                _potencia = Tensao * Corrente;
            }
            // P = R.i²
            else if (Resistencia != 0 && Corrente != 0)
            {
                _potencia = Resistencia * Math.Pow(Corrente, 2);
            }
            // P = U²/R
            else if (Tensao != 0 && Resistencia != 0 && Resistencia != 0)
            {
                _potencia = Math.Pow(Tensao, 2) / Resistencia;
            }
        }
    }
}
