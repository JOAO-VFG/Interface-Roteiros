﻿
namespace Interface_Roteiros
{
    partial class TelaPDF
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPDF));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.escolhaRoteiro1 = new Interface_Roteiros.EscolhaRoteiro();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.escolhaRoteiro2 = new Interface_Roteiros.EscolhaRoteiro();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(595, 35);
            this.lblTitulo.Text = "Electrophorus";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.Location = new System.Drawing.Point(558, 5);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.Location = new System.Drawing.Point(519, 5);
            // 
            // imgIcone
            // 
            this.imgIcone.Image = global::Interface_Roteiros.Properties.Resources.circuito_icone;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 125);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(211)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(18, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 100);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demonstração prévia dos exemplos que serão abordados nos respectivos roteiros.\r\n\r" +
    "\nAbaixo clique sobre o ícone de pdf para abrir.";
            // 
            // escolhaRoteiro1
            // 
            this.escolhaRoteiro1.Dock = System.Windows.Forms.DockStyle.Top;
            this.escolhaRoteiro1.ImageRoteiro = ((System.Drawing.Image)(resources.GetObject("escolhaRoteiro1.ImageRoteiro")));
            this.escolhaRoteiro1.Location = new System.Drawing.Point(0, 0);
            this.escolhaRoteiro1.MaximumSize = new System.Drawing.Size(595, 245);
            this.escolhaRoteiro1.MinimumSize = new System.Drawing.Size(595, 45);
            this.escolhaRoteiro1.Name = "escolhaRoteiro1";
            this.escolhaRoteiro1.PathPdf = null;
            this.escolhaRoteiro1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.escolhaRoteiro1.Size = new System.Drawing.Size(595, 45);
            this.escolhaRoteiro1.TabIndex = 7;
            this.escolhaRoteiro1.TituloRoteiro = "Leis de Kirchhof";
            this.escolhaRoteiro1.URL = "https://github.com/JOAO-VFG/Interface-Roteiros/blob/main/PDF\'s/03-Roteiro-Leis-de" +
    "-Kirchhoff.pdf";
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetornar.BackgroundImage")));
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Location = new System.Drawing.Point(4, 2);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(40, 40);
            this.btnRetornar.TabIndex = 8;
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            this.btnRetornar.MouseEnter += new System.EventHandler(this.btnRetornar_MouseEnter);
            this.btnRetornar.MouseLeave += new System.EventHandler(this.btnRetornar_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.btnRetornar);
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 45);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.escolhaRoteiro2);
            this.panel3.Controls.Add(this.escolhaRoteiro1);
            this.panel3.Location = new System.Drawing.Point(0, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 311);
            this.panel3.TabIndex = 10;
            // 
            // escolhaRoteiro2
            // 
            this.escolhaRoteiro2.Dock = System.Windows.Forms.DockStyle.Top;
            this.escolhaRoteiro2.ImageRoteiro = ((System.Drawing.Image)(resources.GetObject("escolhaRoteiro2.ImageRoteiro")));
            this.escolhaRoteiro2.Location = new System.Drawing.Point(0, 45);
            this.escolhaRoteiro2.MaximumSize = new System.Drawing.Size(595, 245);
            this.escolhaRoteiro2.MinimumSize = new System.Drawing.Size(595, 45);
            this.escolhaRoteiro2.Name = "escolhaRoteiro2";
            this.escolhaRoteiro2.PathPdf = null;
            this.escolhaRoteiro2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.escolhaRoteiro2.Size = new System.Drawing.Size(595, 45);
            this.escolhaRoteiro2.TabIndex = 8;
            this.escolhaRoteiro2.TituloRoteiro = "Potência e Divisor de Corrente";
            this.escolhaRoteiro2.URL = "https://github.com/JOAO-VFG/Interface-Roteiros/blob/main/PDF\'s/02-Roteiro%20-%20P" +
    "otencia-e-divisor-de-corrente.pdf";
            // 
            // TelaPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 515);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPDF";
            this.Text = "Electrophorus";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private EscolhaRoteiro escolhaRoteiro1;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private EscolhaRoteiro escolhaRoteiro2;
    }
}
