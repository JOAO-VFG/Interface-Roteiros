using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaCircuito5 : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaSimulador TelaDeRetorno { get; set; }
        public TelaCircuito5()
        {
            InitializeComponent();
        }

        private void TelaCircuito5_Load(object sender, EventArgs e)
        {
            janelaMenu1.TelaDeRetorno = this.TelaDeRetorno;
            janelaMenu1.TelaAtual = this;
            Label[] array = { lblCorrente, lblResistor1, lblResistor2, lblResistor3};
            janelaMenu1.Textos = array;
            janelaMenu1.Painel = panPainel;
        }
    }
}
