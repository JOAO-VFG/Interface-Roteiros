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
        private Color _panCorHover;

        public Color PanelCorHover
        {
            get { return _panCorHover; }
            set
            {
                _panCorHover = value;
                panSelecionado.BackColor = _panCorHover;
            }
        }

        private Color _backColorName;

        public Color BackColorLeave
        {
            get { return lblNomeComponente.BackColor; }
            set
            {
                lblNomeComponente.BackColor = value;
                imgImagem.BackColor = value;
            }
        }

        public string Nome
        {
            get { return lblNomeComponente.Text; }
            set { lblNomeComponente.Text = value; }
        }
        
        public Image ImagemComponent
        {
            get { return imgImagem.Image; }
            set { imgImagem.Image = value; }
        }

        public bool IsOpen { get; private set; }
        // Campos privados para evento Enter
        private readonly Color corRosa = Color.FromArgb(193, 27, 222);

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
            panSelecionado.BackColor = Color.White;
            BackColorLeave = corRosa;
        }

        private void lblNomeCompoenente_MouseLeave(object sender, EventArgs e)
        {
            if(IsOpen)
            {
                panSelecionado.BackColor = PanelCorHover;
            }
            else
            {
                panSelecionado.BackColor = _backColorName;
            }

            BackColorLeave = _backColorName;
        }

        private void FecharJanela()
        {
            this.Size = this.MinimumSize;
            panSelecionado.BackColor = _backColorName;
            lblNomeComponente.Padding = new Padding(30, 0, 0, 0);
            imgImagem.Location = new Point(6, 12);
            BackColorLeave = _backColorName;
        }

        private void AbrirJanela()
        {
            this.Size = this.MaximumSize;
            panSelecionado.BackColor = PanelCorHover;
            lblNomeComponente.Padding = new Padding(35, 0, 0, 0);
            imgImagem.Location = new Point(10, 12);
            BackColorLeave = _backColorName;
        }

        private void CaixaComponente_Load(object sender, EventArgs e)
        {
            IsOpen = false;
            _panCorHover = Color.FromArgb(21, 232, 46);
            _backColorName = BackColorLeave;
        }

        private void tckResistencia_Scroll(object sender, EventArgs e)
        {
            var valor = tckResistencia.Value;
            cpbResistencia.Percentage = valor;
            lblResistencia.Text = $"{valor}Ω";
        }
    }
}
