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
    }
}
