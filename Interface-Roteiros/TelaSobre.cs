using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface_Roteiros
{
    public partial class TelaSobre : Interface_Roteiros.TelaInicialPadrao
    {
        public TelaSobre()
        {
            InitializeComponent();
        }

        public override void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
