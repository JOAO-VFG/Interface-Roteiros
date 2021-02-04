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
    public partial class Roteiro : UserControl
    {
        public Image ImagemRoteiro
        {
            get { return imgImagem.Image; }
            set { imgImagem.Image = value; }
        }

        public string TextoRoteiro
        {
            get { return lblTexto.Text; }
            set { lblTexto.Text = value; }
        }

        public string TextoTitulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public Roteiro()
        {
            InitializeComponent();
            lblTitulo.Text = "Cargas";
            lblTexto.Text = "No roteiro 1 será abordado o conteúdo X onde aprederemos diversas coisas sobre tal coisa";
            imgImagem.Image = Properties.Resources.circuito7;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }
    }
}
