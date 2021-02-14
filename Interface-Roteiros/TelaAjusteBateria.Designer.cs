
namespace Interface_Roteiros
{
    partial class TelaAjusteBateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAjusteBateria));
            this.lblTensao = new System.Windows.Forms.Label();
            this.tckTensao = new System.Windows.Forms.TrackBar();
            this.lblTensao2 = new System.Windows.Forms.Label();
            this.cpbTensao = new XanderUI.XUICircleProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCorrente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.panPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckTensao)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panPainel
            // 
            this.panPainel.Controls.Add(this.pictureBox1);
            this.panPainel.Controls.Add(this.lblCorrente);
            this.panPainel.Controls.Add(this.label4);
            this.panPainel.Controls.Add(this.panel4);
            this.panPainel.Controls.Add(this.panel3);
            this.panPainel.Controls.Add(this.lblTensao);
            this.panPainel.Controls.Add(this.tckTensao);
            this.panPainel.Controls.Add(this.lblTensao2);
            this.panPainel.Controls.Add(this.cpbTensao);
            this.panPainel.Controls.SetChildIndex(this.cpbTensao, 0);
            this.panPainel.Controls.SetChildIndex(this.lblTensao2, 0);
            this.panPainel.Controls.SetChildIndex(this.tckTensao, 0);
            this.panPainel.Controls.SetChildIndex(this.lblTensao, 0);
            this.panPainel.Controls.SetChildIndex(this.panel3, 0);
            this.panPainel.Controls.SetChildIndex(this.panel4, 0);
            this.panPainel.Controls.SetChildIndex(this.lblTitulo, 0);
            this.panPainel.Controls.SetChildIndex(this.imgImagem, 0);
            this.panPainel.Controls.SetChildIndex(this.label4, 0);
            this.panPainel.Controls.SetChildIndex(this.lblCorrente, 0);
            this.panPainel.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // lblTensao
            // 
            this.lblTensao.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.lblTensao.Location = new System.Drawing.Point(48, 116);
            this.lblTensao.Name = "lblTensao";
            this.lblTensao.Size = new System.Drawing.Size(70, 29);
            this.lblTensao.TabIndex = 32;
            this.lblTensao.Text = "20V";
            this.lblTensao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tckTensao
            // 
            this.tckTensao.Location = new System.Drawing.Point(-2, 205);
            this.tckTensao.Maximum = 100;
            this.tckTensao.Minimum = 1;
            this.tckTensao.Name = "tckTensao";
            this.tckTensao.Size = new System.Drawing.Size(157, 45);
            this.tckTensao.TabIndex = 31;
            this.tckTensao.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckTensao.Value = 20;
            this.tckTensao.Scroll += new System.EventHandler(this.tckTensao_Scroll);
            // 
            // lblTensao2
            // 
            this.lblTensao2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensao2.ForeColor = System.Drawing.Color.White;
            this.lblTensao2.Location = new System.Drawing.Point(30, 39);
            this.lblTensao2.Name = "lblTensao2";
            this.lblTensao2.Size = new System.Drawing.Size(110, 36);
            this.lblTensao2.TabIndex = 30;
            this.lblTensao2.Text = "Tensão";
            this.lblTensao2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbTensao
            // 
            this.cpbTensao.AnimationSpeed = 10;
            this.cpbTensao.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.cpbTensao.FilledColorAlpha = 150;
            this.cpbTensao.FilledThickness = 15;
            this.cpbTensao.IsAnimated = false;
            this.cpbTensao.Location = new System.Drawing.Point(30, 77);
            this.cpbTensao.Name = "cpbTensao";
            this.cpbTensao.Percentage = 20;
            this.cpbTensao.ShowText = false;
            this.cpbTensao.Size = new System.Drawing.Size(110, 110);
            this.cpbTensao.TabIndex = 29;
            this.cpbTensao.TextColor = System.Drawing.Color.Gray;
            this.cpbTensao.TextSize = 15;
            this.cpbTensao.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.cpbTensao.UnfilledThickness = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(165, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 204);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(171)))), ((int)(((byte)(142)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(171, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 35);
            this.panel4.TabIndex = 34;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // lblCorrente
            // 
            this.lblCorrente.AutoSize = true;
            this.lblCorrente.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(199)))), ((int)(((byte)(201)))));
            this.lblCorrente.Location = new System.Drawing.Point(292, 93);
            this.lblCorrente.Name = "lblCorrente";
            this.lblCorrente.Size = new System.Drawing.Size(28, 19);
            this.lblCorrente.TabIndex = 36;
            this.lblCorrente.Text = "0A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(199)))), ((int)(((byte)(201)))));
            this.label4.Location = new System.Drawing.Point(208, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Corrente:";
            // 
            // TelaAjusteBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(410, 240);
            this.Name = "TelaAjusteBateria";
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.panPainel.ResumeLayout(false);
            this.panPainel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckTensao)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTensao;
        private System.Windows.Forms.TrackBar tckTensao;
        private System.Windows.Forms.Label lblTensao2;
        private XanderUI.XUICircleProgressBar cpbTensao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCorrente;
        private System.Windows.Forms.Label label4;
    }
}
