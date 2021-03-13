using System;

namespace Interface_Roteiros
{
    public class Resistor
    {
        // Campos privados
        private double _corrente;
        private double _potencia;
        private double _tensao;

        // Propriedades
        public int Resistencia { get; set; }
        public double Tensao
        {
            get => _tensao;
            set => _tensao = value;
        }
        public double Corrente
        {
            get => _corrente;
            set => _corrente = value;
        }
        public double Potencia
        {
            get => _potencia;
            set => _potencia = value;
        }

        // Métodos
        public Resistor(int resistencia)
        {
            this.Resistencia = resistencia;
        }

        public void CalcularTensao()
        {
            if (Corrente != 0)
            {
                _tensao = Resistencia * Corrente;
            }
            else
            {
                _tensao = Math.Sqrt(Potencia * Resistencia);
            }
            
        }

        public void CalcularCorrente()
        {
            // U = R*i
            if (Resistencia != 0)
            {
                _corrente = Tensao / Resistencia;
            }
            // P = U*i
            else
            {
                _corrente = Potencia / Tensao;
            }
            // P = R*i²
            /*
            else if (Potencia != 0 && Resistencia != 0)
            {
                _corrente = Math.Sqrt(Potencia / Resistencia);
            }
            */
        }

        public void CalcularPotencia()
        {
            // P = U²/R
            if (Tensao != 0 && Resistencia != 0 && Resistencia != 0)
            {
                _potencia = Math.Pow(Tensao, 2) / Resistencia;
            }
            // P = U*i
            if (Tensao != 0 && Corrente != 0)
            {
                _potencia = Tensao * Corrente;
            }
            // P = R.i²
            else
            {
                _potencia = Resistencia * Math.Pow(Corrente, 2);
            }
        }
    }
}
