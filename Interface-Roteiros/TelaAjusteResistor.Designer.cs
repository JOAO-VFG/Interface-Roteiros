﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.panPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Resistor";
            // 
            // TelaAjusteResistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(410, 240);
            this.Name = "TelaAjusteResistor";
            this.Titulo = "Resistor";
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.panPainel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
