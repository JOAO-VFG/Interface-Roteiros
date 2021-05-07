using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaInicial : Interface_Roteiros.TelaInicialPadrao
    {
        private Image[] imgFotos;
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void NovaTelaInicial_Load(object sender, EventArgs e)
        {
            boxSobre.Tela = new TelaSobre();
            boxSimulador.Tela = new TelaSimulador() { TelaDeInicio = this, };
            boxPdf.Tela = new TelaPDF() { TelaInicial = this, };

            boxPdf.TelaDeRetorno = this;
            boxSimulador.TelaDeRetorno = this;

            // Carrega as fotos
            var ft1 = Properties.Resources.thumb;
            var ft2 = Properties.Resources.thumb2;
            imgFotos = new Image[2] { ft1, ft2 };
            imgFundo.Image = imgFotos[0];
            // Inicia o timer
            tmMudarFundo.Start();
        }

        private void tmMudarFundo_Tick(object sender, EventArgs e)
        {
            if (imgFundo.Image == imgFotos[0])
            {
                imgFundo.Image = imgFotos[1];
            } else
            {
                imgFundo.Image = imgFotos[0];
            }
        }
    }
}
