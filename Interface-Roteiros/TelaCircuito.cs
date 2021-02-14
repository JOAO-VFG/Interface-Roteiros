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
    public partial class TelaCircuito : Form
    {
        private TelaAjusteResistor telaResistor1;
        public TelaCircuito()
        {
            InitializeComponent();
        }

        private void btnResistor1_Click(object sender, EventArgs e)
        {
            telaResistor1.Show();
        }

        private void TelaCircuito_Load(object sender, EventArgs e)
        {
            telaResistor1 = new TelaAjusteResistor();
        }
    }
}
