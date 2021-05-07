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
        ComboBox[] faixas;
        // Desenho
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
            faixas = new ComboBox[4]{ boxFaixa1, boxFaixa2, boxFaixa3, boxFaixa4 };
            foreach (var i in faixas)
            {
                i.SelectedIndex = 0;
            }
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

        private Color CorEscolhida(int posicaoNaLista)
        {
            switch(posicaoNaLista)
            {
                case 1:
                    return Color.Black;
                case 2:
                    return Color.Brown;
                case 3:
                    return Color.Red;
                case 4:
                    return Color.Orange;
                case 5:
                    return Color.Yellow;
                case 6:
                    return Color.Green;
                case 7:
                    return Color.Blue;
                case 8:
                    return Color.Violet;
                case 9:
                    return Color.Gray;
                default:
                    return Color.White;
            }
        }

        private void TrocarCorDoResistor(ComboBox boxFaixa, int faixa)
        {
            // Index é quando o usuário seleciono 'Selecione uma cor'
            // Como essa opção não é valida n faz nada
            if (boxFaixa.SelectedIndex != 0)
            {
                Desenhar(CorEscolhida(boxFaixa.SelectedIndex), faixa);
            }
        }

        // Desenha algo na 1° faixa
        private void boxFaixa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrocarCorDoResistor(boxFaixa1, 1);
        }

        // Desenha algo na 2° faixa
        private void boxFaixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrocarCorDoResistor(boxFaixa2, 2);
        }

        // Desenha algo na 3° Faixa
        private void boxFaixa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrocarCorDoResistor(boxFaixa3, 3);
        }
    }
}
