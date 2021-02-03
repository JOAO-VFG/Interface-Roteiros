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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Diminui a janela de interação com o usuário
            panRoteiros.Size = panRoteiros.MinimumSize;
            // Traz ao formulário a nova tela
            this.Controls.Add(new Roteiro1());
            Controls[Controls.Count - 1].Location = new Point(0, 75);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * Método para quando o mouse sair da área do texto
         * nesse momento as cores padrão retornam a origem
         * */
        private void PainelNormal(Label texto, Panel fundo, Panel fundo2, Color cor)
        {
            texto.ForeColor = Color.Black;
            fundo.BackColor = cor;
            fundo2.BackColor = Color.FromArgb(58, 56, 59);
        }
        /*
         * Método para quando o mouse entrar na área do texto
         * nesse momento as cores personalidas surgem
         * */
        private void PainelHover(Label texto, Panel fundo, Panel fundo2, Color cor)
        {
            texto.ForeColor = Color.White;
            fundo.BackColor = cor;
            fundo2.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void lblSobre_MouseEnter(object sender, EventArgs e)
        {
            PainelHover(lblSobre, panSobre, panSobre2, Color.FromArgb(11, 230, 106));
        }

        private void lblSobre_MouseLeave(object sender, EventArgs e)
        {
            PainelNormal(lblSobre, panSobre, panSobre2, Color.FromArgb(37, 179, 99));
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = Properties.Resources.cancel_hover;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = Properties.Resources.cancel;
        }

        private void lblPDF_MouseEnter(object sender, EventArgs e)
        {
            PainelHover(lblPDF, panPDF, panPDF2, Color.FromArgb(11, 51, 161));
        }

        private void lblPDF_MouseLeave(object sender, EventArgs e)
        {
            PainelNormal(lblPDF, panPDF, panPDF2, Color.FromArgb(25, 149, 212));
        }

        private void lblSimulador_MouseEnter(object sender, EventArgs e)
        {
            PainelHover(lblSimulador, panSimulador, panSimulador2, Color.FromArgb(102, 3, 168));
        }

        private void lblSimulador_MouseLeave(object sender, EventArgs e)
        {
            PainelNormal(lblSimulador, panSimulador, panSimulador2, Color.FromArgb(146, 56, 224));
        }

        private void btnRoteiros_Click(object sender, EventArgs e)
        {
            // Fecha a janela
            if (panRoteiros.Size.Height == panRoteiros.MaximumSize.Height)
            {
                panRoteiros.Size = new Size(90, 40);
            }
            // Fecha a janela
            else
            {
                panRoteiros.Size = new Size(90, 220);
            }
        }

        // Abre a janela de roteiros 1
        private void btnRoteiro1_Click(object sender, EventArgs e)
        {
            Controls[Controls.Count - 1].BringToFront();
            panRoteiros.BringToFront();
            panRoteiros.Size = panRoteiros.MinimumSize;
        }

        // Abri o menu de roteiros
        private void abrirMenu_Tick(object sender, EventArgs e)
        {
            if (panRoteiros.Height <= panRoteiros.MaximumSize.Height)
            {
                panRoteiros.Height += 50;
            }
            else
            {
                panRoteiros.Height -= 50;
            }
        }

        private void btnRoteiros_MouseEnter(object sender, EventArgs e)
        {
            var alturaMinima = panRoteiros.MinimumSize.Height;
            var alturaMaxima = panRoteiros.MaximumSize.Height;
            var altura = panRoteiros.Height;

            abrirMenu.Start();

            if (altura == alturaMaxima || altura == alturaMinima)
            {
                abrirMenu.Stop();
            }
        }
    }
}
