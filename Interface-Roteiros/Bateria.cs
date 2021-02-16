using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Roteiros
{
    public class Bateria
    {
        public int Tensao { get; set; }
        public double Corrente { get; set; }
        public double Potencia { get; set; }

        public Bateria(int ddp)
        {
            Tensao = ddp;
        }

        public void CalcularPotencia()
        {
            Potencia = Tensao * Corrente;
        }
    }
}
