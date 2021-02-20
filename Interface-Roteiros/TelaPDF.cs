using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaPDF : Interface_Roteiros.TelaInicialPadrao
    {
        public NovaTelaInicial TelaInicial { get; set; }
        public TelaPDF()
        {
            InitializeComponent();
        }

        private void btnRetornar_MouseEnter(object sender, EventArgs e)
        {
            btnRetornar.Cursor = Cursors.Hand;
        }

        private void btnRetornar_MouseLeave(object sender, EventArgs e)
        {
            btnRetornar.Cursor = Cursors.Default; 
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial.Show();
        }
    }
}
