using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaSimulador : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaInicial Tela { get; set; }
        public TelaSimulador()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela.Show();
        }
    }
}
