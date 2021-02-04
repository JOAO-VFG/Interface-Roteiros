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
        private Control telaRoteiro1;

        public TelaRoteiros()
        {
            InitializeComponent();
            // Cria uma tela para o roteiro 1
            telaRoteiro1 = subRoteiro1.Roteiro;
            Controls.Add(telaRoteiro1);
            telaRoteiro1.Hide();
        }

        // Mostra a janela do roteiro 1
        private void subRoteiro1_Click(object sender, EventArgs e)
        {
            telaRoteiro1.BringToFront();
            telaRoteiro1.Show();
        }
    }
}
