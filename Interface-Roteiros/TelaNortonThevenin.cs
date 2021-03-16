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
        private TelaAjusteBateria telaFonte5;
        private Circuito5 circuito5;
        public TelaNortonThevenin()
        {
            InitializeComponent();
        }

        private void TelaCircuito5_Load(object sender, EventArgs e)
        {
            telaFonte5 = new TelaAjusteBateria()
            {
                Titulo = " Fonte ",
                ImagemTitulo = Properties.Resources.battery,
 


            };
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            TelaDeRetorno.Show();
            this.Close();
        }

        private void botaoPersonalizado1_Load(object sender, EventArgs e)
        {
            TelaAjusteBateria.Show();
            this.Close();
        }

        private void botaoPersonalizado2_Load(object sender, EventArgs e)
        {

        }

        private void botaoPersonalizado3_Load(object sender, EventArgs e)
        {

        }

        private void botaoPersonalizado4_Load(object sender, EventArgs e)
        {

        }
    }
}
