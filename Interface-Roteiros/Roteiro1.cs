﻿using System;
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
    public partial class Roteiro1 : UserControl
    {
        public Roteiro1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }
    }
}