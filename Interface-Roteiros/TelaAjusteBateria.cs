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
            AtualizarValores(Circuito.Fonte.Tensao);
        }

        private void AtualizarValores(int valor)
        {
            Circuito.Fonte.Tensao = valor;
            lblValor.Text = LabelTexto.Text = valor.ToString() + "V";
        }
    }
}
