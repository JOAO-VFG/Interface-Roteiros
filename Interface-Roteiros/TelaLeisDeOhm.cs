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
        private PainelBateria painelBateria;

        public Circuito2 Circuito { get; private set; }
        public TelaSimulador TelaDeRetorno { get; set; }

        public Label LabelCorrente
        {
            get => lblCorrente;
            set => lblCorrente = value;
        }

        public Label LabelResistencia
        {
            get => lblResistencia;
            set => lblResistencia = value;
        }

        public Label LabelPotencia
        {
            get => lblPotencia;
            set => lblPotencia = value;
        }

        public TelaLeisDeOhm()
        {
            InitializeComponent();
        }

        private void TelaLeisDeOhm_Load(object sender, EventArgs e)
        {
            // Cria o circuito
            Resistor[] resistores =
            {
                new Resistor(1), new Resistor(1), new Resistor(1),
                new Resistor(1), new Resistor(1), new Resistor(1)
            };
            Bateria fonte = new Bateria(15);

            Circuito = new Circuito2(resistores, fonte);
            Circuito.ResolverCircuito();

            // Cria o painel para a bateria
            painelBateria = new PainelBateria();
            painelBateria.Location = painelResistor.Location;
            painelBateria.Hide();
            painelBateria.TelaPrincipal = this;
            painelBateria.BringToFront();
            painelBateria.Circuito = this.Circuito;
            panInformacoes.Controls.Add(painelBateria);

            painelResistor.TelaPrincipal = this;
            painelResistor.Circuito = this.Circuito;

            AtualizarPainelResistor(Circuito.Resistores[0], lblResistor1);

            lblResistencia.Text = Circuito2.ConverterGrandeza(Circuito.ResistenciaEquivalente, "Ω");
            lblCorrente.Text = Circuito2.ConverterGrandeza(Circuito.CorrenteTotal, "A");
            lblPotencia.Text = Circuito2.ConverterGrandeza(Circuito.PotenciaTotal, "W");
        }

        // Atualiza o painel com as informações do resistor
        private void AtualizarPainelResistor(Resistor resistor, Label label)
        {
            painelBateria.Hide();
            painelResistor.Show();

            painelResistor.Resistor = resistor;
            painelResistor.Resistencia = resistor.Resistencia;
            painelResistor.LabelDoResistor = label;
            painelResistor.ExibirDados();
        }

        private void AtualizarPainelBateria(Bateria fonte, Label label)
        {
            painelResistor.Hide();
            painelBateria.Show();

            painelBateria.LabelFonte = label;
            painelBateria.Bateria = fonte;
            painelBateria.ExibirDados();
        }

        // Evento de quando o usuário clicar na fonte
        private void lblFonte_2_Click(object sender, EventArgs e)
        {
            AtualizarPainelBateria(Circuito.Bateria, lblFonte);
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
            AtualizarPainelResistor(Circuito.Resistores[2], lblResistor3);
        }

        private void lblResistor4_2_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[3], lblResistor4);
        }

        private void lblResistor5_2_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[4], lblResistor5);
        }

        private void lblResistor6_Click(object sender, EventArgs e)
        {
            AtualizarPainelResistor(Circuito.Resistores[5], lblResistor6);
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
