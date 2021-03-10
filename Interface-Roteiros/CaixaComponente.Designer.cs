
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
            this.lblNomeComponente = new System.Windows.Forms.Label();
            this.panSelecionado = new System.Windows.Forms.Panel();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.panInformacoes = new System.Windows.Forms.Panel();
            this.lblResistencia = new System.Windows.Forms.Label();
            this.cpbResistencia = new XanderUI.XUICircleProgressBar();
            this.linha3 = new System.Windows.Forms.Panel();
            this.linha2 = new System.Windows.Forms.Panel();
            this.linha1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tckResistencia = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.panInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckResistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeComponente
            // 
            this.lblNomeComponente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeComponente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeComponente.ForeColor = System.Drawing.Color.White;
            this.lblNomeComponente.Location = new System.Drawing.Point(0, 0);
            this.lblNomeComponente.Name = "lblNomeComponente";
            this.lblNomeComponente.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.lblNomeComponente.Size = new System.Drawing.Size(150, 40);
            this.lblNomeComponente.TabIndex = 1;
            this.lblNomeComponente.Text = "Resistor";
            this.lblNomeComponente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNomeComponente.Click += new System.EventHandler(this.lblNomeCompoenente_Click);
            this.lblNomeComponente.MouseEnter += new System.EventHandler(this.lblNomeCompoenente_MouseEnter);
            this.lblNomeComponente.MouseLeave += new System.EventHandler(this.lblNomeCompoenente_MouseLeave);
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
            this.imgImagem.Location = new System.Drawing.Point(20, 12);
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
            this.panInformacoes.Controls.Add(this.linha3);
            this.panInformacoes.Controls.Add(this.linha2);
            this.panInformacoes.Controls.Add(this.linha1);
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
            // linha3
            // 
            this.linha3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.linha3.Location = new System.Drawing.Point(0, 120);
            this.linha3.Name = "linha3";
            this.linha3.Size = new System.Drawing.Size(150, 3);
            this.linha3.TabIndex = 10;
            // 
            // linha2
            // 
            this.linha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.linha2.Location = new System.Drawing.Point(0, 80);
            this.linha2.Name = "linha2";
            this.linha2.Size = new System.Drawing.Size(150, 3);
            this.linha2.TabIndex = 9;
            // 
            // linha1
            // 
            this.linha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.linha1.Location = new System.Drawing.Point(0, 35);
            this.linha1.Name = "linha1";
            this.linha1.Size = new System.Drawing.Size(150, 3);
            this.linha1.TabIndex = 8;
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
            // tckResistencia
            // 
            this.tckResistencia.AutoSize = false;
            this.tckResistencia.Location = new System.Drawing.Point(3, 292);
            this.tckResistencia.Maximum = 100;
            this.tckResistencia.Minimum = 1;
            this.tckResistencia.Name = "tckResistencia";
            this.tckResistencia.Size = new System.Drawing.Size(138, 27);
            this.tckResistencia.TabIndex = 5;
            this.tckResistencia.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckResistencia.Value = 1;
            this.tckResistencia.Scroll += new System.EventHandler(this.tckResistencia_Scroll);
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
            // CaixaComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.panInformacoes);
            this.Controls.Add(this.imgImagem);
            this.Controls.Add(this.panSelecionado);
            this.Controls.Add(this.lblNomeComponente);
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
        private System.Windows.Forms.Label lblNomeComponente;
        private System.Windows.Forms.Panel panSelecionado;
        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.Panel panInformacoes;
        private System.Windows.Forms.Panel linha3;
        private System.Windows.Forms.Panel linha2;
        private System.Windows.Forms.Panel linha1;
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
