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
    public partial class CaixaComponente : UserControl
    {
        public string Nome
        {
            get { return lblNomeCompoenente.Text; }
            set { lblNomeCompoenente.Text = value; }
        }
        public Color CorOnSelected
        {
            get { return panSelecionado.BackColor; }
            set { panSelecionado.BackColor = value; }
        }
        public Image ImagemComponent
        {
            get { return imgImagem.Image; }
            set { imgImagem.Image = value; }
        }

        private readonly Color corVerde = Color.FromArgb(21, 232, 46);
        private readonly Color corPadrao = Color.Transparent;

        public CaixaComponente()
        {
            InitializeComponent();
        }

        private void lblNomeCompoenente_Click(object sender, EventArgs e)
        {
            var alturaAtual = this.Size.Height;

            // Se o controle está aberto, então fecha 
            if (alturaAtual == this.MaximumSize.Height)
            {
                this.Size = this.MinimumSize;
                panSelecionado.BackColor = corPadrao;
                lblNomeCompoenente.Padding = new Padding(25, 0, 0, 0);
                imgImagem.Location = new Point(3, 12);
            }
            // Controle fechado, abre ele
            else
            {
                this.Size = this.MaximumSize;
                panSelecionado.BackColor = corVerde;
                lblNomeCompoenente.Padding = new Padding(30, 0, 0, 0);
                imgImagem.Location = new Point(10, 12);
            }
        }
    }
}
