using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaInicial : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void NovaTelaInicial_Load(object sender, EventArgs e)
        {
            boxSobre.Tela = new TelaSobre();
            boxSimulador.Tela = new TelaSimulador() { TelaDeInicio = this, };
            boxPdf.Tela = new TelaPDF() { TelaInicial = this, };

            boxPdf.TelaDeRetorno = this;
            boxSimulador.TelaDeRetorno = this;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
