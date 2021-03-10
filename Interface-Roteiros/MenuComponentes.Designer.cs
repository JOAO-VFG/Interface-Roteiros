
namespace Interface_Roteiros
{
    partial class MenuComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuComponentes));
            this.label1 = new System.Windows.Forms.Label();
            this.caixaComponente1 = new Interface_Roteiros.CaixaComponente();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(41)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(7)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORMAÇÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caixaComponente1
            // 
            this.caixaComponente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.caixaComponente1.CorOnSelected = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(232)))), ((int)(((byte)(46)))));
            this.caixaComponente1.ImagemComponent = ((System.Drawing.Image)(resources.GetObject("caixaComponente1.ImagemComponent")));
            this.caixaComponente1.Location = new System.Drawing.Point(0, 67);
            this.caixaComponente1.MaximumSize = new System.Drawing.Size(150, 230);
            this.caixaComponente1.MinimumSize = new System.Drawing.Size(150, 40);
            this.caixaComponente1.Name = "caixaComponente1";
            this.caixaComponente1.Nome = "Resistor";
            this.caixaComponente1.Size = new System.Drawing.Size(150, 230);
            this.caixaComponente1.TabIndex = 1;
            // 
            // MenuComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.caixaComponente1);
            this.Controls.Add(this.label1);
            this.Name = "MenuComponentes";
            this.Size = new System.Drawing.Size(150, 592);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CaixaComponente caixaComponente1;
    }
}
