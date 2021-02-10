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
    public partial class TelaRoteiros : UserControl
    {
        private Control[] telaRoteiros = new Control[6];

        public TelaRoteiros()
        {
            InitializeComponent();
            // Roteiro 1
            telaRoteiros[0] = subRoteiro1.Roteiro;

            // Roteiro 2
            telaRoteiros[1] = new Roteiro()
            {
                TextoTitulo = "Leis de Ohm",
                ImagemRoteiro = Properties.Resources.circuito2,
            };

            // Roteiro 3
            telaRoteiros[2] = new Roteiro()
            {
                TextoTitulo = "Leis de Kirchhof",
                ImagemRoteiro = Properties.Resources.circuito3,
            };

            telaRoteiros[3] = new Roteiro()
            {
                TextoTitulo = "Super Nós e Super Malhas",
                ImagemRoteiro = Properties.Resources.circuito4,
            };

            telaRoteiros[4] = new Roteiro()
            {
                TextoTitulo = "Teorema de Norton e Thevannin",
                ImagemRoteiro = Properties.Resources.circuito5,
            };

            telaRoteiros[5] = new Roteiro()
            {
                TextoTitulo = "Teorema da Superposição",
                ImagemRoteiro = Properties.Resources.circuito6,
            };

            // Adiciona todas as janelas ao controle aatual
            foreach (var c in telaRoteiros)
            {
                Controls.Add(c);
                c.Hide();
            }
        }

        // Abre uma janela trazendo-a para frente e mostrando-a
        private void AbrirJanela(Control janela)
        {
            janela.BringToFront();
            janela.Show();
        }

        // Mostra a janela do roteiro 1
        private void subRoteiro1_Click(object sender, EventArgs e)
        {
            AbrirJanela(telaRoteiros[0]);
        }

        private void subRoteiro2_Click(object sender, EventArgs e)
        {
            AbrirJanela(telaRoteiros[1]);
        }

        private void subRoteiro3_Click(object sender, EventArgs e)
        {
            AbrirJanela(telaRoteiros[2]);
        }

        private void subRoteiro4_Click(object sender, EventArgs e)
        {
            AbrirJanela(telaRoteiros[3]);
        }

        private void subRoteiro5_Click(object sender, EventArgs e)
        {
            AbrirJanela(telaRoteiros[4]);
        }

        private void subRoteiro6_Click(object sender, EventArgs e)
        {
            AbrirJanela(telaRoteiros[5]);
        }

        private void subRoteiro2_Load(object sender, EventArgs e)
        {

        }
    }
}
