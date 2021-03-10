using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaSimulador : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaInicial TelaDeInicio { get; set; }
        public TelaSimulador()
        {
            InitializeComponent();
        }

        // Sai do controle atual
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaDeInicio.Show();
        }

        /*
         * Dá um feedback visual para o usuário identificiar que o mouse está
         * sobre o botão de sair
         ====================================================================*/
        private void btnRetornar_MouseEnter(object sender, EventArgs e)
        {
            btnRetornar.Cursor = Cursors.Hand;
        }

        private void btnRetornar_MouseLeave(object sender, EventArgs e)
        {
            btnRetornar.Cursor = Cursors.Default;
        }

        // Abre a janela do circuito das leis de Kirchhof
        private void rtrKirchhof_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLeisDeKirchhof() { TelaRetorno = this, }.Show();
        }

        // Abre a janela do cicuito do teorema de Norton e Thévenin
        private void rtrNortonThevenin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaNortonThevenin() { TelaDeRetorno = this, }.Show();
        }

        private void rtrLeisOhm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLeisDeOhm() { TelaDeRetorno = this, }.Show();
        }
    }
}
