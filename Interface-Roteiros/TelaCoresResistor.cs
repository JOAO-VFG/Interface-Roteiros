using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaCoresResistor : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaSimulador TelaDeRetorno { get; set; }
        private Graphics g;
        private Pen pen;

        public TelaCoresResistor()
        {
            InitializeComponent();
        }

        private void TelaCoresResistor_Load(object sender, EventArgs e)
        {
            g = imgResistor.CreateGraphics();
        }

        // Desenha algo na primeira faixa do resistor 
        private void DesenharPrimeiraFaixa(Color cor)
        {
            pen = new Pen(cor, 1);
            var rectShape = new Rectangle(new Point(42, 2), new Size(12, 80));

            g.DrawRectangle(pen, rectShape);
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            DesenharPrimeiraFaixa(Color.Black);
        }
    }
}
