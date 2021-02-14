
namespace Interface_Roteiros
{
    partial class TelaAjusteResistor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAjusteResistor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblResistencia = new System.Windows.Forms.Label();
            this.tckResistencia = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpbResistencia = new XanderUI.XUICircleProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckResistencia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblResistencia);
            this.panel1.Controls.Add(this.tckResistencia);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cpbResistencia);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 240);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(410, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Resistor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(171)))), ((int)(((byte)(142)))));
            this.panel5.Location = new System.Drawing.Point(174, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 7);
            this.panel5.TabIndex = 26;
            // 
            // lblResistencia
            // 
            this.lblResistencia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.lblResistencia.Location = new System.Drawing.Point(56, 123);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Size = new System.Drawing.Size(70, 29);
            this.lblResistencia.TabIndex = 28;
            this.lblResistencia.Text = "20Ω";
            this.lblResistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tckResistencia
            // 
            this.tckResistencia.Location = new System.Drawing.Point(6, 212);
            this.tckResistencia.Maximum = 100;
            this.tckResistencia.Minimum = 1;
            this.tckResistencia.Name = "tckResistencia";
            this.tckResistencia.Size = new System.Drawing.Size(157, 45);
            this.tckResistencia.TabIndex = 27;
            this.tckResistencia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckResistencia.Value = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(171)))), ((int)(((byte)(142)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(173, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 35);
            this.panel4.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Informações";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(166, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 204);
            this.panel3.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(199)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(298, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "0W";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(199)))), ((int)(((byte)(201)))));
            this.label6.Location = new System.Drawing.Point(301, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "0A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(199)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(217, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Potência:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(199)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(217, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Corrente:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Resistência";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbResistencia
            // 
            this.cpbResistencia.AnimationSpeed = 10;
            this.cpbResistencia.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.cpbResistencia.FilledColorAlpha = 150;
            this.cpbResistencia.FilledThickness = 15;
            this.cpbResistencia.IsAnimated = false;
            this.cpbResistencia.Location = new System.Drawing.Point(38, 84);
            this.cpbResistencia.Name = "cpbResistencia";
            this.cpbResistencia.Percentage = 20;
            this.cpbResistencia.ShowText = false;
            this.cpbResistencia.Size = new System.Drawing.Size(110, 110);
            this.cpbResistencia.TabIndex = 17;
            this.cpbResistencia.TextColor = System.Drawing.Color.Gray;
            this.cpbResistencia.TextSize = 15;
            this.cpbResistencia.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.cpbResistencia.UnfilledThickness = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 4);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(186, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::Interface_Roteiros.Properties.Resources.cancel_hover;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(374, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(24, 24);
            this.btnSair.TabIndex = 31;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // TelaAjusteResistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 240);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaAjusteResistor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaAjusteResistor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckResistencia)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResistencia;
        private System.Windows.Forms.TrackBar tckResistencia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUICircleProgressBar cpbResistencia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
    }
}