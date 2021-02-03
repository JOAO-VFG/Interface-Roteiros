
namespace Interface_Roteiros
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panSimulador = new System.Windows.Forms.Panel();
            this.panSimulador2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSimulador = new System.Windows.Forms.Label();
            this.panPDF = new System.Windows.Forms.Panel();
            this.panPDF2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPDF = new System.Windows.Forms.Label();
            this.panSobre = new System.Windows.Forms.Panel();
            this.panSobre2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRoteiros = new System.Windows.Forms.Button();
            this.panRoteiros = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panSimulador.SuspendLayout();
            this.panSimulador2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panPDF.SuspendLayout();
            this.panPDF2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panSobre.SuspendLayout();
            this.panSobre2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panRoteiros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 35);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Interface_Roteiros.Properties.Resources.cancel;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(552, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador Eletrônico";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(67)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panRoteiros);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panSimulador);
            this.panel2.Controls.Add(this.panPDF);
            this.panel2.Controls.Add(this.panSobre);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 440);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel8.Location = new System.Drawing.Point(375, 304);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(11, 136);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel7.Location = new System.Drawing.Point(179, 304);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(11, 136);
            this.panel7.TabIndex = 5;
            // 
            // panSimulador
            // 
            this.panSimulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(56)))), ((int)(((byte)(224)))));
            this.panSimulador.Controls.Add(this.panSimulador2);
            this.panSimulador.Controls.Add(this.lblSimulador);
            this.panSimulador.Location = new System.Drawing.Point(386, 304);
            this.panSimulador.Name = "panSimulador";
            this.panSimulador.Size = new System.Drawing.Size(194, 136);
            this.panSimulador.TabIndex = 4;
            // 
            // panSimulador2
            // 
            this.panSimulador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.panSimulador2.Controls.Add(this.pictureBox5);
            this.panSimulador2.Controls.Add(this.label5);
            this.panSimulador2.Location = new System.Drawing.Point(-8, 0);
            this.panSimulador2.Name = "panSimulador2";
            this.panSimulador2.Size = new System.Drawing.Size(202, 32);
            this.panSimulador2.TabIndex = 9;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(14, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Simulador";
            // 
            // lblSimulador
            // 
            this.lblSimulador.BackColor = System.Drawing.Color.Transparent;
            this.lblSimulador.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulador.ForeColor = System.Drawing.Color.Black;
            this.lblSimulador.Location = new System.Drawing.Point(17, 36);
            this.lblSimulador.Name = "lblSimulador";
            this.lblSimulador.Size = new System.Drawing.Size(164, 91);
            this.lblSimulador.TabIndex = 1;
            this.lblSimulador.Text = "Cada tópico dispõe de um circuito organizado para que o aluno possa manipular e t" +
    "estar novos valores";
            this.lblSimulador.MouseEnter += new System.EventHandler(this.lblSimulador_MouseEnter);
            this.lblSimulador.MouseLeave += new System.EventHandler(this.lblSimulador_MouseLeave);
            // 
            // panPDF
            // 
            this.panPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(212)))));
            this.panPDF.Controls.Add(this.panPDF2);
            this.panPDF.Controls.Add(this.lblPDF);
            this.panPDF.Location = new System.Drawing.Point(190, 304);
            this.panPDF.Name = "panPDF";
            this.panPDF.Size = new System.Drawing.Size(190, 136);
            this.panPDF.TabIndex = 3;
            // 
            // panPDF2
            // 
            this.panPDF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.panPDF2.Controls.Add(this.pictureBox3);
            this.panPDF2.Controls.Add(this.label8);
            this.panPDF2.Location = new System.Drawing.Point(0, 0);
            this.panPDF2.Name = "panPDF2";
            this.panPDF2.Size = new System.Drawing.Size(190, 32);
            this.panPDF2.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(9, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(59, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "PDF\'s";
            // 
            // lblPDF
            // 
            this.lblPDF.AutoEllipsis = true;
            this.lblPDF.BackColor = System.Drawing.Color.Transparent;
            this.lblPDF.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDF.ForeColor = System.Drawing.Color.Black;
            this.lblPDF.Location = new System.Drawing.Point(6, 35);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(173, 92);
            this.lblPDF.TabIndex = 1;
            this.lblPDF.Text = "Cada tópico dispõe de um PDF para auxliar o aluno em seus estudos";
            this.lblPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPDF.MouseEnter += new System.EventHandler(this.lblPDF_MouseEnter);
            this.lblPDF.MouseLeave += new System.EventHandler(this.lblPDF_MouseLeave);
            // 
            // panSobre
            // 
            this.panSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(179)))), ((int)(((byte)(114)))));
            this.panSobre.Controls.Add(this.panSobre2);
            this.panSobre.Controls.Add(this.lblSobre);
            this.panSobre.Location = new System.Drawing.Point(0, 304);
            this.panSobre.Name = "panSobre";
            this.panSobre.Size = new System.Drawing.Size(187, 136);
            this.panSobre.TabIndex = 2;
            // 
            // panSobre2
            // 
            this.panSobre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.panSobre2.Controls.Add(this.pictureBox4);
            this.panSobre2.Controls.Add(this.label2);
            this.panSobre2.Location = new System.Drawing.Point(-1, 0);
            this.panSobre2.Name = "panSobre2";
            this.panSobre2.Size = new System.Drawing.Size(185, 32);
            this.panSobre2.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(7, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sobre";
            // 
            // lblSobre
            // 
            this.lblSobre.BackColor = System.Drawing.Color.Transparent;
            this.lblSobre.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.ForeColor = System.Drawing.Color.Black;
            this.lblSobre.Location = new System.Drawing.Point(3, 35);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(170, 92);
            this.lblSobre.TabIndex = 1;
            this.lblSobre.Text = "Este software visa o aprendizado do aluno em circuitos elétricos";
            this.lblSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSobre.MouseEnter += new System.EventHandler(this.lblSobre_MouseEnter);
            this.lblSobre.MouseLeave += new System.EventHandler(this.lblSobre_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 266);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnRoteiros
            // 
            this.btnRoteiros.BackColor = System.Drawing.Color.Transparent;
            this.btnRoteiros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRoteiros.FlatAppearance.BorderSize = 0;
            this.btnRoteiros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRoteiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoteiros.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoteiros.ForeColor = System.Drawing.Color.White;
            this.btnRoteiros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoteiros.Location = new System.Drawing.Point(3, 7);
            this.btnRoteiros.Name = "btnRoteiros";
            this.btnRoteiros.Size = new System.Drawing.Size(91, 30);
            this.btnRoteiros.TabIndex = 0;
            this.btnRoteiros.Text = "Roteiros";
            this.btnRoteiros.UseVisualStyleBackColor = false;
            this.btnRoteiros.Click += new System.EventHandler(this.btnRoteiros_Click);
            // 
            // panRoteiros
            // 
            this.panRoteiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panRoteiros.Controls.Add(this.button5);
            this.panRoteiros.Controls.Add(this.button4);
            this.panRoteiros.Controls.Add(this.button3);
            this.panRoteiros.Controls.Add(this.button2);
            this.panRoteiros.Controls.Add(this.button1);
            this.panRoteiros.Controls.Add(this.btnRoteiros);
            this.panRoteiros.Location = new System.Drawing.Point(0, -2);
            this.panRoteiros.MaximumSize = new System.Drawing.Size(90, 220);
            this.panRoteiros.MinimumSize = new System.Drawing.Size(90, 40);
            this.panRoteiros.Name = "panRoteiros";
            this.panRoteiros.Size = new System.Drawing.Size(90, 220);
            this.panRoteiros.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Roteiro1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Roteiro2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Roteiro3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "Roteiro4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 30);
            this.button5.TabIndex = 12;
            this.button5.Text = "Roteiro5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panSimulador.ResumeLayout(false);
            this.panSimulador2.ResumeLayout(false);
            this.panSimulador2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panPDF.ResumeLayout(false);
            this.panPDF2.ResumeLayout(false);
            this.panPDF2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panSobre.ResumeLayout(false);
            this.panSobre2.ResumeLayout(false);
            this.panSobre2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panRoteiros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panSimulador;
        private System.Windows.Forms.Label lblSimulador;
        private System.Windows.Forms.Panel panPDF;
        private System.Windows.Forms.Panel panSobre;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Panel panSobre2;
        private System.Windows.Forms.Panel panSimulador2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panPDF2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnRoteiros;
        private System.Windows.Forms.Panel panRoteiros;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

