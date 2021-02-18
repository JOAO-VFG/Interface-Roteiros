
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
            this.escolhaRoteiro1 = new Interface_Roteiros.EscolhaRoteiro();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(615, 35);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.Location = new System.Drawing.Point(585, 5);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.Location = new System.Drawing.Point(546, 5);
            // 
            // escolhaRoteiro1
            // 
            this.escolhaRoteiro1.ImageRoteiro = ((System.Drawing.Image)(resources.GetObject("escolhaRoteiro1.ImageRoteiro")));
            this.escolhaRoteiro1.Location = new System.Drawing.Point(41, 194);
            this.escolhaRoteiro1.MaximumSize = new System.Drawing.Size(396, 265);
            this.escolhaRoteiro1.MinimumSize = new System.Drawing.Size(396, 45);
            this.escolhaRoteiro1.Name = "escolhaRoteiro1";
            this.escolhaRoteiro1.PathPdf = null;
            this.escolhaRoteiro1.Size = new System.Drawing.Size(396, 45);
            this.escolhaRoteiro1.TabIndex = 4;
            this.escolhaRoteiro1.TituloRoteiro = "Teorema de Norton e Thévenin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 125);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Há uma previa sobre qual tipo de exércicio será discutido e exemplificado clicand" +
    "o-se sobre o nome do assunto.\r\n\r\nAbaixo clique sobre o ícone de pdf para abrir";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(211)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(18, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 100);
            this.panel2.TabIndex = 6;
            // 
            // TelaPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(615, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.escolhaRoteiro1);
            this.Name = "TelaPDF";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.escolhaRoteiro1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EscolhaRoteiro escolhaRoteiro1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
