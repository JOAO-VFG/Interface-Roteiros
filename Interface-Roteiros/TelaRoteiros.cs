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

            // Leis de Ohm
            subRoteiro2.ImagemRoteiro = Properties.Resources.circuito2;
            subRoteiro2.TextoRoteiro = "Leis de Ohm";
            // Leis de Kirchhof
            subRoteiro3.ImagemRoteiro = Properties.Resources.circuito3;
            subRoteiro3.TextoRoteiro = "Leis de Kirchhof";
            // Super nós e super malhas
            subRoteiro4.ImagemRoteiro = Properties.Resources.circuito4;
            subRoteiro4.TextoRoteiro = "Super Nós e Super Malhas";
            // Teorema de Thevennin e Norton
            subRoteiro5.ImagemRoteiro = Properties.Resources.circuito5;
            subRoteiro5.TextoRoteiro = "Teorema de\nNorthon e Thevannin";
            // Teorema da Superposição e Transformação de Fontes
            subRoteiro6.ImagemRoteiro = Properties.Resources.circuito6;
            subRoteiro6.TextoRoteiro = "Teorema da Superposição";
        }
    }
}
