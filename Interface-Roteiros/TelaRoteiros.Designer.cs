
namespace Interface_Roteiros
{
    partial class TelaRoteiros
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
            this.panRoteiros = new System.Windows.Forms.Panel();
            this.subRoteiro6 = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro5 = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro4 = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro3 = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro2 = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro1 = new Interface_Roteiros.SubRoteiro();
            this.panRoteiros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panRoteiros
            // 
            this.panRoteiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.panRoteiros.Controls.Add(this.subRoteiro6);
            this.panRoteiros.Controls.Add(this.subRoteiro5);
            this.panRoteiros.Controls.Add(this.subRoteiro4);
            this.panRoteiros.Controls.Add(this.subRoteiro3);
            this.panRoteiros.Controls.Add(this.subRoteiro2);
            this.panRoteiros.Controls.Add(this.subRoteiro1);
            this.panRoteiros.Location = new System.Drawing.Point(0, 0);
            this.panRoteiros.Name = "panRoteiros";
            this.panRoteiros.Size = new System.Drawing.Size(580, 402);
            this.panRoteiros.TabIndex = 0;
            // 
            // subRoteiro6
            // 
            this.subRoteiro6.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito6;
            this.subRoteiro6.Location = new System.Drawing.Point(399, 211);
            this.subRoteiro6.Name = "subRoteiro6";
            this.subRoteiro6.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro6.TabIndex = 14;
            this.subRoteiro6.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro6.TextoRoteiro = "Teorema da Superposição";
            this.subRoteiro6.Click += new System.EventHandler(this.subRoteiro6_Click);
            // 
            // subRoteiro5
            // 
            this.subRoteiro5.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito5;
            this.subRoteiro5.Location = new System.Drawing.Point(210, 211);
            this.subRoteiro5.Name = "subRoteiro5";
            this.subRoteiro5.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro5.TabIndex = 13;
            this.subRoteiro5.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro5.TextoRoteiro = "Teorema de Northon e Thevannin";
            this.subRoteiro5.Click += new System.EventHandler(this.subRoteiro5_Click);
            // 
            // subRoteiro4
            // 
            this.subRoteiro4.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito4;
            this.subRoteiro4.Location = new System.Drawing.Point(23, 211);
            this.subRoteiro4.Name = "subRoteiro4";
            this.subRoteiro4.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro4.TabIndex = 12;
            this.subRoteiro4.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro4.TextoRoteiro = "Super Nós e Super Malhas";
            this.subRoteiro4.Click += new System.EventHandler(this.subRoteiro4_Click);
            // 
            // subRoteiro3
            // 
            this.subRoteiro3.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito3;
            this.subRoteiro3.Location = new System.Drawing.Point(399, 21);
            this.subRoteiro3.Name = "subRoteiro3";
            this.subRoteiro3.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro3.TabIndex = 11;
            this.subRoteiro3.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro3.TextoRoteiro = "Leis de Kirchhof";
            this.subRoteiro3.Click += new System.EventHandler(this.subRoteiro3_Click);
            // 
            // subRoteiro2
            // 
            this.subRoteiro2.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito2;
            this.subRoteiro2.Location = new System.Drawing.Point(210, 21);
            this.subRoteiro2.Name = "subRoteiro2";
            this.subRoteiro2.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro2.TabIndex = 10;
            this.subRoteiro2.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro2.TextoRoteiro = "Leis de Ohm";
            this.subRoteiro2.Load += new System.EventHandler(this.subRoteiro2_Load);
            this.subRoteiro2.Click += new System.EventHandler(this.subRoteiro2_Click);
            // 
            // subRoteiro1
            // 
            this.subRoteiro1.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito7;
            this.subRoteiro1.Location = new System.Drawing.Point(23, 21);
            this.subRoteiro1.Name = "subRoteiro1";
            this.subRoteiro1.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro1.TabIndex = 1;
            this.subRoteiro1.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro1.TextoRoteiro = "Cargas";
            this.subRoteiro1.Click += new System.EventHandler(this.subRoteiro1_Click);
            // 
            // TelaRoteiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panRoteiros);
            this.Name = "TelaRoteiros";
            this.Size = new System.Drawing.Size(580, 402);
            this.panRoteiros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panRoteiros;
        private SubRoteiro subRoteiro1;
        private SubRoteiro subRoteiro2;
        private SubRoteiro subRoteiro3;
        private SubRoteiro subRoteiro4;
        private SubRoteiro subRoteiro5;
        private SubRoteiro subRoteiro6;
    }
}
