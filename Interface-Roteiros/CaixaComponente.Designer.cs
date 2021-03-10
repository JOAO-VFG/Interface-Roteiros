
namespace Interface_Roteiros
{
    partial class CaixaComponente
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
            this.lblNomeCompoenente = new System.Windows.Forms.Label();
            this.panSelecionado = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNomeCompoenente
            // 
            this.lblNomeCompoenente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeCompoenente.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompoenente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCompoenente.Location = new System.Drawing.Point(0, 0);
            this.lblNomeCompoenente.Name = "lblNomeCompoenente";
            this.lblNomeCompoenente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNomeCompoenente.Size = new System.Drawing.Size(150, 40);
            this.lblNomeCompoenente.TabIndex = 1;
            this.lblNomeCompoenente.Text = "Resistor";
            this.lblNomeCompoenente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNomeCompoenente.Click += new System.EventHandler(this.lblNomeCompoenente_Click);
            // 
            // panSelecionado
            // 
            this.panSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(232)))), ((int)(((byte)(46)))));
            this.panSelecionado.Location = new System.Drawing.Point(0, 0);
            this.panSelecionado.Name = "panSelecionado";
            this.panSelecionado.Size = new System.Drawing.Size(6, 40);
            this.panSelecionado.TabIndex = 1;
            // 
            // CaixaComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.panSelecionado);
            this.Controls.Add(this.lblNomeCompoenente);
            this.MaximumSize = new System.Drawing.Size(150, 150);
            this.MinimumSize = new System.Drawing.Size(150, 40);
            this.Name = "CaixaComponente";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCompoenente;
        private System.Windows.Forms.Panel panSelecionado;
    }
}
