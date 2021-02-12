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
    public partial class TelaAjustes : UserControl
    {
        public TelaAjustes()
        {
            InitializeComponent();

            this.Location = new Point(100, 80);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }

        private void tckResistencia_Scroll(object sender, EventArgs e)
        {
            cpbResistencia.Percentage = tckResistencia.Value;
            lblResistencia.Text = tckResistencia.Value + "Ω";
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = Properties.Resources.cancel;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = Properties.Resources.cancel_hover;
        }
    }
}
