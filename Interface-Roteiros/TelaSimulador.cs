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
        private Roteiro[] roteiros;
        // Roteiro que está sendo apresentando para o usuário clicar
        private int roteiroSelecionado;
        public TelaSimulador()
        {
            InitializeComponent();
        }

        private void TelaSimulador_Load(object sender, EventArgs e)
        {
            roteiros = new Roteiro[5] { rtrCargas, rtrLeisOhm, rtrKirchhof, 
            rtrCoresResistor, rtrNosEMalhas};
            roteiroSelecionado = 0;

            var location = rtrCargas.Location;
            var size = rtrCargas.Size;

            // Oculta todos os roteiros, com exceção do 1°
            for (var i = 1; i < roteiros.Length; i++)
            {
                roteiros[i].Hide();
                // Coloca todos os componentes encaixados na mesma localização
                roteiros[i].Location = location;
                // Faz com que todos tenham o mesmo tamanho
                roteiros[i].Size = size;
            }

            
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

        private void rtrCoresResistor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaCoresResistor() { TelaDeRetorno = this, }.Show();
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.FromArgb(214, 210, 210);
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.FromArgb(25, 214, 210, 210);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Oculta o atual o exibe o próximo
            roteiros[roteiroSelecionado].Hide();
            // Último elemento
            if (roteiroSelecionado == roteiros.Length - 1)
            {
                roteiroSelecionado = -1;
            }
            roteiros[roteiroSelecionado++ + 1].Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Oculta o atual o exibe o próximo
            roteiros[roteiroSelecionado].Hide();
            // Primeiro elemento
            if (roteiroSelecionado == 0)
            {
                roteiroSelecionado = roteiros.Length;
            }
            roteiros[roteiroSelecionado-- - 1].Show();
        }

    }
}
