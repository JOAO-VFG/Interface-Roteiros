
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
            this.subRoteiro1 = new Interface_Roteiros.SubRoteiro();
            this.rtrLeisOhm = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro3 = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro4 = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro5 = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro6 = new Interface_Roteiros.SubRoteiro();
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
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.Location = new System.Drawing.Point(504, 5);
            // 
            // imgIcone
            // 
            this.imgIcone.Image = global::Interface_Roteiros.Properties.Resources.circuito_icone;
            // 
            // subRoteiro1
            // 
            this.subRoteiro1.ImagemRoteiro = ((System.Drawing.Image)(resources.GetObject("subRoteiro1.ImagemRoteiro")));
            this.subRoteiro1.Location = new System.Drawing.Point(23, 94);
            this.subRoteiro1.Name = "subRoteiro1";
            this.subRoteiro1.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro1.TabIndex = 4;
            this.subRoteiro1.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro1.TextoRoteiro = "Cargas";
            // 
            // rtrLeisOhm
            // 
            this.rtrLeisOhm.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito2;
            this.rtrLeisOhm.Location = new System.Drawing.Point(207, 94);
            this.rtrLeisOhm.Name = "rtrLeisOhm";
            this.rtrLeisOhm.Size = new System.Drawing.Size(163, 172);
            this.rtrLeisOhm.TabIndex = 5;
            this.rtrLeisOhm.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtrLeisOhm.TextoRoteiro = "Leis de Ohm";
            this.rtrLeisOhm.Click += new System.EventHandler(this.rtrLeisOhm_Click);
            // 
            // subRoteiro3
            // 
            this.subRoteiro3.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito3;
            this.subRoteiro3.Location = new System.Drawing.Point(389, 94);
            this.subRoteiro3.Name = "subRoteiro3";
            this.subRoteiro3.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro3.TabIndex = 6;
            this.subRoteiro3.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro3.TextoRoteiro = "Leis de Kirchhof";
            // 
            // subRoteiro4
            // 
            this.subRoteiro4.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito4;
            this.subRoteiro4.Location = new System.Drawing.Point(23, 291);
            this.subRoteiro4.Name = "subRoteiro4";
            this.subRoteiro4.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro4.TabIndex = 7;
            this.subRoteiro4.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro4.TextoRoteiro = "Super Nós e Super Malhas";
            // 
            // subRoteiro5
            // 
            this.subRoteiro5.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito5;
            this.subRoteiro5.Location = new System.Drawing.Point(207, 291);
            this.subRoteiro5.Name = "subRoteiro5";
            this.subRoteiro5.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro5.TabIndex = 8;
            this.subRoteiro5.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro5.TextoRoteiro = "Teorema de Northon e Thévenin";
            // 
            // subRoteiro6
            // 
            this.subRoteiro6.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito6;
            this.subRoteiro6.Location = new System.Drawing.Point(389, 291);
            this.subRoteiro6.Name = "subRoteiro6";
            this.subRoteiro6.Size = new System.Drawing.Size(163, 172);
            this.subRoteiro6.TabIndex = 9;
            this.subRoteiro6.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRoteiro6.TextoRoteiro = "Teorema da Superposição";
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.btnRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetornar.BackgroundImage")));
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Location = new System.Drawing.Point(23, 38);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(50, 50);
            this.btnRetornar.TabIndex = 16;
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // TelaSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(575, 493);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.subRoteiro6);
            this.Controls.Add(this.subRoteiro5);
            this.Controls.Add(this.subRoteiro4);
            this.Controls.Add(this.subRoteiro3);
            this.Controls.Add(this.rtrLeisOhm);
            this.Controls.Add(this.subRoteiro1);
            this.Name = "TelaSimulador";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.subRoteiro1, 0);
            this.Controls.SetChildIndex(this.rtrLeisOhm, 0);
            this.Controls.SetChildIndex(this.subRoteiro3, 0);
            this.Controls.SetChildIndex(this.subRoteiro4, 0);
            this.Controls.SetChildIndex(this.subRoteiro5, 0);
            this.Controls.SetChildIndex(this.subRoteiro6, 0);
            this.Controls.SetChildIndex(this.btnRetornar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SubRoteiro subRoteiro1;
        private SubRoteiro rtrLeisOhm;
        private SubRoteiro subRoteiro3;
        private SubRoteiro subRoteiro4;
        private SubRoteiro subRoteiro5;
        private SubRoteiro subRoteiro6;
        private System.Windows.Forms.Button btnRetornar;
    }
}
