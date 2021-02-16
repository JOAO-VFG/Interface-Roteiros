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
            get { return btnPersonalizado.Text; }
            set { btnPersonalizado.Text = value; }
        }

        private readonly Color azulClaro = Color.FromArgb(22, 32, 82);
        private readonly Color fundo = Color.FromArgb(20, 25, 54);
        private readonly Color amarelo = Color.FromArgb(245, 241, 15);

        public BotaoPersonalizado()
        {
            InitializeComponent();
            
        }

        private void BotaoPersonalizado_Load(object sender, EventArgs e)
        {
        }

        private void btnPersonalizado_MouseEnter(object sender, EventArgs e)
        {
            panBotao.BackColor = amarelo;
            btnPersonalizado.BackColor = azulClaro;
        }

        private void btnPersonalizado_MouseLeave(object sender, EventArgs e)
        {
            btnPersonalizado.BackColor = fundo;
            panBotao.BackColor = fundo;
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
