
namespace Interface_Roteiros
{
    partial class CaixaComponente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaComponente));
            this.lblNomeCompoenente = new System.Windows.Forms.Label();
            this.panSelecionado = new System.Windows.Forms.Panel();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.panInformacoes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tckResistencia = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cpbResistencia = new XanderUI.XUICircleProgressBar();
            this.lblResistencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.panInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckResistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCompoenente
            // 
            this.lblNomeCompoenente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeCompoenente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompoenente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCompoenente.Location = new System.Drawing.Point(0, 0);
            this.lblNomeCompoenente.Name = "lblNomeCompoenente";
            this.lblNomeCompoenente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblNomeCompoenente.Size = new System.Drawing.Size(150, 40);
            this.lblNomeCompoenente.TabIndex = 1;
            this.lblNomeCompoenente.Text = "Resistor";
            this.lblNomeCompoenente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNomeCompoenente.Click += new System.EventHandler(this.lblNomeCompoenente_Click);
            this.lblNomeCompoenente.MouseEnter += new System.EventHandler(this.lblNomeCompoenente_MouseEnter);
            this.lblNomeCompoenente.MouseLeave += new System.EventHandler(this.lblNomeCompoenente_MouseLeave);
            // 
            // panSelecionado
            // 
            this.panSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(232)))), ((int)(((byte)(46)))));
            this.panSelecionado.Location = new System.Drawing.Point(0, 0);
            this.panSelecionado.Name = "panSelecionado";
            this.panSelecionado.Size = new System.Drawing.Size(6, 40);
            this.panSelecionado.TabIndex = 1;
            // 
            // imgImagem
            // 
            this.imgImagem.BackColor = System.Drawing.Color.Transparent;
            this.imgImagem.Image = ((System.Drawing.Image)(resources.GetObject("imgImagem.Image")));
            this.imgImagem.Location = new System.Drawing.Point(10, 12);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(20, 20);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImagem.TabIndex = 2;
            this.imgImagem.TabStop = false;
            // 
            // panInformacoes
            // 
            this.panInformacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.panInformacoes.Controls.Add(this.lblResistencia);
            this.panInformacoes.Controls.Add(this.cpbResistencia);
            this.panInformacoes.Controls.Add(this.panel3);
            this.panInformacoes.Controls.Add(this.panel2);
            this.panInformacoes.Controls.Add(this.panel1);
            this.panInformacoes.Controls.Add(this.label7);
            this.panInformacoes.Controls.Add(this.label6);
            this.panInformacoes.Controls.Add(this.tckResistencia);
            this.panInformacoes.Controls.Add(this.label5);
            this.panInformacoes.Controls.Add(this.label4);
            this.panInformacoes.Controls.Add(this.label3);
            this.panInformacoes.Controls.Add(this.label2);
            this.panInformacoes.Controls.Add(this.label1);
            this.panInformacoes.Location = new System.Drawing.Point(0, 40);
            this.panInformacoes.Name = "panInformacoes";
            this.panInformacoes.Size = new System.Drawing.Size(150, 330);
            this.panInformacoes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tensão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Corrente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resistência";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(89, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "0V";
            // 
            // tckResistencia
            // 
            this.tckResistencia.AutoSize = false;
            this.tckResistencia.Location = new System.Drawing.Point(0, 292);
            this.tckResistencia.Maximum = 100;
            this.tckResistencia.Minimum = 1;
            this.tckResistencia.Name = "tckResistencia";
            this.tckResistencia.Size = new System.Drawing.Size(150, 27);
            this.tckResistencia.TabIndex = 5;
            this.tckResistencia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckResistencia.Value = 1;
            this.tckResistencia.Scroll += new System.EventHandler(this.tckResistencia_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "0A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(89, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "0W";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 3);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 3);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 3);
            this.panel3.TabIndex = 10;
            // 
            // cpbResistencia
            // 
            this.cpbResistencia.AnimationSpeed = 5;
            this.cpbResistencia.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.cpbResistencia.FilledColorAlpha = 130;
            this.cpbResistencia.FilledThickness = 25;
            this.cpbResistencia.IsAnimated = false;
            this.cpbResistencia.Location = new System.Drawing.Point(11, 161);
            this.cpbResistencia.Name = "cpbResistencia";
            this.cpbResistencia.Percentage = 20;
            this.cpbResistencia.ShowText = false;
            this.cpbResistencia.Size = new System.Drawing.Size(130, 120);
            this.cpbResistencia.TabIndex = 11;
            this.cpbResistencia.TextColor = System.Drawing.Color.Gray;
            this.cpbResistencia.TextSize = 25;
            this.cpbResistencia.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.cpbResistencia.UnfilledThickness = 12;
            // 
            // lblResistencia
            // 
            this.lblResistencia.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResistencia.ForeColor = System.Drawing.Color.White;
            this.lblResistencia.Location = new System.Drawing.Point(46, 201);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Size = new System.Drawing.Size(57, 36);
            this.lblResistencia.TabIndex = 12;
            this.lblResistencia.Text = "0";
            this.lblResistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaixaComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.panInformacoes);
            this.Controls.Add(this.imgImagem);
            this.Controls.Add(this.panSelecionado);
            this.Controls.Add(this.lblNomeCompoenente);
            this.MaximumSize = new System.Drawing.Size(150, 370);
            this.MinimumSize = new System.Drawing.Size(150, 40);
            this.Name = "CaixaComponente";
            this.Size = new System.Drawing.Size(150, 370);
            this.Load += new System.EventHandler(this.CaixaComponente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.panInformacoes.ResumeLayout(false);
            this.panInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckResistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCompoenente;
        private System.Windows.Forms.Panel panSelecionado;
        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.Panel panInformacoes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tckResistencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUICircleProgressBar cpbResistencia;
        private System.Windows.Forms.Label lblResistencia;
    }
}
