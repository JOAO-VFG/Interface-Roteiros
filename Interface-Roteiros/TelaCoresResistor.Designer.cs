
namespace Interface_Roteiros
{
    partial class TelaCoresResistor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCoresResistor));
            this.imgResistor = new System.Windows.Forms.PictureBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.boxFaixa1 = new System.Windows.Forms.ComboBox();
            this.boxFaixa2 = new System.Windows.Forms.ComboBox();
            this.boxFaixa3 = new System.Windows.Forms.ComboBox();
            this.boxFaixa4 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResistor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Electrophorus";
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
            this.imgIcone.Image = global::Interface_Roteiros.Properties.Resources.circuito_icone;
            // 
            // imgResistor
            // 
            this.imgResistor.Image = ((System.Drawing.Image)(resources.GetObject("imgResistor.Image")));
            this.imgResistor.Location = new System.Drawing.Point(125, 73);
            this.imgResistor.Name = "imgResistor";
            this.imgResistor.Size = new System.Drawing.Size(463, 167);
            this.imgResistor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgResistor.TabIndex = 4;
            this.imgResistor.TabStop = false;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(657, 248);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(46, 58);
            this.btnClick.TabIndex = 5;
            this.btnClick.Text = "Desenhar";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Faixa 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(359, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Faixa 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Faixa 3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.boxFaixa4);
            this.panel1.Controls.Add(this.boxFaixa3);
            this.panel1.Controls.Add(this.boxFaixa2);
            this.panel1.Controls.Add(this.boxFaixa1);
            this.panel1.Controls.Add(this.btnClick);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 320);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(359, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Multiplicador (faixa 4)";
            // 
            // boxFaixa1
            // 
            this.boxFaixa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFaixa1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFaixa1.FormattingEnabled = true;
            this.boxFaixa1.Items.AddRange(new object[] {
            "Selecione uma cor",
            "Preto (0)",
            "Marrom (1)",
            "Vermelho (2)",
            "Laranja (3)",
            "Amarelo (4)",
            "Verde (5)",
            "Azul (6)",
            "Violeta (7)",
            "Cinza (8)",
            "Branco (9)"});
            this.boxFaixa1.Location = new System.Drawing.Point(52, 65);
            this.boxFaixa1.Name = "boxFaixa1";
            this.boxFaixa1.Size = new System.Drawing.Size(185, 31);
            this.boxFaixa1.TabIndex = 10;
            // 
            // boxFaixa2
            // 
            this.boxFaixa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFaixa2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFaixa2.FormattingEnabled = true;
            this.boxFaixa2.Items.AddRange(new object[] {
            "Selecione uma cor",
            "Preto (0)",
            "Marrom (1)",
            "Vermelho (2)",
            "Laranja (3)",
            "Amarelo (4)",
            "Verde (5)",
            "Azul (6)",
            "Violeta (7)",
            "Cinza (8)",
            "Branco (9)"});
            this.boxFaixa2.Location = new System.Drawing.Point(364, 65);
            this.boxFaixa2.Name = "boxFaixa2";
            this.boxFaixa2.Size = new System.Drawing.Size(185, 31);
            this.boxFaixa2.TabIndex = 11;
            // 
            // boxFaixa3
            // 
            this.boxFaixa3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFaixa3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFaixa3.FormattingEnabled = true;
            this.boxFaixa3.Items.AddRange(new object[] {
            "Selecione uma cor",
            "Preto (0)",
            "Marrom (1)",
            "Vermelho (2)",
            "Laranja (3)",
            "Amarelo (4)",
            "Verde (5)",
            "Azul (6)",
            "Violeta (7)",
            "Cinza (8)",
            "Branco (9)"});
            this.boxFaixa3.Location = new System.Drawing.Point(52, 161);
            this.boxFaixa3.Name = "boxFaixa3";
            this.boxFaixa3.Size = new System.Drawing.Size(185, 31);
            this.boxFaixa3.TabIndex = 12;
            // 
            // boxFaixa4
            // 
            this.boxFaixa4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFaixa4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFaixa4.FormattingEnabled = true;
            this.boxFaixa4.Items.AddRange(new object[] {
            "Selecione uma cor",
            "Prata (0.01 Ω)",
            "Ouro (0.1 Ω)",
            "Preto (1 Ω)",
            "Marrom (10 Ω)",
            "Vermelho (100 Ω)",
            "Laranja (1K Ω)",
            "Amarelo (10K Ω)",
            "Verde (100K Ω)",
            "Azul (1M Ω)",
            "Violeta (10M Ω)"});
            this.boxFaixa4.Location = new System.Drawing.Point(364, 161);
            this.boxFaixa4.Name = "boxFaixa4";
            this.boxFaixa4.Size = new System.Drawing.Size(185, 31);
            this.boxFaixa4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 10);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor do  resistor";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox5.Enabled = false;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(52, 269);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(235, 31);
            this.comboBox5.TabIndex = 16;
            // 
            // TelaCoresResistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(715, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgResistor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCoresResistor";
            this.Text = "Cores";
            this.Load += new System.EventHandler(this.TelaCoresResistor_Load);
            this.Controls.SetChildIndex(this.imgResistor, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResistor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgResistor;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox boxFaixa1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxFaixa4;
        private System.Windows.Forms.ComboBox boxFaixa3;
        private System.Windows.Forms.ComboBox boxFaixa2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
    }
}
