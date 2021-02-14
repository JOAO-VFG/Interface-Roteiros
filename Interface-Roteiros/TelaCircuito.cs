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
    public partial class TelaCircuito : Form
    {
        // Janela de configuração da fonte
        private TelaAjusteBateria telaFonte;

        private void TelaCircuito_Load(object sender, EventArgs e)
        {
            // Bateria
            telaFonte = new TelaAjusteBateria() {
                Titulo = "Fonte",
                ImagemTitulo = Properties.Resources.battery,
            };
        }

        public TelaCircuito()
        {
            InitializeComponent();
        }

        private void btnResistor1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            telaFonte.Show();
        }
    }
}
