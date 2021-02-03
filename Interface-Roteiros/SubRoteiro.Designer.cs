
namespace Interface_Roteiros
{
    partial class SubRoteiro
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
            this.panRoteiro = new System.Windows.Forms.Panel();
            this.textoRoteiro = new System.Windows.Forms.Label();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.panRoteiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panRoteiro
            // 
            this.panRoteiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.panRoteiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panRoteiro.Controls.Add(this.textoRoteiro);
            this.panRoteiro.Controls.Add(this.imgImagem);
            this.panRoteiro.Location = new System.Drawing.Point(0, 0);
            this.panRoteiro.Name = "panRoteiro";
            this.panRoteiro.Size = new System.Drawing.Size(163, 172);
            this.panRoteiro.TabIndex = 7;
            // 
            // textoRoteiro
            // 
            this.textoRoteiro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRoteiro.ForeColor = System.Drawing.Color.White;
            this.textoRoteiro.Location = new System.Drawing.Point(0, 130);
            this.textoRoteiro.Name = "textoRoteiro";
            this.textoRoteiro.Size = new System.Drawing.Size(159, 41);
            this.textoRoteiro.TabIndex = 1;
            this.textoRoteiro.Text = "Cargas";
            this.textoRoteiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgImagem
            // 
            this.imgImagem.Image = global::Interface_Roteiros.Properties.Resources.circuito1;
            this.imgImagem.Location = new System.Drawing.Point(-1, 3);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(163, 128);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImagem.TabIndex = 0;
            this.imgImagem.TabStop = false;
            this.imgImagem.MouseEnter += new System.EventHandler(this.imgImagem_MouseEnter);
            this.imgImagem.MouseLeave += new System.EventHandler(this.imgImagem_MouseLeave);
            // 
            // SubRoteiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panRoteiro);
            this.Name = "SubRoteiro";
            this.Size = new System.Drawing.Size(163, 172);
            this.panRoteiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panRoteiro;
        private System.Windows.Forms.Label textoRoteiro;
        private System.Windows.Forms.PictureBox imgImagem;
    }
}
