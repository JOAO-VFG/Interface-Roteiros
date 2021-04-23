
namespace Interface_Roteiros
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boxPdf = new Interface_Roteiros.BoxInformacao();
            this.boxSobre = new Interface_Roteiros.BoxInformacao();
            this.boxSimulador = new Interface_Roteiros.BoxInformacao();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(550, 35);
            this.lblTitulo.Text = "Electrophorus";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.Location = new System.Drawing.Point(516, 5);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.Location = new System.Drawing.Point(477, 5);
            // 
            // imgIcone
            // 
            this.imgIcone.Image = global::Interface_Roteiros.Properties.Resources.circuito_icone;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface_Roteiros.Properties.Resources.circuito_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(180, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 140);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Location = new System.Drawing.Point(365, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 140);
            this.panel2.TabIndex = 9;
            // 
            // boxPdf
            // 
            this.boxPdf.ColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(161)))));
            this.boxPdf.ColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.boxPdf.ImagemDaCaixa = global::Interface_Roteiros.Properties.Resources.pdf;
            this.boxPdf.Location = new System.Drawing.Point(185, 343);
            this.boxPdf.Name = "boxPdf";
            this.boxPdf.Size = new System.Drawing.Size(180, 140);
            this.boxPdf.TabIndex = 7;
            this.boxPdf.Tela = null;
            this.boxPdf.TelaDeRetorno = null;
            this.boxPdf.TextoDaCaixa = "Cada roteiro tem seu pdf anexado no programa visando auxiliar nos estudos de circ" +
    "uítos elétricos.";
            this.boxPdf.TextOnEnter = System.Drawing.Color.White;
            this.boxPdf.TextOnLeave = System.Drawing.Color.Black;
            this.boxPdf.TituloDaCaixa = "PDF\'s";
            // 
            // boxSobre
            // 
            this.boxSobre.ColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(230)))), ((int)(((byte)(106)))));
            this.boxSobre.ColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(179)))), ((int)(((byte)(114)))));
            this.boxSobre.ImagemDaCaixa = global::Interface_Roteiros.Properties.Resources.sobre_icone;
            this.boxSobre.Location = new System.Drawing.Point(0, 343);
            this.boxSobre.Name = "boxSobre";
            this.boxSobre.Size = new System.Drawing.Size(180, 140);
            this.boxSobre.TabIndex = 6;
            this.boxSobre.Tela = null;
            this.boxSobre.TelaDeRetorno = null;
            this.boxSobre.TextoDaCaixa = "Software voltado para o estudo e aplicação dos assuntos de circuítos elétricos.";
            this.boxSobre.TextOnEnter = System.Drawing.Color.White;
            this.boxSobre.TextOnLeave = System.Drawing.Color.Black;
            this.boxSobre.TituloDaCaixa = "Sobre";
            // 
            // boxSimulador
            // 
            this.boxSimulador.ColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(36)))), ((int)(((byte)(240)))));
            this.boxSimulador.ColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(83)))), ((int)(((byte)(252)))));
            this.boxSimulador.ImagemDaCaixa = global::Interface_Roteiros.Properties.Resources.simulation;
            this.boxSimulador.Location = new System.Drawing.Point(370, 343);
            this.boxSimulador.Name = "boxSimulador";
            this.boxSimulador.Size = new System.Drawing.Size(180, 140);
            this.boxSimulador.TabIndex = 5;
            this.boxSimulador.Tela = null;
            this.boxSimulador.TelaDeRetorno = null;
            this.boxSimulador.TextoDaCaixa = "Roteiros dispõem de circuíto elétrico para o aluno exercitar seus conhecimentos.";
            this.boxSimulador.TextOnEnter = System.Drawing.Color.White;
            this.boxSimulador.TextOnLeave = System.Drawing.Color.Black;
            this.boxSimulador.TituloDaCaixa = "Simulador";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(550, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boxPdf);
            this.Controls.Add(this.boxSobre);
            this.Controls.Add(this.boxSimulador);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.Text = "Electrophorus";
            this.Load += new System.EventHandler(this.NovaTelaInicial_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.boxSimulador, 0);
            this.Controls.SetChildIndex(this.boxSobre, 0);
            this.Controls.SetChildIndex(this.boxPdf, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private BoxInformacao boxSimulador;
        private BoxInformacao boxSobre;
        private BoxInformacao boxPdf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
