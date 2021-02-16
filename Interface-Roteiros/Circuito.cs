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
        private double V1 { get; set; }
        public double[] Correntes { get; set; } = new double[3];

        public Circuito(Resistor[] resistores, Bateria fonte)
        {
            this.Resistores = resistores;
            this.Fonte = fonte;
        }

        // Calcula o circuito
        public void ResolverCircuto()
        {
            CalcularCorrentes();
            foreach(var resistor in Resistores)
            {
                resistor.CalcularPotencia();
            }
            Fonte.CalcularPotencia();
            var r2 = Resistores[1].Resistencia;
            var r3 = Resistores[2].Resistencia;
            V1 = (double)(r2 + r3) / 8;
            V0 = Fonte.Tensao / V1;
        }

        /* Calcula as correntes que passam pelo circuito e 
         * atribui o valor de cada uma ao elementos */
        private void CalcularCorrentes()
        {
            var ddp = Fonte.Tensao;
            // Corrente que passa pela bateria
            Fonte.Corrente = Correntes[0] = (double)ddp / ResistenciaEquivalente();
            // Corrente ramificada do meio
            Resistores[0].Corrente =  Correntes[1] = (double)ddp / Resistores[0].Resistencia;
            // Corrente ramificado do extremo
            Correntes[2] = (double)ddp / (Resistores[1].Resistencia + Resistores[2].Resistencia);
            Resistores[1].Corrente = Resistores[2].Corrente = Correntes[2];
        }

        private double ResistenciaEquivalente()
        {
            var r1 = Resistores[0].Resistencia;
            var r2 = Resistores[1].Resistencia;
            var r3 = Resistores[2].Resistencia;
            var req = r2 + r3;

            return (double)(r1 * req) / (r1 + req);
        }
    }
}
