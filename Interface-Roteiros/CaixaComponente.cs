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
        public override Color ForeColor
        {
            get { return lblNomeCompoenente.ForeColor; }
            set { lblNomeCompoenente.ForeColor = value; }
        }

        public override Color BackColor
        {
            get { return lblNomeCompoenente.BackColor; }
            set
            {
                lblNomeCompoenente.BackColor = value;
                imgImagem.BackColor = value;
            }
        }

        // Cor do componente quando o mouse sai do campo
        private Color BackColorLeave;

        public bool IsOpen { get; private set; }
        private readonly Color corPadrao = Color.Transparent;
        // Campos privados para evento Enter
        private readonly Color corRosa = Color.FromArgb(193, 27, 222);
        private readonly Color corBranca = Color.White;

        public CaixaComponente()
        {
            InitializeComponent();
        }

        // O item é clicado, abre e fecha ele
        private void lblNomeCompoenente_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                IsOpen = false;
                FecharJanela();
            }
            // Controle fechado, abre ele
            else
            {
                IsOpen = true;
                AbrirJanela();
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
            if(IsOpen)
            {
                panSelecionado.BackColor = CorOnSelected;
            }
            else
            {
                panSelecionado.BackColor = corPadrao;
            }

            lblNomeCompoenente.BackColor = BackColorLeave;
            imgImagem.BackColor = BackColorLeave;
        }

        private void FecharJanela()
        {
            this.Size = this.MinimumSize;
            panSelecionado.BackColor = BackColorLeave;
            lblNomeCompoenente.Padding = new Padding(30, 0, 0, 0);
            imgImagem.Location = new Point(6, 12);
        }

        private void AbrirJanela()
        {
            this.Size = this.MaximumSize;
            panSelecionado.BackColor = CorOnSelected;
            lblNomeCompoenente.Padding = new Padding(35, 0, 0, 0);
            imgImagem.Location = new Point(10, 12);
        }

        private void CaixaComponente_Load(object sender, EventArgs e)
        {
            IsOpen = false;
            BackColorLeave = BackColor;
        }

        private void tckResistencia_Scroll(object sender, EventArgs e)
        {
            var valor = tckResistencia.Value;
            cpbResistencia.Percentage = valor;
            lblResistencia.Text = $"{valor}Ω";
        }
    }
}
