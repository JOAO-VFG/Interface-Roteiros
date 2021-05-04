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

        // Abre a janela do circuito das Leis de Ohm
        private void rtrLeisOhm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaLeisDeOhm() { TelaDeRetorno = this, }.Show();
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.FromArgb(214, 210, 210);
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.FromArgb(25, 214, 210, 210);
        }
    }
}
