using System;
using System.Collections.Generic;

namespace Interface_Roteiros
{
    public class Circuito2
    {
        private double _resistenciaEquivalente;
        private double _correnteTotal;
        private double _potenciaTotal;

        public Resistor[] Resistores { get; set; }
        public Bateria Bateria { get; set; }
        public double ResistenciaEquivalente
        {
            get
            {
                CalcularResistenciaEquivalente();
                return _resistenciaEquivalente;
            }
        }
        public double CorrenteTotal
        {
            get
            {
                CalcularCorrenteTotal();
                return _correnteTotal;
            }
        }
        public double PotenciaTotal
        {
            get
            {
                CalcularPotenciaTotal();
                return _potenciaTotal;
            }
        }

        public Circuito2(Resistor[] resistores, Bateria bateria)
        {
            this.Resistores = resistores;
            this.Bateria = bateria;
        }

        public void CalcularCircuito()
        {
            
        }

        /// <summary>
        /// Calcula a resistência equivalente entre 2 resistores em paralelo
        /// </summary>
        /// <param name="r1">Resistor 1</param>
        /// <param name="r2">Resistor 2</param>
        /// <returns>Resistência Equivalente</returns>
        private double ResistorEmParalelo(double r1, double r2)
        {
            return (r1 * r2) / (r1 + r2);
        }

        private void CalcularResistenciaEquivalente()
        {
            // Série
            var req1 = Resistores[0].Resistencia + Resistores[1].Resistencia;
            // Paralelo ramo superior
            var reqRamoSuperior = Resistores[2].Resistencia + Resistores[3].Resistencia;
            // Paralelo ramo inferior
            var reqRamoInferior = Resistores[4].Resistencia + Resistores[5].Resistencia;
            // Equivalente do ramo superior e inferior em paralelo
            var req2 = ResistorEmParalelo(reqRamoSuperior, reqRamoInferior);
            _resistenciaEquivalente = req1 + req2;
        }

        private void CalcularCorrenteTotal()
        {
            _correnteTotal = Bateria.Tensao / ResistenciaEquivalente;
        }

        private void CalcularPotenciaTotal()
        {
            _potenciaTotal = Bateria.Tensao * CorrenteTotal;
        }

        /// <summary>
        /// Pega um valor e, se necessário, transforma a unidade a medida.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="unidade"></param>
        /// <returns>O valor formatado</returns>
        public static string ConverterGrandeza(double valor, string unidade)
        {
            // Valor é menor que o módulo de 1 e sua unidade é atualizada para 'mili' (m)
            if (valor > -1 && valor < 1)
            {
                valor *= 1000;
                unidade = "m" + unidade;
            }
            return Math.Round(valor, 2).ToString() + unidade;
        }
    }
}
