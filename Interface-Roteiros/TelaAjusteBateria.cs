using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaAjusteBateria : Interface_Roteiros.TelaAjustePadrao
    {
        public Circuito Circuito { get; set; }
        public Label LabelTexto { get; set; }
        public Label LabelV0 { get; set; }
        public TelaAjusteBateria()
        {
            InitializeComponent();
        }

        private void tckSlider_Scroll(object sender, EventArgs e)
        {
            var valor = tckSlider.Value;
            AtualizarValores(valor);
        }

        private void TelaAjusteBateria_Load(object sender, EventArgs e)
        {
            tckSlider.Value = Circuito.Fonte.Tensao;
            AtualizarValores(Circuito.Fonte.Tensao);
        }

        private void AtualizarValores(int valor)
        {
            Circuito.Fonte.Tensao = valor;
            lblValor.Text = LabelTexto.Text = valor.ToString() + "V";
            Circuito.ResolverCircuto();
            lblCorrente.Text = FormatarValor(Circuito.Fonte.Corrente, "A");
            lblPotencia.Text = FormatarValor(Circuito.Fonte.Potencia, "W");
            LabelV0.Text = FormatarValor(Circuito.V0, "V");
        }
    }
}
