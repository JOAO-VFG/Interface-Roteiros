using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaAjusteResistor : Interface_Roteiros.TelaAjustePadrao
    {
        public Circuito Circuito { get; set; }
        public Resistor Resistor { get; set; }
        public Label LabelTexto { get; set; }
        public Label LabelVo { get; set; }

        public TelaAjusteResistor()
        {
            InitializeComponent();
        }

        private void tckSlider_Scroll(object sender, EventArgs e)
        {
            var valor = tckSlider.Value;
            LabelTexto.Text = valor.ToString() + "Ω";
            AtualizarValores(valor);
        }

        private void TelaAjusteResistor_Load(object sender, EventArgs e)
        {
            tckSlider.Value = Resistor.Resistencia;
            AtualizarValores(Resistor.Resistencia);
        }

        // Atualiza os valores presentes na janela da interface
        private void AtualizarValores(int valor)
        {
            lblValor.Text = valor.ToString() + "Ω";
            cpbProgresso.Percentage = valor;
            Resistor.Resistencia = valor;
            Circuito.ResolverCircuto();
            lblCorrente.Text = FormatarValor(Resistor.Corrente, "A");
            lblPotencia.Text = FormatarValor(Resistor.Potencia, "W");
            LabelVo.Text = FormatarValor(Circuito.V0, "V");
        }
    }
}
