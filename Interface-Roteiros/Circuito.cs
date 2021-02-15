using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Roteiros
{
    public class Circuito
    {
        public Bateria Fonte { get; set; }
        public Resistor[] Resistores { get; set; }
        public double I0 { get; set; } = 0.125;
        public double V0 { get; set; }
        public double V1 { get; set; }
        public double[] Correntes { get; set; } = new double[3];

        public Circuito(Resistor[] resistores, Bateria fonte)
        {
            this.Resistores = resistores;
            this.Fonte = fonte;
        }

        // Calcula o circuito
        public void ResolverCircuto()
        {
            var r1 = Resistores[0].Resistencia;
            var r2 = Resistores[1].Resistencia;
            var r3 = Resistores[2].Resistencia;
            var fonte = Fonte.Tensao;

            V1 = (r2 + r3) * 1 / 8;
            V0 = fonte / V1;

            var i1 = fonte / r1;
            var i2 = fonte / r2;
            var i3 = fonte / r3;
            double[] correntes = { i1, i2, i3 };
            var contador = 0;
            foreach(var i in correntes)
            {
                Correntes[contador] = i;
                contador++;
            }
        }
    }
}
