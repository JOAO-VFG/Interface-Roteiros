
namespace Interface_Roteiros
{
    partial class TelaSimulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSimulador));
            this.rtrCargas = new Interface_Roteiros.Roteiro();
            this.rtrLeisOhm = new Interface_Roteiros.Roteiro();
            this.rtrKirchhof = new Interface_Roteiros.Roteiro();
            this.rtrNosEMalhas = new Interface_Roteiros.Roteiro();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(580, 35);
            this.lblTitulo.Text = "Electrophorus";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSair.Location = new System.Drawing.Point(543, 5);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnMinimizar.Location = new System.Drawing.Point(504, 5);
            // 
            // imgIcone
            // 
            this.imgIcone.Image = global::Interface_Roteiros.Properties.Resources.circuito_icone;
            // 
            // rtrCargas
            // 
            this.rtrCargas.ImagemRoteiro = ((System.Drawing.Image)(resources.GetObject("rtrCargas.ImagemRoteiro")));
            this.rtrCargas.Location = new System.Drawing.Point(190, 31);
            this.rtrCargas.Name = "rtrCargas";
            this.rtrCargas.Size = new System.Drawing.Size(163, 172);
            this.rtrCargas.TabIndex = 4;
            this.rtrCargas.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtrCargas.TextoRoteiro = "Cargas";
            // 
            // rtrLeisOhm
            // 
            this.rtrLeisOhm.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito2;
            this.rtrLeisOhm.Location = new System.Drawing.Point(119, 31);
            this.rtrLeisOhm.Name = "rtrLeisOhm";
            this.rtrLeisOhm.Size = new System.Drawing.Size(28, 26);
            this.rtrLeisOhm.TabIndex = 5;
            this.rtrLeisOhm.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtrLeisOhm.TextoRoteiro = "Potência e Divisor de Corrente";
            this.rtrLeisOhm.Click += new System.EventHandler(this.rtrLeisOhm_Click);
            // 
            // rtrKirchhof
            // 
            this.rtrKirchhof.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito3;
            this.rtrKirchhof.Location = new System.Drawing.Point(119, 168);
            this.rtrKirchhof.Name = "rtrKirchhof";
            this.rtrKirchhof.Size = new System.Drawing.Size(26, 26);
            this.rtrKirchhof.TabIndex = 6;
            this.rtrKirchhof.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtrKirchhof.TextoRoteiro = "Leis de Kirchhof";
            this.rtrKirchhof.Click += new System.EventHandler(this.rtrKirchhof_Click);
            // 
            // rtrNosEMalhas
            // 
            this.rtrNosEMalhas.ImagemRoteiro = global::Interface_Roteiros.Properties.Resources.circuito4;
            this.rtrNosEMalhas.Location = new System.Drawing.Point(119, 104);
            this.rtrNosEMalhas.Name = "rtrNosEMalhas";
            this.rtrNosEMalhas.Size = new System.Drawing.Size(26, 26);
            this.rtrNosEMalhas.TabIndex = 7;
            this.rtrNosEMalhas.TextoFont = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtrNosEMalhas.TextoRoteiro = "Super Nós e Super Malhas";
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.btnRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetornar.BackgroundImage")));
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Location = new System.Drawing.Point(23, 38);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(50, 50);
            this.btnRetornar.TabIndex = 16;
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            this.btnRetornar.MouseEnter += new System.EventHandler(this.btnRetornar_MouseEnter);
            this.btnRetornar.MouseLeave += new System.EventHandler(this.btnRetornar_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.rtrCargas);
            this.panel1.Controls.Add(this.rtrKirchhof);
            this.panel1.Controls.Add(this.rtrNosEMalhas);
            this.panel1.Controls.Add(this.rtrLeisOhm);
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 227);
            this.panel1.TabIndex = 17;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(494, 31);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(34, 172);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(39, 31);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(34, 172);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // TelaSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(575, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRetornar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaSimulador";
            this.Text = "Electrophorus";
            this.Load += new System.EventHandler(this.TelaSimulador_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.imgIcone, 0);
            this.Controls.SetChildIndex(this.btnRetornar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcone)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Roteiro rtrCargas;
        private Roteiro rtrLeisOhm;
        private Roteiro rtrKirchhof;
        private Roteiro rtrNosEMalhas;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
    }
}
