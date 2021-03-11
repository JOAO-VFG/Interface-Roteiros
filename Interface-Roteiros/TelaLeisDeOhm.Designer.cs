
namespace Interface_Roteiros
{
    partial class TelaLeisDeOhm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLeisDeOhm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblResistencia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCorrente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.painelResistor1 = new Interface_Roteiros.PainelResistor();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panCircuito = new System.Windows.Forms.Panel();
            this.lblFonte = new System.Windows.Forms.Label();
            this.lblResistor2 = new System.Windows.Forms.Label();
            this.lblResistor1 = new System.Windows.Forms.Label();
            this.lblResistor6 = new System.Windows.Forms.Label();
            this.lblResistor5 = new System.Windows.Forms.Label();
            this.lblResistor4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResistor3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panCircuito.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1046, 35);
            this.lblTitulo.Text = "Leis de Ohm - Simulador";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.Location = new System.Drawing.Point(1010, 5);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.Location = new System.Drawing.Point(969, 5);
            // 
            // imgIcone
            // 
            this.imgIcone.Image = global::Interface_Roteiros.Properties.Resources.circuito_icone;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.painelResistor1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 578);
            this.panel2.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(18)))), ((int)(((byte)(39)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(122, 501);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 44);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel8.Controls.Add(this.lblPotencia);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Location = new System.Drawing.Point(289, 337);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(110, 122);
            this.panel8.TabIndex = 8;
            // 
            // lblPotencia
            // 
            this.lblPotencia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencia.ForeColor = System.Drawing.Color.White;
            this.lblPotencia.Location = new System.Drawing.Point(4, 79);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(104, 26);
            this.lblPotencia.TabIndex = 5;
            this.lblPotencia.Text = "0W";
            this.lblPotencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(168)))));
            this.label12.Location = new System.Drawing.Point(31, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Potência";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(247)))), ((int)(((byte)(27)))));
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(110, 7);
            this.panel11.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel7.Controls.Add(this.lblResistencia);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Location = new System.Drawing.Point(152, 337);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(110, 122);
            this.panel7.TabIndex = 7;
            // 
            // lblResistencia
            // 
            this.lblResistencia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResistencia.ForeColor = System.Drawing.Color.White;
            this.lblResistencia.Location = new System.Drawing.Point(3, 77);
            this.lblResistencia.Name = "lblResistencia";
            this.lblResistencia.Size = new System.Drawing.Size(104, 26);
            this.lblResistencia.TabIndex = 4;
            this.lblResistencia.Text = "0Ω";
            this.lblResistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(168)))));
            this.label11.Location = new System.Drawing.Point(30, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Resistência Equivalente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(18)))), ((int)(((byte)(235)))));
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(110, 7);
            this.panel10.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel6.Controls.Add(this.lblCorrente);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(12, 337);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 122);
            this.panel6.TabIndex = 6;
            // 
            // lblCorrente
            // 
            this.lblCorrente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrente.ForeColor = System.Drawing.Color.White;
            this.lblCorrente.Location = new System.Drawing.Point(3, 79);
            this.lblCorrente.Name = "lblCorrente";
            this.lblCorrente.Size = new System.Drawing.Size(104, 26);
            this.lblCorrente.TabIndex = 3;
            this.lblCorrente.Text = "0V";
            this.lblCorrente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(168)))));
            this.label10.Location = new System.Drawing.Point(29, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Corrente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(56)))), ((int)(((byte)(247)))));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(110, 7);
            this.panel9.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label9.Location = new System.Drawing.Point(16, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Informações do Circuito";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(0, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 3);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(14, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 40);
            this.panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(22)))), ((int)(((byte)(171)))));
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(385, 38);
            this.label8.TabIndex = 2;
            this.label8.Text = "Resistor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // painelResistor1
            // 
            this.painelResistor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.painelResistor1.Location = new System.Drawing.Point(13, 52);
            this.painelResistor1.Name = "painelResistor1";
            this.painelResistor1.Size = new System.Drawing.Size(385, 200);
            this.painelResistor1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(20)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(411, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 578);
            this.panel3.TabIndex = 0;
            // 
            // panCircuito
            // 
            this.panCircuito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panCircuito.BackgroundImage")));
            this.panCircuito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panCircuito.Controls.Add(this.lblFonte);
            this.panCircuito.Controls.Add(this.lblResistor2);
            this.panCircuito.Controls.Add(this.lblResistor1);
            this.panCircuito.Controls.Add(this.lblResistor6);
            this.panCircuito.Controls.Add(this.lblResistor5);
            this.panCircuito.Controls.Add(this.lblResistor4);
            this.panCircuito.Controls.Add(this.label7);
            this.panCircuito.Controls.Add(this.lblResistor3);
            this.panCircuito.Controls.Add(this.label6);
            this.panCircuito.Controls.Add(this.label5);
            this.panCircuito.Controls.Add(this.label4);
            this.panCircuito.Controls.Add(this.label2);
            this.panCircuito.Controls.Add(this.label1);
            this.panCircuito.Controls.Add(this.label3);
            this.panCircuito.Location = new System.Drawing.Point(21, 65);
            this.panCircuito.Name = "panCircuito";
            this.panCircuito.Size = new System.Drawing.Size(602, 456);
            this.panCircuito.TabIndex = 14;
            // 
            // lblFonte
            // 
            this.lblFonte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFonte.Location = new System.Drawing.Point(361, 378);
            this.lblFonte.Name = "lblFonte";
            this.lblFonte.Size = new System.Drawing.Size(56, 34);
            this.lblFonte.TabIndex = 19;
            // 
            // lblResistor2
            // 
            this.lblResistor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResistor2.Location = new System.Drawing.Point(14, 225);
            this.lblResistor2.Name = "lblResistor2";
            this.lblResistor2.Size = new System.Drawing.Size(25, 67);
            this.lblResistor2.TabIndex = 18;
            // 
            // lblResistor1
            // 
            this.lblResistor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResistor1.Location = new System.Drawing.Point(178, 360);
            this.lblResistor1.Name = "lblResistor1";
            this.lblResistor1.Size = new System.Drawing.Size(65, 34);
            this.lblResistor1.TabIndex = 17;
            // 
            // lblResistor6
            // 
            this.lblResistor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResistor6.Location = new System.Drawing.Point(361, 125);
            this.lblResistor6.Name = "lblResistor6";
            this.lblResistor6.Size = new System.Drawing.Size(56, 21);
            this.lblResistor6.TabIndex = 16;
            // 
            // lblResistor5
            // 
            this.lblResistor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResistor5.Location = new System.Drawing.Point(204, 125);
            this.lblResistor5.Name = "lblResistor5";
            this.lblResistor5.Size = new System.Drawing.Size(56, 21);
            this.lblResistor5.TabIndex = 15;
            // 
            // lblResistor4
            // 
            this.lblResistor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResistor4.Location = new System.Drawing.Point(361, 48);
            this.lblResistor4.Name = "lblResistor4";
            this.lblResistor4.Size = new System.Drawing.Size(56, 21);
            this.lblResistor4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(194, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "1Ω";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResistor3
            // 
            this.lblResistor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResistor3.Location = new System.Drawing.Point(204, 48);
            this.lblResistor3.Name = "lblResistor3";
            this.lblResistor3.Size = new System.Drawing.Size(56, 21);
            this.lblResistor3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(376, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "1V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "1Ω";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(376, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "1Ω";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "1Ω";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "1Ω";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(215, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "1Ω";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panCircuito);
            this.panel1.Location = new System.Drawing.Point(424, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 575);
            this.panel1.TabIndex = 6;
            // 
            // TelaLeisDeOhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1046, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TelaLeisDeOhm";
            this.Text = "Electrophorus";
            this.Load += new System.EventHandler(this.TelaLeisDeOhm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panCircuito.ResumeLayout(false);
            this.panCircuito.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panCircuito;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.Label lblResistor2;
        private System.Windows.Forms.Label lblResistor1;
        private System.Windows.Forms.Label lblResistor6;
        private System.Windows.Forms.Label lblResistor5;
        private System.Windows.Forms.Label lblResistor4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResistor3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private PainelResistor painelResistor1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblResistencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCorrente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
    }
}
