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

        double multiplicador;
        string tolerancia;

        enum Estado
        {
            Faixa, Multiplicador, Tolerancia
        }

        public TelaCoresResistor()
        {
            InitializeComponent();
        }

        private void TelaCoresResistor_Load(object sender, EventArgs e)
        {
            faixas = new ComboBox[5]{ boxFaixa1, boxFaixa2, boxFaixa3, boxFaixa4, boxFaixa5 };
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

        // Cor para os dígitos
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

        // Cor para o multiplicador
        // E já calcula o multiplicador baseado na cor
        private Color CorMultiplicador(int posicao)
        {
            switch(posicao)
            {
                case 1:
                    multiplicador = Math.Pow(10, -2);
                    return Color.Silver;
                case 2:
                    multiplicador = Math.Pow(10, -1);
                    return Color.Gold;
                case 3:
                    multiplicador = 1;
                    return Color.Black;
                case 4:
                    multiplicador = 10;
                    return Color.Brown;
                case 5:
                    multiplicador = Math.Pow(10, 2);
                    return Color.Red;
                case 6:
                    multiplicador = Math.Pow(10, 3);
                    return Color.Orange;
                case 7:
                    multiplicador = Math.Pow(10, 4);
                    return Color.Yellow;
                case 8:
                    multiplicador = Math.Pow(10, 5);
                    return Color.Green;
                case 9:
                    multiplicador = Math.Pow(10, 6);
                    return Color.Blue;
                default:
                    multiplicador = Math.Pow(10, 7);
                    return Color.Violet;
            }
        }

        // Escolhe a cor para tolerância baseado na posição
        // E salva o valor associado a ela em um campo
        private Color CorTolerancia(int posicao)
        {
            switch(posicao)
            {
                case 1:
                    tolerancia = "10%";
                    return Color.Silver;
                case 2:
                    tolerancia = "5%";
                    return Color.Gold;
                case 3:
                    tolerancia = "1%";
                    return Color.Brown;
                case 4:
                    tolerancia = "2%";
                    return Color.Red;
                case 5:
                    tolerancia = "0.5%";
                    return Color.Green;
                case 6:
                    tolerancia = "0.25%";
                    return Color.Blue;
                default:
                    tolerancia = "0.1%";
                    return Color.Violet;
            }
        }

        private void TrocarCorDoResistor(ComboBox boxFaixa, int faixa, Estado modo)
        {
            // Index é quando o usuário seleciono 'Selecione uma cor'
            // Como essa opção não é valida n faz nada
            if (boxFaixa.SelectedIndex != 0)
            {
                /*
                 * Caso seja o multiplicador, então a cor para pintura será diferente das anteriores
                 */
                if (modo == Estado.Multiplicador)
                {
                    Desenhar(CorMultiplicador(boxFaixa.SelectedIndex), faixa);
                } else if (modo == Estado.Faixa)
                {
                    Desenhar(CorEscolhida(boxFaixa.SelectedIndex), faixa);
                } else if (modo == Estado.Tolerancia)
                {
                    Desenhar(CorTolerancia(boxFaixa.SelectedIndex), faixa);
                }
            }
        }

        // Desenha algo na 1° faixa
        private void boxFaixa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarInterface(boxFaixa1, 1, Estado.Faixa);
        }

        // Desenha algo na 2° faixa
        private void boxFaixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarInterface(boxFaixa2, 2, Estado.Faixa);
        }

        // Desenha algo na 3° Faixa
        private void boxFaixa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarInterface(boxFaixa3, 3, Estado.Faixa);
        }

        private void boxFaixa4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarInterface(boxFaixa4, 4, Estado.Multiplicador);
        }

        private void boxFaixa5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarInterface(boxFaixa5, 5, Estado.Tolerancia);
        }

        // Calcula o valor da resistência
        private void CalcularResistencia()
        {
            int centena = (boxFaixa1.SelectedIndex - 1) * 100;
            int dezena = (boxFaixa2.SelectedIndex - 1) * 10;
            int unidade = boxFaixa3.SelectedIndex - 1;
            double valor = (centena + dezena + unidade) * multiplicador;

            boxResultado.Text = $"{AjustarValor(valor)}Ω {tolerancia}";
        }

        // Atualiza os dados presentes na janela
        private void AtualizarInterface(ComboBox box, int faixa, Estado estado)
        {
            TrocarCorDoResistor(box, faixa, estado);

            int selecionadas = 0;
            foreach (var comboBox in faixas)
            {
                if (comboBox.SelectedIndex != 0)
                {
                    selecionadas++;
                }
            }

            if (selecionadas == faixas.Length)
            {
                CalcularResistencia();
            }
        }

        // Converte número muitos grandes para a notação correspondente
        private string AjustarValor(double valor)
        {
            if (valor >= Math.Pow(10, 6))
            {
                valor /= Math.Pow(10, 6);
                return $"{valor} M";
            } else if (valor >= Math.Pow(10, 3))
            {
                valor /= Math.Pow(10, 3);
                return $"{valor} K";
            } else
            {
                return $"{valor}";
            }
        }
    }
}
