using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class NovaTelaInicial : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaSimulador TelaSimulador { get; set; }
        public TelaPDF TelaPDF { get; set; }
        public TelaSobre TelaSobre { get; set; }
        public NovaTelaInicial()
        {
            InitializeComponent();
        }

        private void NovaTelaInicial_Load(object sender, EventArgs e)
        {
            boxSimulador.Tela = new TelaSimulador() { TelaDeInicio = this, };
            boxSobre.Tela = new TelaSobre();
            boxPdf.Tela = new TelaPDF();
        }
    }
}
