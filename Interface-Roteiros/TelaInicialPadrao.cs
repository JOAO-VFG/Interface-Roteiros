using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Interface_Roteiros
{
    public partial class TelaInicialPadrao : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Imagem de minimizar
        private Image minimizeOff = Properties.Resources.minimize2;
        private Image minimizeOn = Properties.Resources.minimize;
        // Imagem de fechar
        private Image cancelOff = Properties.Resources.cancel_hover;
        private Image cancelOn = Properties.Resources.cancel2;

        public TelaInicialPadrao()
        {
            InitializeComponent();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public virtual void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackgroundImage = minimizeOn;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackgroundImage = minimizeOff;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = cancelOn;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = cancelOff;
        }
    }
}
