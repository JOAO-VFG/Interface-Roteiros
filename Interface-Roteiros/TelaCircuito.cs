using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaCircuito : Interface_Roteiros.TelaInicialPadrao
    {
        // Tela anterior
        public TelaSimulador TelaRetorno { get; set; }
        // Tela de configuração dos resistores
        private TelaAjusteResistor[] telaResistor = new TelaAjusteResistor[3];
        // Tela da fonte
        private TelaAjusteBateria telaFonte;
        // Fonte
        private Bateria fonte;
        // Resistores
        private Resistor[] resistor = new Resistor[3];
        // Circuito
        private Circuito circuito;
        public TelaCircuito()
        {
            InitializeComponent();
        }

        private void TelaCircuitoTeste_Load(object sender, EventArgs e)
        {
            // Fonte
            fonte = new Bateria(40);
            // Resistores
            resistor[0] = new Resistor(5);
            resistor[1] = new Resistor(12);
            resistor[2] = new Resistor(8);
            // Circuito
            circuito = new Circuito(resistor, fonte);

            // Array para iterar o label de cada resistor na tela
            Label[] textos = { lblResistor1, lblResistor2, lblResistor3 };

            // Configura as janelas dos resistores
            for(var i = 0; i < telaResistor.Length; i++)
            {
                telaResistor[i] = new TelaAjusteResistor()
                {
                    Circuito = this.circuito,
                    Resistor = resistor[i],
                    LabelTexto = textos[i],
                    LabelVo = lblV0,
                };
            }
            // Configura a janela da bateria
            telaFonte = new TelaAjusteBateria()
            {
                Titulo = "Fonte",
                ImagemTitulo = Properties.Resources.battery,
                Circuito = this.circuito,
                LabelTexto = lblFonte,
                LabelV0 = lblV0,
            };
        }

        private void btnResistor1_Click(object sender, EventArgs e)
        {
            telaResistor[0].Show();
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {
            telaFonte.CarregarValores();
            telaFonte.Show();
        }

        private void btnResistor2_Click(object sender, EventArgs e)
        {
            telaResistor[1].Show();
        }

        private void btnResistor3_Click(object sender, EventArgs e)
        {
            telaResistor[2].Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            TelaRetorno.Show();
            this.Close();
        }
    }
}
