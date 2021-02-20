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
        public NovaTelaInicial TelaInicio { get; set; }
        public TelaSimulador TelaAtual { get; set; }

        public TelaRoteiros()
        {
            InitializeComponent();
        }

        // Mostra a janela do roteiro 1
        private void subRoteiro1_Click(object sender, EventArgs e)
        {
        }

        private void subRoteiro2_Click(object sender, EventArgs e)
        {
        }

        private void subRoteiro3_Click(object sender, EventArgs e)
        {
        }

        private void subRoteiro4_Click(object sender, EventArgs e)
        {
        }

        private void subRoteiro5_Click(object sender, EventArgs e)
        {
        }

        private void subRoteiro6_Click(object sender, EventArgs e)
        {
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            try
            {
                TelaAtual.Hide();
                TelaInicio.Show();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
