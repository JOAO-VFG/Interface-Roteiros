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
    public partial class BoxInformacao : UserControl
    {
        private Color _colorOnLeave;
        public string TituloDaCaixa
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }
        public Image ImagemDaCaixa
        {
            get { return imgImagem.Image; }
            set { imgImagem.Image = value; }
        }
        public string TextoDaCaixa
        {
            get { return lblTexto.Text; }
            set { lblTexto.Text = value; }
        }
        // Cor do texto quando o mouse sai de cima do componente
        public Color TextOnLeave { get; set; } = Color.Black;
        // Cor do texto quando o mouse entra por cima do componente
        public Color TextOnEnter { get; set; } = Color.White;
        // Cor de fundo do texto quando o mouse entrar na caixa de informação
        public Color ColorOnEnter { get; set; } = Color.Aqua;
        // Cor de fundo do texto quando o mouse sai da caixa de informação
        public Color ColorOnLeave
        {
            get { return _colorOnLeave; }
            set
            {
                _colorOnLeave = value;
                panTexto.BackColor = _colorOnLeave;
            }
        }
        // Tela a ser carregada quando clicar no botão
        public TelaInicialPadrao Tela { get; set; }

        private readonly Color cinzaClaro = Color.FromArgb(58, 56, 59);
        private readonly Color cinzaEscuro = Color.FromArgb(28, 28, 28);
        public BoxInformacao()
        {
            InitializeComponent();
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcinou!");
            Tela.Show();
        }

        private void lblTexto_MouseEnter(object sender, EventArgs e)
        {
            panTitulo.BackColor = cinzaEscuro;
            panTexto.BackColor = ColorOnEnter;
            lblTexto.Cursor = Cursors.Hand;
            lblTexto.ForeColor = TextOnEnter;
        }

        private void lblTexto_MouseLeave(object sender, EventArgs e)
        {
            panTitulo.BackColor = cinzaClaro;
            panTexto.BackColor = ColorOnLeave;
            lblTexto.Cursor = Cursors.Default;
            lblTexto.ForeColor = TextOnLeave;
        }

        private void BoxInformacao_Load(object sender, EventArgs e)
        {
        }
    }
}
