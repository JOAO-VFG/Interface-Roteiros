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
    public partial class JanelaMenu : UserControl
    {
        public TelaSimulador TelaDeRetorno { get; set; }
        public TelaInicialPadrao TelaAtual { get; set; }
        private readonly Image botaoOff = Properties.Resources.toggleOff;
        private readonly Image botaoOn = Properties.Resources.toggleOn;

        public JanelaMenu()
        {
            InitializeComponent();
        }

        // Méotodo para abrir e fechar a janela
        private void imgMenu_Click(object sender, EventArgs e)
        {
            // Verifica se a janela está fechada, caso sim, abre-a
            if(this.Size == this.MinimumSize)
            {
                panMenu.Show();
                this.Size = this.MaximumSize;
            }
            // Fecha a janela
            else
            {
                panMenu.Hide();
                this.Size = this.MinimumSize;
            }
        }

        // Verifica a atual imagem do botão e altera para o oposto
        private void TrocarImagem(Button button)
        {
            // Se o botão está "aceso", ele desliga
            if (button.Image == botaoOn)
            {
                button.Image = botaoOff;
            }
            // "Acende o botão
            else
            {
                button.Image = botaoOn;
            }
        }

        // Liga ou desliga o botão do painel
        private void btnPainel_Click(object sender, EventArgs e)
        {
            TrocarImagem(btnPainel);
        }

        // Liga ou desliga o botão
        private void btnTexto_Click(object sender, EventArgs e)
        {
            TrocarImagem(btnTexto);
        }

        // Ao criar a janela, a imagem dos botões são carregadas
        private void JanelaMenu_Load(object sender, EventArgs e)
        {
            btnPainel.Image = botaoOn;
            btnTexto.Image = botaoOn;
        }

        // Retornar a tela inicial
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaDeRetorno.Show();
            TelaAtual.Close();
        }
    }
}
