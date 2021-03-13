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
    public partial class PainelBateria : UserControl
    {
        public Label LabelFonte { get; set; }
        public Circuito2 Circuito { get; set; }
        public TelaLeisDeOhm TelaPrincipal { get; set; }
        public Bateria Bateria { get; set; }
        public PainelBateria()
        {
            InitializeComponent();
        }

        // Exibe os dados na tela principal
        private void ExibirDadosTelaPrincipal()
        {
            TelaPrincipal.LabelCorrente.Text = Circuito2.ConverterGrandeza(Circuito.CorrenteTotal, "A");
            TelaPrincipal.LabelPotencia.Text = Circuito2.ConverterGrandeza(Circuito.PotenciaTotal, "W");
            TelaPrincipal.LabelResistencia.Text = Circuito2.ConverterGrandeza(Circuito.ResistenciaEquivalente, "Ω");
        }

        // Exibe os dados no painel
        public void ExibirDados()
        {
            Circuito.ResolverCircuito();

            ExibirDadosTelaPrincipal();

            lblCorrente.Text = Circuito2.ConverterGrandeza(Bateria.Corrente, "A");
            lblPotencia.Text = Circuito2.ConverterGrandeza(Bateria.Potencia, "W");
        }

        private void PainelBateria_Load(object sender, EventArgs e)
        {
            xuiCircleProgressBar1.IsAnimated = true;
        }

        private void trackTensao_Scroll(object sender, EventArgs e)
        {
            var valor = Bateria.Tensao = trackTensao.Value;
            LabelFonte.Text = lblTensao.Text = $"{valor}V";

            ExibirDados();
        }
    }
}
