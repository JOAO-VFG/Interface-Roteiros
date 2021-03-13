using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class PainelResistor : UserControl
    {
        public Resistor Resistor { get; set; }
        public Label LabelDoResistor { get; set; }
        public Circuito2 Circuito { get; set; }
        public TelaLeisDeOhm TelaPrincipal { get; set; }
        public int Resistencia
        {
            set { lblResistencia.Text = value.ToString() + "Ω"; }
        }

        public PainelResistor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exibe as propriedades do resistor na janela
        /// </summary>
        public void ExibirDados()
        {
            Circuito.ResolverCircuito(); // Calcula o circuito
            // Exibe os dados
            lblCorrente.Text = Circuito2.ConverterGrandeza(Resistor.Corrente, "A");
            lblTensao.Text = Circuito2.ConverterGrandeza(Resistor.Tensao, "V");
            lblPotencia.Text = Circuito2.ConverterGrandeza(Resistor.Potencia, "W");
            // Exibe também os dados principais
            TelaPrincipal.LabelCorrente.Text = Circuito2.ConverterGrandeza(Circuito.CorrenteTotal, "A");
            TelaPrincipal.LabelResistencia.Text = Circuito2.ConverterGrandeza(Circuito.ResistenciaEquivalente, "Ω");
            TelaPrincipal.LabelPotencia.Text = Circuito2.ConverterGrandeza(Circuito.PotenciaTotal, "W");
            // Muda o valor da barra de resistência
            trackResistencia.Value = Resistor.Resistencia;
        }

        private void PainelResistor_Load(object sender, EventArgs e)
        {
            xuiCircleProgressBar1.IsAnimated = true;
        }

        private void trackResistencia_Scroll(object sender, EventArgs e)
        {
            string valor = trackResistencia.Value.ToString() + "Ω";
            LabelDoResistor.Text = lblResistencia.Text = valor;
            Resistor.Resistencia = trackResistencia.Value;
            ExibirDados();
        }
    }
}
