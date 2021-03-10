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
        // Campos privados para evento Enter
        private readonly Color corRosa = Color.FromArgb(193, 27, 222);
        private readonly Color corBranca = Color.White;
        // Campo privado para evento Leave
        private readonly Color corEscura = Color.FromArgb(18, 18, 18);

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
                lblNomeCompoenente.Padding = new Padding(30, 0, 0, 0);
                imgImagem.Location = new Point(6, 12);
            }
            // Controle fechado, abre ele
            else
            {
                this.Size = this.MaximumSize;
                panSelecionado.BackColor = corVerde;
                lblNomeCompoenente.Padding = new Padding(35, 0, 0, 0);
                imgImagem.Location = new Point(10, 12);
            }
        }

        // Ocorre quando o mouse passa por cima
        private void lblNomeCompoenente_MouseEnter(object sender, EventArgs e)
        {
            lblNomeCompoenente.BackColor = corRosa;
            panSelecionado.BackColor = corBranca;
            imgImagem.BackColor = corRosa;
        }

        private void lblNomeCompoenente_MouseLeave(object sender, EventArgs e)
        {
            lblNomeCompoenente.BackColor = corEscura;
            panSelecionado.BackColor = corPadrao;
            imgImagem.BackColor = corPadrao;
        }

        private void CaixaComponente_Load(object sender, EventArgs e)
        {
        }

        private void tckResistencia_Scroll(object sender, EventArgs e)
        {
            var valor = tckResistencia.Value;
            cpbResistencia.Percentage = valor;
            lblResistencia.Text = $"{valor}Ω";
        }
    }
}
