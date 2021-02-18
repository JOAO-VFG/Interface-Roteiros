
namespace Interface_Roteiros
{
    partial class TelaSimulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSimulador));
            this.telaRoteiros1 = new Interface_Roteiros.TelaRoteiros();
            this.btnRetornar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(580, 35);
            this.lblTitulo.Text = "Simuladores";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.Location = new System.Drawing.Point(543, 5);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.Location = new System.Drawing.Point(504, 5);
            // 
            // telaRoteiros1
            // 
            this.telaRoteiros1.Location = new System.Drawing.Point(0, 35);
            this.telaRoteiros1.Name = "telaRoteiros1";
            this.telaRoteiros1.Size = new System.Drawing.Size(575, 390);
            this.telaRoteiros1.TabIndex = 4;
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.btnRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetornar.BackgroundImage")));
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Location = new System.Drawing.Point(254, 420);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(70, 54);
            this.btnRetornar.TabIndex = 6;
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // TelaSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(575, 475);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.telaRoteiros1);
            this.Name = "TelaSimulador";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.telaRoteiros1, 0);
            this.Controls.SetChildIndex(this.btnRetornar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TelaRoteiros telaRoteiros1;
        private System.Windows.Forms.Button btnRetornar;
    }
}
