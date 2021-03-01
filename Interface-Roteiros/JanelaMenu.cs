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
        public Label[] Textos { get; set; } = new Label[3];
        public Panel Painel { get; set; }
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
            var height = Painel.MaximumSize.Height;
            var location = Painel.Location;
            // Fecha o painel
            if(this.Painel.Size == this.Painel.MaximumSize)
            {
                Painel.Size = Painel.MinimumSize;
                Painel.Location = new Point(location.X, location.Y + height - 29);
            } else
            {
                Painel.Size = Painel.MaximumSize;
                Painel.Location = new Point(location.X, location.Y - Painel.MaximumSize.Height + 29);
            }
        }

        // Liga ou desliga o botão e oculta ou mostra o texto
        private void btnTexto_Click(object sender, EventArgs e)
        {
            TrocarImagem(btnTexto);
            if(btnTexto.Image == botaoOff)
            {
                foreach (var texto in Textos)
                {
                    texto.Hide();
                }
            } else
            {
                foreach(var texto in Textos)
                {
                    texto.Show();
                }
            }
            
        }

        // Ao criar a janela, a imagem dos botões são carregadas
        private void JanelaMenu_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            btnPainel.Image = botaoOn;
            btnTexto.Image = botaoOn;
            // Fecha a Janela
            panMenu.Hide();
            this.Size = this.MinimumSize;
        }

        // Retornar a tela inicial
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaDeRetorno.Show();
            TelaAtual.Close();
        }
    }
}
