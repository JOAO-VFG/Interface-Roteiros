
namespace Interface_Roteiros
{
    partial class TelaAjusteResistor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAjusteResistor));
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckSlider)).BeginInit();
            this.panPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Resistor";
            // 
            // tckSlider
            // 
            this.tckSlider.Scroll += new System.EventHandler(this.tckSlider_Scroll);
            // 
            // TelaAjusteResistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(410, 240);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAjusteResistor";
            this.Titulo = "Resistor";
            this.Load += new System.EventHandler(this.TelaAjusteResistor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckSlider)).EndInit();
            this.panPainel.ResumeLayout(false);
            this.panPainel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
