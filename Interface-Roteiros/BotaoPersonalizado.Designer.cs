﻿
namespace Interface_Roteiros
{
    partial class BotaoPersonalizado
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
            this.btnPersonalizado = new System.Windows.Forms.Button();
            this.panBotao = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonalizado
            // 
            this.btnPersonalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.btnPersonalizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPersonalizado.FlatAppearance.BorderSize = 0;
            this.btnPersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalizado.Location = new System.Drawing.Point(0, 0);
            this.btnPersonalizado.Name = "btnPersonalizado";
            this.btnPersonalizado.Size = new System.Drawing.Size(100, 100);
            this.btnPersonalizado.TabIndex = 0;
            this.btnPersonalizado.UseVisualStyleBackColor = false;
            this.btnPersonalizado.Click += new System.EventHandler(this.btnPersonalizado_Click);
            this.btnPersonalizado.MouseEnter += new System.EventHandler(this.btnPersonalizado_MouseEnter);
            this.btnPersonalizado.MouseLeave += new System.EventHandler(this.btnPersonalizado_MouseLeave);
            // 
            // panBotao
            // 
            this.panBotao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.panBotao.Location = new System.Drawing.Point(0, 95);
            this.panBotao.Name = "panBotao";
            this.panBotao.Size = new System.Drawing.Size(100, 5);
            this.panBotao.TabIndex = 1;
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.lblTexto.Location = new System.Drawing.Point(0, 76);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(100, 16);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "1";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotaoPersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.panBotao);
            this.Controls.Add(this.btnPersonalizado);
            this.Name = "BotaoPersonalizado";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonalizado;
        private System.Windows.Forms.Panel panBotao;
        private System.Windows.Forms.Label lblTexto;
    }
}