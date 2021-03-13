using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Interface_Roteiros
{
    public partial class EscolhaRoteiro : UserControl
    {
        private Image sinalMais;
        private Image sinalMenos;
        private bool isOpen;
        // Cor de feedback visual para o user
        private readonly Color cinzaEscuro = Color.FromArgb(52, 53, 54);
        private readonly Color cinzaClaro = Color.FromArgb(105, 106, 107);
        // Propriedades
        public string TituloRoteiro
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }
        public Image ImageRoteiro
        {
            get { return imgRoteiro.Image; }
            set { imgRoteiro.Image = value; }
        }
        public string PathPdf { get; set; }
        public override Color BackColor
        {
            get => lblTitulo.BackColor;
            set
            {
                lblTitulo.BackColor = btnPdf.BackColor = value;
            }
        }
        public EscolhaRoteiro()
        {
            InitializeComponent();
        }

        private void lblTitulo_MouseEnter(object sender, EventArgs e)
        {
            panTitulo.BackColor = cinzaEscuro;
        }

        private void lblTitulo_MouseLeave(object sender, EventArgs e)
        {
            panTitulo.BackColor = cinzaClaro;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            if(isOpen)
            {
                // Fecha a janela
                imgImagem.Image = sinalMais;
                isOpen = false;
                this.Size = this.MinimumSize;
            }
            else
            {
                // Abre a janela
                imgImagem.Image = sinalMenos;
                isOpen = true;
                this.Size = this.MaximumSize;
            }
        }

        private void EscolhaRoteiro_Load(object sender, EventArgs e)
        {
            // Por padrão, a janela inicia fechada
            isOpen = false;
            // Atribui a imagem ao lado do texto
            sinalMais = Properties.Resources.plus_sign;
            sinalMenos = Properties.Resources.minus_sign;
        }

        /*
         * Altera o ícone do curso do mouse para dar feedback visual 
         * ao saiur/entrar de cima do componente*/
        private void btnPdf_MouseEnter(object sender, EventArgs e)
        {
            btnPdf.Cursor = Cursors.Hand;
        }

        private void btnPdf_MouseLeave(object sender, EventArgs e)
        {
            btnPdf.Cursor = Cursors.Default;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("pdf-leis-kirchhof.pdf");
            }
            catch
            {
                var botao = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Error;
                var titulo = "PDF";
                var mensagem = "Não foi possível abrir o pdf";
                MessageBox.Show(mensagem, titulo, botao, icon);
            }
        }
    }
}
