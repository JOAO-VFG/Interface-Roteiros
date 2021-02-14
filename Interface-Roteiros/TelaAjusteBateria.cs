using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaAjusteBateria : Interface_Roteiros.TelaAjustePadrao
    {
        public TelaAjusteBateria()
        {
            InitializeComponent();
        }

        private void tckTensao_Scroll(object sender, EventArgs e)
        {
            var valor = tckTensao.Value;
            lblTensao.Text = valor.ToString() + "V";
            cpbTensao.Percentage = valor;
        }
    }
}
