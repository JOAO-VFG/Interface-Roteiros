using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaCircuitoTeste : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaCircuitoTeste()
        {
            InitializeComponent();
        }

        private void btnResistor1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Título!");
        }
    }
}
