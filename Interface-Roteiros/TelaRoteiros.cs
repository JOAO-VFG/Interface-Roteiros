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
    public partial class TelaRoteiros : UserControl
    {
        public TelaRoteiros()
        {
            InitializeComponent();
        }

        // Acontece o mouse passa por cima de algum item na tela
        private void AoEntrar(Panel painel, Label texto)
        {
            painel.BackColor = Color.FromArgb(227, 217, 20);
            texto.ForeColor = Color.Black;
        }
        
        // Acontece quando o mouse sai de algum item na tela
        private void AoSair(Panel painel, Label texto)
        {
            painel.BackColor = Color.FromArgb(68, 78, 158);
            texto.ForeColor = Color.White;
        }

        private void imgRoteiro1_MouseEnter(object sender, EventArgs e)
        {
            AoEntrar(panRoteiro1, lblRoteiro1);
        }

        private void imgRoteiro1_MouseLeave(object sender, EventArgs e)
        {
            AoSair(panRoteiro1, lblRoteiro1);
        }

        private void imgRoteiro2_MouseEnter(object sender, EventArgs e)
        {
            AoEntrar(panRoteiro2, lblRoteiro2);
        }

        private void imgRoteiro2_MouseLeave(object sender, EventArgs e)
        {
            AoSair(panRoteiro2, lblRoteiro2);
        }

        private void imgRoteiro3_MouseEnter(object sender, EventArgs e)
        {
            AoEntrar(panRoteiro3, lblRoteiro3);
        }

        private void imgRoteiro3_MouseLeave(object sender, EventArgs e)
        {
            AoSair(panRoteiro3, lblRoteiro3);
        }

        private void imgRoteiro4_MouseEnter(object sender, EventArgs e)
        {
            AoEntrar(panRoteiro4, lblRoteiro4);
        }

        private void imgRoteiro4_MouseLeave(object sender, EventArgs e)
        {
            AoSair(panRoteiro4, lblRoteiro4);
        }

        private void imgRoteiro5_MouseEnter(object sender, EventArgs e)
        {
            AoEntrar(panRoteiro5, lblRoteiro5);
        }

        private void imgRoteiro5_MouseLeave(object sender, EventArgs e)
        {
            AoSair(panRoteiro5, lblRoteiro5);
        }

        private void imgRoteiro6_MouseEnter(object sender, EventArgs e)
        {
            AoEntrar(panRoteiro6, lblRoteiro6);
        }

        private void imgRoteiro6_MouseLeave(object sender, EventArgs e)
        {
            AoSair(panRoteiro6, lblRoteiro6);
        }
    }
}
