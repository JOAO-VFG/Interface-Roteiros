
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
            this.rtrKirchhof = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro4 = new Interface_Roteiros.SubRoteiro();
            this.rtrNortonThevenin = new Interface_Roteiros.SubRoteiro();
            this.subRoteiro6 = new Interface_Roteiros.SubRoteiro();
            this.btnRetornar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(580, 35);
            this.lblTitulo.Text = "Electrophorus";
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
            // 
            // rtrKirchhof
            // 
            this.rtrKirchhof.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito3;
            this.rtrKirchhof.Location = new System.Drawing.Point(389, 94);
            this.rtrKirchhof.Name = "rtrKirchhof";
            this.rtrKirchhof.Size = new System.Drawing.Size(163, 172);
            this.rtrKirchhof.TabIndex = 6;
            this.rtrKirchhof.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtrKirchhof.TextoRoteiro = "Leis de Kirchhof";
            this.rtrKirchhof.Click += new System.EventHandler(this.rtrKirchhof_Click);
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
            // rtrNortonThevenin
            // 
            this.rtrNortonThevenin.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito5;
            this.rtrNortonThevenin.Location = new System.Drawing.Point(207, 291);
            this.rtrNortonThevenin.Name = "rtrNortonThevenin";
            this.rtrNortonThevenin.Size = new System.Drawing.Size(163, 172);
            this.rtrNortonThevenin.TabIndex = 8;
            this.rtrNortonThevenin.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtrNortonThevenin.TextoRoteiro = "Teorema de Northon e Thévenin";
            this.rtrNortonThevenin.Click += new System.EventHandler(this.rtrNortonThevenin_Click);
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
            this.btnRetornar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Location = new System.Drawing.Point(23, 38);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(50, 50);
            this.btnRetornar.TabIndex = 16;
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            this.btnRetornar.MouseEnter += new System.EventHandler(this.btnRetornar_MouseEnter);
            this.btnRetornar.MouseLeave += new System.EventHandler(this.btnRetornar_MouseLeave);
            // 
            // TelaSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(575, 493);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.subRoteiro6);
            this.Controls.Add(this.rtrNortonThevenin);
            this.Controls.Add(this.subRoteiro4);
            this.Controls.Add(this.rtrKirchhof);
            this.Controls.Add(this.rtrLeisOhm);
            this.Controls.Add(this.subRoteiro1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaSimulador";
            this.Text = "Electrophorus";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.subRoteiro1, 0);
            this.Controls.SetChildIndex(this.rtrLeisOhm, 0);
            this.Controls.SetChildIndex(this.rtrKirchhof, 0);
            this.Controls.SetChildIndex(this.subRoteiro4, 0);
            this.Controls.SetChildIndex(this.rtrNortonThevenin, 0);
            this.Controls.SetChildIndex(this.subRoteiro6, 0);
            this.Controls.SetChildIndex(this.btnRetornar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SubRoteiro subRoteiro1;
        private SubRoteiro rtrLeisOhm;
        private SubRoteiro rtrKirchhof;
        private SubRoteiro subRoteiro4;
        private SubRoteiro rtrNortonThevenin;
        private SubRoteiro subRoteiro6;
        private System.Windows.Forms.Button btnRetornar;
    }
}
