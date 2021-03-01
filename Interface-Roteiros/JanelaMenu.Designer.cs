
namespace Interface_Roteiros
{
    partial class JanelaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPainel = new System.Windows.Forms.Button();
            this.btnTexto = new System.Windows.Forms.Button();
            this.imgMenu = new System.Windows.Forms.PictureBox();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 2);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Painel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Texto";
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.label4);
            this.panMenu.Controls.Add(this.btnVoltar);
            this.panMenu.Controls.Add(this.panel2);
            this.panMenu.Controls.Add(this.panel1);
            this.panMenu.Controls.Add(this.label3);
            this.panMenu.Controls.Add(this.btnPainel);
            this.panMenu.Controls.Add(this.btnTexto);
            this.panMenu.Controls.Add(this.label2);
            this.panMenu.Location = new System.Drawing.Point(0, 37);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(120, 335);
            this.panMenu.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Voltar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::Interface_Roteiros.Properties.Resources.left_arrow;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(23, 258);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(67, 51);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 2);
            this.panel2.TabIndex = 5;
            // 
            // btnPainel
            // 
            this.btnPainel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPainel.FlatAppearance.BorderSize = 0;
            this.btnPainel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPainel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel.Image = global::Interface_Roteiros.Properties.Resources.toggleOn;
            this.btnPainel.Location = new System.Drawing.Point(8, 24);
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.Size = new System.Drawing.Size(37, 32);
            this.btnPainel.TabIndex = 5;
            this.btnPainel.UseVisualStyleBackColor = true;
            this.btnPainel.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // btnTexto
            // 
            this.btnTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTexto.FlatAppearance.BorderSize = 0;
            this.btnTexto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTexto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTexto.Image = ((System.Drawing.Image)(resources.GetObject("btnTexto.Image")));
            this.btnTexto.Location = new System.Drawing.Point(7, 60);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(37, 32);
            this.btnTexto.TabIndex = 14;
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMenu.Image = ((System.Drawing.Image)(resources.GetObject("imgMenu.Image")));
            this.imgMenu.Location = new System.Drawing.Point(6, 7);
            this.imgMenu.Name = "imgMenu";
            this.imgMenu.Size = new System.Drawing.Size(24, 24);
            this.imgMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMenu.TabIndex = 0;
            this.imgMenu.TabStop = false;
            this.imgMenu.Click += new System.EventHandler(this.imgMenu_Click);
            // 
            // JanelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgMenu);
            this.MaximumSize = new System.Drawing.Size(120, 375);
            this.MinimumSize = new System.Drawing.Size(38, 375);
            this.Name = "JanelaMenu";
            this.Size = new System.Drawing.Size(120, 375);
            this.Load += new System.EventHandler(this.JanelaMenu_Load);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPainel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel2;
    }
}
