
namespace Interface_Roteiros
{
    partial class TelaAjustePadrao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgImagem);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 240);
            this.panel1.TabIndex = 0;
            // 
            // imgImagem
            // 
            this.imgImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.imgImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgImagem.Image = global::Interface_Roteiros.Properties.Resources.resistor;
            this.imgImagem.Location = new System.Drawing.Point(7, 9);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(24, 24);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImagem.TabIndex = 2;
            this.imgImagem.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnSair.BackgroundImage = global::Interface_Roteiros.Properties.Resources.cancel_hover;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(373, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(24, 24);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(409, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            // 
            // TelaAjustePadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(410, 240);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaAjustePadrao";
            this.Text = "TelaAjuestePadrao";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.PictureBox imgImagem;
    }
}