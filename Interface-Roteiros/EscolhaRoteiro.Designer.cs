
namespace Interface_Roteiros
{
    partial class EscolhaRoteiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscolhaRoteiro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imgRoteiro = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panTitulo = new System.Windows.Forms.Panel();
            this.btnPdf = new System.Windows.Forms.Button();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRoteiro)).BeginInit();
            this.panTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgRoteiro);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 197);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(116, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Esquema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgRoteiro
            // 
            this.imgRoteiro.Image = global::Interface_Roteiros.Properties.Resources.circuito_eletrico1;
            this.imgRoteiro.Location = new System.Drawing.Point(116, 3);
            this.imgRoteiro.Name = "imgRoteiro";
            this.imgRoteiro.Size = new System.Drawing.Size(343, 171);
            this.imgRoteiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRoteiro.TabIndex = 4;
            this.imgRoteiro.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 3);
            this.lblTitulo.Size = new System.Drawing.Size(595, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Teorema de Norton e Thévenin";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            this.lblTitulo.MouseEnter += new System.EventHandler(this.lblTitulo_MouseEnter);
            this.lblTitulo.MouseLeave += new System.EventHandler(this.lblTitulo_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(160)))), ((int)(((byte)(161)))));
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 5);
            this.panel2.TabIndex = 3;
            // 
            // panTitulo
            // 
            this.panTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.panTitulo.Controls.Add(this.btnPdf);
            this.panTitulo.Controls.Add(this.imgImagem);
            this.panTitulo.Controls.Add(this.lblTitulo);
            this.panTitulo.Location = new System.Drawing.Point(0, 0);
            this.panTitulo.Name = "panTitulo";
            this.panTitulo.Size = new System.Drawing.Size(595, 40);
            this.panTitulo.TabIndex = 1;
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Location = new System.Drawing.Point(550, 8);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(24, 24);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            this.btnPdf.MouseEnter += new System.EventHandler(this.btnPdf_MouseEnter);
            this.btnPdf.MouseLeave += new System.EventHandler(this.btnPdf_MouseLeave);
            // 
            // imgImagem
            // 
            this.imgImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(68)))));
            this.imgImagem.Image = global::Interface_Roteiros.Properties.Resources.plus_sign;
            this.imgImagem.Location = new System.Drawing.Point(0, 0);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(33, 42);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgImagem.TabIndex = 3;
            this.imgImagem.TabStop = false;
            // 
            // EscolhaRoteiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(595, 245);
            this.MinimumSize = new System.Drawing.Size(595, 45);
            this.Name = "EscolhaRoteiro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(595, 45);
            this.Load += new System.EventHandler(this.EscolhaRoteiro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRoteiro)).EndInit();
            this.panTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgRoteiro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panTitulo;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.PictureBox imgImagem;
    }
}
