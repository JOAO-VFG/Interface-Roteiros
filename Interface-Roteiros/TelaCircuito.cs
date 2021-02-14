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
        // Janela de configururações dos resistores
        private TelaAjusteResistor telaResistor1;
        private TelaAjusteResistor telaResistor2;
        private TelaAjusteResistor telaResistor3;
        // Janela de configuração da fonte
        private TelaAjusteBateria telaFonte;

        // Resistor 1
        private Resistor _resistor1;
        public Resistor Resistor1 { get { return _resistor1; } }
        // Resistor 2
        private Resistor _resistor2;
        public Resistor Resistor2 { get { return _resistor2; } }
        // Resistor 3
        private Resistor _resistor3;
        public Resistor Resistor3 { get { return _resistor3; } }
        // Fonte

        private void TelaCircuito_Load(object sender, EventArgs e)
        {
            telaFonte = new TelaAjusteBateria() {
                Titulo = "Fonte",
                ImagemTitulo = Properties.Resources.battery,
            };
            //1
            _resistor1 = new Resistor(12);
            telaResistor1 = new TelaAjusteResistor()
            {
                Resistor = _resistor1,
                LabelResistor = lblResistor1,
            };
            //2
            _resistor2 = new Resistor(5);
            telaResistor2 = new TelaAjusteResistor()
            {
                Resistor = _resistor2,
                LabelResistor = lblResistor2,
            };
            //3
            _resistor3 = new Resistor(8);
            telaResistor3 = new TelaAjusteResistor()
            {
                Resistor = _resistor3,
                LabelResistor = lblResistor3,
            };
        }

        public TelaCircuito()
        {
            InitializeComponent();
        }

        private void btnResistor1_Click(object sender, EventArgs e)
        {
            telaResistor1.Show();
        }

        private void btnResistor2_Click(object sender, EventArgs e)
        {
            telaResistor2.Show();
        }

        private void btnResistor3_Click(object sender, EventArgs e)
        {
            telaResistor3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            telaFonte.Show();
        }
    }
}
