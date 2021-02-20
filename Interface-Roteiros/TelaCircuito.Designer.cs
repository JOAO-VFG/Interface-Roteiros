
namespace Interface_Roteiros
{
    partial class TelaCircuito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCircuito));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnResistor3 = new Interface_Roteiros.BotaoPersonalizado();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnResistor2 = new Interface_Roteiros.BotaoPersonalizado();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnResistor1 = new Interface_Roteiros.BotaoPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFonte = new Interface_Roteiros.BotaoPersonalizado();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFonte = new System.Windows.Forms.Label();
            this.lblResistor1 = new System.Windows.Forms.Label();
            this.lblResistor3 = new System.Windows.Forms.Label();
            this.lblResistor2 = new System.Windows.Forms.Label();
            this.lblV0 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            // 
            // imgIcone
            // 
            this.imgIcone.Image = ((System.Drawing.Image)(resources.GetObject("imgIcone.Image")));
            this.imgIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnRetornar);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnResistor3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnResistor2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnResistor1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnFonte);
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 100);
            this.panel1.TabIndex = 4;
            // 
            // btnRetornar
            // 
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Image = global::Interface_Roteiros.Properties.Resources.left_arrow;
            this.btnRetornar.Location = new System.Drawing.Point(0, 0);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(100, 100);
            this.btnRetornar.TabIndex = 5;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel6.Location = new System.Drawing.Point(518, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 100);
            this.panel6.TabIndex = 4;
            // 
            // btnResistor3
            // 
            this.btnResistor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.btnResistor3.Image = global::Interface_Roteiros.Properties.Resources.resistor2;
            this.btnResistor3.Location = new System.Drawing.Point(418, 0);
            this.btnResistor3.Name = "btnResistor3";
            this.btnResistor3.Size = new System.Drawing.Size(100, 100);
            this.btnResistor3.TabIndex = 4;
            this.btnResistor3.Texto = "3";
            this.btnResistor3.Click += new System.EventHandler(this.btnResistor3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel5.Location = new System.Drawing.Point(413, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 100);
            this.panel5.TabIndex = 3;
            // 
            // btnResistor2
            // 
            this.btnResistor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.btnResistor2.Image = global::Interface_Roteiros.Properties.Resources.resistor2;
            this.btnResistor2.Location = new System.Drawing.Point(313, 0);
            this.btnResistor2.Name = "btnResistor2";
            this.btnResistor2.Size = new System.Drawing.Size(100, 100);
            this.btnResistor2.TabIndex = 3;
            this.btnResistor2.Texto = "2";
            this.btnResistor2.Click += new System.EventHandler(this.btnResistor2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel4.Location = new System.Drawing.Point(308, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 100);
            this.panel4.TabIndex = 2;
            // 
            // btnResistor1
            // 
            this.btnResistor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.btnResistor1.Image = global::Interface_Roteiros.Properties.Resources.resistor2;
            this.btnResistor1.Location = new System.Drawing.Point(208, 0);
            this.btnResistor1.Name = "btnResistor1";
            this.btnResistor1.Size = new System.Drawing.Size(100, 100);
            this.btnResistor1.TabIndex = 2;
            this.btnResistor1.Texto = "1";
            this.btnResistor1.Click += new System.EventHandler(this.btnResistor1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel3.Location = new System.Drawing.Point(203, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnFonte
            // 
            this.btnFonte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.btnFonte.Image = global::Interface_Roteiros.Properties.Resources.battery2;
            this.btnFonte.Location = new System.Drawing.Point(103, 0);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(100, 100);
            this.btnFonte.TabIndex = 0;
            this.btnFonte.Texto = "Fonte";
            this.btnFonte.Click += new System.EventHandler(this.btnFonte_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 7);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface_Roteiros.Properties.Resources.circuito_eletrico1;
            this.pictureBox1.Location = new System.Drawing.Point(103, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblFonte
            // 
            this.lblFonte.AutoSize = true;
            this.lblFonte.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblFonte.Location = new System.Drawing.Point(176, 168);
            this.lblFonte.Name = "lblFonte";
            this.lblFonte.Size = new System.Drawing.Size(36, 19);
            this.lblFonte.TabIndex = 7;
            this.lblFonte.Text = "40V";
            // 
            // lblResistor1
            // 
            this.lblResistor1.AutoSize = true;
            this.lblResistor1.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblResistor1.Location = new System.Drawing.Point(319, 168);
            this.lblResistor1.Name = "lblResistor1";
            this.lblResistor1.Size = new System.Drawing.Size(28, 19);
            this.lblResistor1.TabIndex = 8;
            this.lblResistor1.Text = "5Ω";
            // 
            // lblResistor3
            // 
            this.lblResistor3.AutoSize = true;
            this.lblResistor3.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblResistor3.Location = new System.Drawing.Point(492, 168);
            this.lblResistor3.Name = "lblResistor3";
            this.lblResistor3.Size = new System.Drawing.Size(28, 19);
            this.lblResistor3.TabIndex = 9;
            this.lblResistor3.Text = "8Ω";
            this.lblResistor3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResistor2
            // 
            this.lblResistor2.AutoSize = true;
            this.lblResistor2.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblResistor2.Location = new System.Drawing.Point(406, 46);
            this.lblResistor2.Name = "lblResistor2";
            this.lblResistor2.Size = new System.Drawing.Size(32, 19);
            this.lblResistor2.TabIndex = 10;
            this.lblResistor2.Text = "12Ω";
            // 
            // lblV0
            // 
            this.lblV0.AutoSize = true;
            this.lblV0.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblV0.Location = new System.Drawing.Point(559, 168);
            this.lblV0.Name = "lblV0";
            this.lblV0.Size = new System.Drawing.Size(27, 19);
            this.lblV0.TabIndex = 11;
            this.lblV0.Text = "V0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(516, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "3";
            // 
            // TelaCircuito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblV0);
            this.Controls.Add(this.lblResistor2);
            this.Controls.Add(this.lblResistor3);
            this.Controls.Add(this.lblResistor1);
            this.Controls.Add(this.lblFonte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCircuito";
            this.Text = "S";
            this.Load += new System.EventHandler(this.TelaCircuitoTeste_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lblFonte, 0);
            this.Controls.SetChildIndex(this.lblResistor1, 0);
            this.Controls.SetChildIndex(this.lblResistor3, 0);
            this.Controls.SetChildIndex(this.lblResistor2, 0);
            this.Controls.SetChildIndex(this.lblV0, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.Label lblResistor1;
        private System.Windows.Forms.Label lblResistor3;
        private System.Windows.Forms.Label lblResistor2;
        private System.Windows.Forms.Label lblV0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private BotaoPersonalizado btnResistor1;
        private System.Windows.Forms.Panel panel3;
        private BotaoPersonalizado btnFonte;
        private BotaoPersonalizado btnResistor3;
        private System.Windows.Forms.Panel panel5;
        private BotaoPersonalizado btnResistor2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRetornar;
    }
}
