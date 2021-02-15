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
    public partial class TelaCircuito : Form
    {
        // Janela de configuração da fonte
        private TelaAjusteBateria telaFonte;
        // Janela de condnguração do resistor
        private TelaAjusteResistor[] telaResistores = new TelaAjusteResistor[3];

        private Resistor[] resistores = new Resistor[3];

        private void TelaCircuito_Load(object sender, EventArgs e)
        {
            // Cria os resistores
            resistores[0] = new Resistor(12);
            resistores[1] = new Resistor(5);
            resistores[2] = new Resistor(8);
            // Armazena os labels para serem utlizados depois
            Label[] labelsResistores = { lblResistor1, lblResistor2, lblResistor3 };
            // Cria a janela de informações dos resistores
            for (var i = 0; i < telaResistores.Length; i++)
            {
                telaResistores[i] = new TelaAjusteResistor()
                {
                    LabelTexto = labelsResistores[i],
                    Resistor = resistores[i],
                };
            }
            // Cria janela de informações da bateria
            telaFonte = new TelaAjusteBateria() {
                Titulo = "Fonte",
                ImagemTitulo = Properties.Resources.battery,
            };
        }

        public TelaCircuito()
        {
            InitializeComponent();
        }

        private void btnResistor1_Click(object sender, EventArgs e)
        {
            telaResistores[0].Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            telaFonte.Show();
        }

        private void btnResistor2_Click(object sender, EventArgs e)
        {
            telaResistores[1].Show();
        }

        private void btnResitor3_Click(object sender, EventArgs e)
        {
            telaResistores[2].Show();
        }
    }
}
