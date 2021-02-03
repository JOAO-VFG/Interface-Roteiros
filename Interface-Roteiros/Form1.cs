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
        private Control telaRoteiro;

        public Form1()
        {
            InitializeComponent();
            var roteiroTela = new TelaRoteiros();
            Controls.Add(roteiroTela);
            roteiroTela.Location = new Point(0, 75);
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

        // Navega até a seção de roteiros
        private void btnRoteiros_Click(object sender, EventArgs e)
        {
            var telaRoteiro = Controls[Controls.Count - 1];
            telaRoteiro.BringToFront();
        }


        // Retorna a tela inicial
        private void btnInicio_Click(object sender, EventArgs e)
        {
            panGeral.BringToFront();
        }
    }
}
