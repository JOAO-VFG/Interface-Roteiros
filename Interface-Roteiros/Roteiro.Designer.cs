
namespace Interface_Roteiros
{
    partial class Roteiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roteiro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnSimulador = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.imgImagem);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 402);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(213)))));
            this.panel4.Controls.Add(this.btnPDF);
            this.panel4.Controls.Add(this.btnSimulador);
            this.panel4.Location = new System.Drawing.Point(0, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 164);
            this.panel4.TabIndex = 8;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(224, 98);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(150, 43);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnSimulador
            // 
            this.btnSimulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSimulador.FlatAppearance.BorderSize = 0;
            this.btnSimulador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulador.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulador.ForeColor = System.Drawing.Color.White;
            this.btnSimulador.Location = new System.Drawing.Point(409, 98);
            this.btnSimulador.Name = "btnSimulador";
            this.btnSimulador.Size = new System.Drawing.Size(150, 43);
            this.btnSimulador.TabIndex = 3;
            this.btnSimulador.Text = "SIMULADOR";
            this.btnSimulador.UseVisualStyleBackColor = false;
            this.btnSimulador.Click += new System.EventHandler(this.BtnSimulador_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.panel2.Location = new System.Drawing.Point(201, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 5);
            this.panel2.TabIndex = 7;
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTexto.Location = new System.Drawing.Point(197, 91);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(362, 128);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "No roteiro 1 será abordado o conteúdo X onde aprederemos diversas coisas sobre ta" +
    "l coisa";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(69)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.btnRetornar);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 54);
            this.panel3.TabIndex = 6;
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetornar.BackgroundImage")));
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Location = new System.Drawing.Point(0, 0);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(65, 54);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(577, 54);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CARGAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgImagem
            // 
            this.imgImagem.Image = global::Interface_Roteiros.Properties.Resources.circuito2;
            this.imgImagem.Location = new System.Drawing.Point(0, 50);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(191, 188);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgImagem.TabIndex = 0;
            this.imgImagem.TabStop = false;
            // 
            // Roteiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Roteiro";
            this.Size = new System.Drawing.Size(580, 402);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnSimulador;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRetornar;
    }
}
