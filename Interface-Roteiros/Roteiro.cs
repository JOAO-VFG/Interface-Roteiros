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
    public partial class Roteiro : UserControl
    {
        public Image ImagemRoteiro
        {
            get { return imgImagem.Image; }
            set { imgImagem.Image = value; }
        }

        public string TextoRoteiro
        {
            get => textoRoteiro.Text;
            set => textoRoteiro.Text = value;
        }
        
        public Font TextoFont
        {
            get { return textoRoteiro.Font; }
            set { textoRoteiro.Font = value; }
        }

        public Roteiro()
        {
            InitializeComponent();
        }

        private void imgImagem_MouseEnter(object sender, EventArgs e)
        {
            panRoteiro.BackColor = Color.FromArgb(227, 217, 20);
            textoRoteiro.ForeColor = Color.Black;
        }

        private void imgImagem_MouseLeave(object sender, EventArgs e)
        {
            panRoteiro.BackColor = Color.FromArgb(68, 78, 158);
            textoRoteiro.ForeColor = Color.White;
        }

        private void imgImagem_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
