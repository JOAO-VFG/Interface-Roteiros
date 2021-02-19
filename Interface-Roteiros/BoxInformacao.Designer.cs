
namespace Interface_Roteiros
{
    partial class BoxInformacao
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxInformacao));
            this.panTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panTexto = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.panTitulo.SuspendLayout();
            this.panTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitulo
            // 
            this.panTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.panTitulo.Controls.Add(this.lblTitulo);
            this.panTitulo.Controls.Add(this.imgImagem);
            this.panTitulo.Location = new System.Drawing.Point(0, 0);
            this.panTitulo.Name = "panTitulo";
            this.panTitulo.Size = new System.Drawing.Size(180, 32);
            this.panTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(33, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(144, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Simulador";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panTexto
            // 
            this.panTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(56)))), ((int)(((byte)(224)))));
            this.panTexto.Controls.Add(this.lblTexto);
            this.panTexto.Location = new System.Drawing.Point(0, 32);
            this.panTexto.Name = "panTexto";
            this.panTexto.Size = new System.Drawing.Size(180, 108);
            this.panTexto.TabIndex = 1;
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTexto.Location = new System.Drawing.Point(3, -3);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lblTexto.Size = new System.Drawing.Size(174, 105);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Cada tópico dispõe de um circuito organizado para que o aluno possa testar seus c" +
    "onhecimentos.";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            this.lblTexto.MouseEnter += new System.EventHandler(this.lblTexto_MouseEnter);
            this.lblTexto.MouseLeave += new System.EventHandler(this.lblTexto_MouseLeave);
            // 
            // imgImagem
            // 
            this.imgImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgImagem.BackgroundImage")));
            this.imgImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgImagem.Location = new System.Drawing.Point(3, 0);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(32, 32);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImagem.TabIndex = 8;
            this.imgImagem.TabStop = false;
            // 
            // BoxInformacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panTexto);
            this.Controls.Add(this.panTitulo);
            this.Name = "BoxInformacao";
            this.Size = new System.Drawing.Size(180, 140);
            this.Load += new System.EventHandler(this.BoxInformacao_Load);
            this.panTitulo.ResumeLayout(false);
            this.panTexto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitulo;
        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panTexto;
        private System.Windows.Forms.Label lblTexto;
    }
}
