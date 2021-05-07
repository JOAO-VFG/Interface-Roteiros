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
        private SolidBrush brush;
        private Rectangle rect;

        public TelaCoresResistor()
        {
            InitializeComponent();
        }

        private void TelaCoresResistor_Load(object sender, EventArgs e)
        {
            boxFaixa1.Text = "sfdgf";
        }

        // Desenha em alguma das faixas
        private void Desenhar(Color cor, int faixa)
        {
            g = imgResistor.CreateGraphics();
            brush = new SolidBrush(cor);
            pen = new Pen(cor, 1);
            rect = new Rectangle();

            switch (faixa)
            {
                case 1:
                    //rect = new Rectangle(new Point(42, 2), new Size(12, 79));
                    rect = new Rectangle(new Point(79, 4), new Size(24, 159));
                    break;
                case 2:
                    //rect = new Rectangle(new Point(74, 14), new Size(16, 55));
                    rect = new Rectangle(new Point(143, 28), new Size(32, 111));
                    break;
                case 3:
                    //rect = new Rectangle(new Point(110, 14), new Size(16, 55));
                    rect = new Rectangle(new Point(215, 28), new Size(32, 111));
                    break;
                case 4:
                    //rect = new Rectangle(new Point(146, 14), new Size(16, 55));
                    rect = new Rectangle(new Point(287, 28), new Size(32, 111));
                    break;
                case 5:
                    //rect = new Rectangle(new Point(182, 2), new Size(12, 79));
                    rect = new Rectangle(new Point(359, 4), new Size(24, 159));
                    break;
            }

            // Desenha e preenche o retângulo
            g.DrawRectangle(pen, rect);
            g.FillRectangle(brush, rect);

            // Elimina o que não é mais usado
            pen.Dispose();
            brush.Dispose();
            g.Dispose();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Desenhar(Color.Black, 4);
        }
        
    }
}
