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
            lblResistencia.Text = Circuito2.ConverterGrandeza(Circuito.ResistenciaEquivalente, "Ω");
            lblCorrente.Text = Circuito2.ConverterGrandeza(Circuito.CorrenteTotal, "A");
            lblPotencia.Text = Circuito2.ConverterGrandeza(Circuito.PotenciaTotal, "W");
        }

        // Fecha a atual janela e retorna a tela de seleção
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaDeRetorno.Show();
            this.Close();
        }
    }
}
