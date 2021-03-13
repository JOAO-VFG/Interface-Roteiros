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
    public partial class PainelBateria : UserControl
    {
        public Label LabelFonte { get; set; }
        public Bateria Bateria { get; set; }
        public PainelBateria()
        {
            InitializeComponent();
        }

        private void PainelBateria_Load(object sender, EventArgs e)
        {
            xuiCircleProgressBar1.IsAnimated = true;
        }

        private void trackTensao_Scroll(object sender, EventArgs e)
        {
            var valor = trackTensao.Value;
            LabelFonte.Text = lblTensao.Text = $"{valor}V";
        }
    }
}
