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
    public partial class BotaoPersonalizado : UserControl
    {
        public Image Image
        {
            get { return btnPersonalizado.BackgroundImage; }
            set { btnPersonalizado.BackgroundImage = value; }
        }

        public string Texto
        {
            get { return lblTexto.Text; }
            set { lblTexto.Text = value; }
        }

        private Color corHover = Color.FromArgb(22, 32, 82);
        private Color cor = Color.FromArgb(20, 25, 54);
        private Color corTexto = Color.FromArgb(28, 178, 237);

        public BotaoPersonalizado()
        {
            InitializeComponent();
        }

        private void btnPersonalizado_MouseEnter(object sender, EventArgs e)
        {
            lblTexto.BackColor = btnPersonalizado.BackColor = corHover;
            panBotao.BackColor = Color.White;
            lblTexto.ForeColor = Color.White;
        }

        private void btnPersonalizado_MouseLeave(object sender, EventArgs e)
        {
            btnPersonalizado.BackColor = cor;
            lblTexto.BackColor = cor;
            panBotao.BackColor = cor;
            lblTexto.ForeColor = corTexto;
        }
    }
}
