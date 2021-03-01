using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaCircuito5 : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaSimulador TelaRetorno { get; set; }
        public TelaCircuito5()
        {
            InitializeComponent();
        }

        // Fecha a janela atual e exibe a anterior, antes oculta
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            TelaRetorno.Show();
        }
    }
}
