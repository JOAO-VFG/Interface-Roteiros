using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaLeisDeOhm : Interface_Roteiros.TelaInicialPadrao
    {
        public Circuito2 Circuito { get; private set; }
        public TelaSimulador TelaDeRetorno { get; set; }
        public TelaLeisDeOhm()
        {
            InitializeComponent();
        }

        private void TelaLeisDeOhm_Load(object sender, EventArgs e)
        {
            Resistor[] resistores =
            {
                new Resistor(1), new Resistor(1), new Resistor(1),
                new Resistor(1), new Resistor(1), new Resistor(1)
            };
            Bateria fonte = new Bateria(1);

            Circuito = new Circuito2(resistores, fonte);
            Circuito.CalcularCircuito();

            painelResistor.Resistor = resistores[0];
            painelResistor.LabelDoResistor = lblResistor1;
            painelResistor.ExibirDados();
            lblResistencia.Text = Circuito2.ConverterGrandeza(Circuito.ResistenciaEquivalente, "Ω");
            lblCorrente.Text = Circuito2.ConverterGrandeza(Circuito.CorrenteTotal, "A");
            lblPotencia.Text = Circuito2.ConverterGrandeza(Circuito.PotenciaTotal, "W");
        }

        // Atualiza o painel com as informações do resistor
        private void AtualizarPainelResistor(Resistor resistor, Label label)
        {
            painelResistor.Resistor = resistor;
            painelResistor.Resistencia = resistor.Resistencia;
            painelResistor.LabelDoResistor = label;
            painelResistor.ExibirDados();
        }

        // Eventos de quando o usuário clica no resistor
        private void lblResistor1_2_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[0], lblResistor1);
        }

        private void lblResistor2_2_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[1], lblResistor2);
        }

        private void lblResistor3_2_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[2], lblResistor3_2);
        }

        private void lblResistor4_2_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[3], lblResistor4_2);
        }

        private void lblResistor5_2_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[4], lblResistor5_2);
        }

        private void lblResistor6_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[5], lblResistor6_2);
        }
        // ==================================================

        // Fecha a atual janela e retorna a tela de seleção
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaDeRetorno.Show();
            this.Close();
        }
    }
}
