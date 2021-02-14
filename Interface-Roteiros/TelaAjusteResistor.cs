using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaAjusteResistor : Form
    {
        // Permite mover a tela
        // ================================================================================
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // ================================================================================

        public TelaAjusteResistor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = Properties.Resources.cancel;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = Properties.Resources.cancel_hover;
        }

        // Move a tela
        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TelaAjusteResistor_Load(object sender, EventArgs e)
        {
            // Posição inicial da tela
            this.Location = new Point(190, 35);
        }
    }
}
