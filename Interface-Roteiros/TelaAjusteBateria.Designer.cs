
namespace Interface_Roteiros
{
    partial class TelaAjusteBateria
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
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckSlider)).BeginInit();
            this.panPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.Text = "20V";
            // 
            // tckSlider
            // 
            this.tckSlider.Scroll += new System.EventHandler(this.tckSlider_Scroll);
            // 
            // lblGrandeza
            // 
            this.lblGrandeza.Text = "Tensão";
            // 
            // TelaAjusteBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(410, 240);
            this.Name = "TelaAjusteBateria";
            this.Load += new System.EventHandler(this.TelaAjusteBateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckSlider)).EndInit();
            this.panPainel.ResumeLayout(false);
            this.panPainel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
