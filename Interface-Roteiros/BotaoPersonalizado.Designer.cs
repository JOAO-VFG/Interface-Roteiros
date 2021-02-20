
namespace Interface_Roteiros
{
    partial class BotaoPersonalizado
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
            this.panBotao = new System.Windows.Forms.Panel();
            this.btnPersonalizado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panBotao
            // 
            this.panBotao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.panBotao.Location = new System.Drawing.Point(0, 95);
            this.panBotao.Name = "panBotao";
            this.panBotao.Size = new System.Drawing.Size(100, 5);
            this.panBotao.TabIndex = 1;
            // 
            // btnPersonalizado
            // 
            this.btnPersonalizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPersonalizado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.btnPersonalizado.FlatAppearance.BorderSize = 0;
            this.btnPersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalizado.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalizado.ForeColor = System.Drawing.Color.White;
            this.btnPersonalizado.Location = new System.Drawing.Point(0, 0);
            this.btnPersonalizado.Name = "btnPersonalizado";
            this.btnPersonalizado.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnPersonalizado.Size = new System.Drawing.Size(100, 96);
            this.btnPersonalizado.TabIndex = 2;
            this.btnPersonalizado.Text = "Text";
            this.btnPersonalizado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonalizado.UseVisualStyleBackColor = true;
            this.btnPersonalizado.Click += new System.EventHandler(this.btnPersonalizado_Click);
            this.btnPersonalizado.MouseEnter += new System.EventHandler(this.btnPersonalizado_MouseEnter);
            this.btnPersonalizado.MouseLeave += new System.EventHandler(this.btnPersonalizado_MouseLeave);
            // 
            // BotaoPersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnPersonalizado);
            this.Controls.Add(this.panBotao);
            this.Name = "BotaoPersonalizado";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.BotaoPersonalizado_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panBotao;
        private System.Windows.Forms.Button btnPersonalizado;
    }
}
