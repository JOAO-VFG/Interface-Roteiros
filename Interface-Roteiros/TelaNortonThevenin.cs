using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaNortonThevenin : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaSimulador TelaDeRetorno { get; set; }
        public TelaNortonThevenin()
        {
            InitializeComponent();
        }

        private void TelaCircuito5_Load(object sender, EventArgs e)
        {
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            TelaDeRetorno.Show();
            this.Close();
        }
    }
}
