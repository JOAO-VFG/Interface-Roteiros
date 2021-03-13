
namespace Interface_Roteiros
{
    partial class PainelResistor
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
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.lblResistencia = new System.Windows.Forms.Label();
            this.trackResistencia = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblCorrente = new System.Windows.Forms.Label();
            this.lblTensao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackResistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 5;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(78)))), ((int)(((byte)(12)))));
            this.xuiCircleProgressBar1.FilledColorAlpha = 200;
            this.xuiCircleProgressBar1.FilledThickness = 30;
            this.xuiCircleProgressBar1.IsAnimated = false;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(3, 12);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 63;
            this.xuiCircleProgressBar1.ShowText = false;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(135, 129);
            this.xuiCircleProgressBar1.TabIndex = 0;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar1.TextSize = 25;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.xuiCircleProgressBar1.UnfilledThickness = 12;
            // 
            // lblResistencia
            // 
            this.lblResistencia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResistencia.ForeColor = System.Drawing.Color.White;
            this.lblResistencia.Location = new System.Drawing.Point(45, 59);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Size = new System.Drawing.Size(54, 29);
            this.lblResistencia.TabIndex = 1;
            this.lblResistencia.Text = "0Ω";
            this.lblResistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackResistencia
            // 
            this.trackResistencia.AutoSize = false;
            this.trackResistencia.Location = new System.Drawing.Point(3, 160);
            this.trackResistencia.Maximum = 100;
            this.trackResistencia.Minimum = 1;
            this.trackResistencia.Name = "trackResistencia";
            this.trackResistencia.Size = new System.Drawing.Size(152, 28);
            this.trackResistencia.TabIndex = 2;
            this.trackResistencia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackResistencia.Value = 10;
            this.trackResistencia.Scroll += new System.EventHandler(this.trackResistencia_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tensão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Corrente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Potência";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Interface_Roteiros.Properties.Resources.current;
            this.pictureBox3.Location = new System.Drawing.Point(29, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Interface_Roteiros.Properties.Resources.power_danger;
            this.pictureBox2.Location = new System.Drawing.Point(29, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface_Roteiros.Properties.Resources.battery;
            this.pictureBox1.Location = new System.Drawing.Point(29, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblPotencia);
            this.panel1.Controls.Add(this.lblCorrente);
            this.panel1.Controls.Add(this.lblTensao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(161, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 200);
            this.panel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panel4.Location = new System.Drawing.Point(8, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 3);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panel3.Location = new System.Drawing.Point(8, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 3);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 200);
            this.panel2.TabIndex = 12;
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencia.ForeColor = System.Drawing.Color.White;
            this.lblPotencia.Location = new System.Drawing.Point(145, 164);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(32, 19);
            this.lblPotencia.TabIndex = 11;
            this.lblPotencia.Text = "0W";
            // 
            // lblCorrente
            // 
            this.lblCorrente.AutoSize = true;
            this.lblCorrente.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrente.ForeColor = System.Drawing.Color.White;
            this.lblCorrente.Location = new System.Drawing.Point(146, 100);
            this.lblCorrente.Name = "lblCorrente";
            this.lblCorrente.Size = new System.Drawing.Size(28, 19);
            this.lblCorrente.TabIndex = 10;
            this.lblCorrente.Text = "0A";
            // 
            // lblTensao
            // 
            this.lblTensao.AutoSize = true;
            this.lblTensao.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensao.ForeColor = System.Drawing.Color.White;
            this.lblTensao.Location = new System.Drawing.Point(146, 28);
            this.lblTensao.Name = "lblTensao";
            this.lblTensao.Size = new System.Drawing.Size(27, 19);
            this.lblTensao.TabIndex = 9;
            this.lblTensao.Text = "0V";
            // 
            // PainelResistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackResistencia);
            this.Controls.Add(this.lblResistencia);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.Name = "PainelResistor";
            this.Size = new System.Drawing.Size(385, 200);
            this.Load += new System.EventHandler(this.PainelResistor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackResistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private System.Windows.Forms.TrackBar trackResistencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblCorrente;
        private System.Windows.Forms.Label lblTensao;
        private System.Windows.Forms.Label lblResistencia;
    }
}
