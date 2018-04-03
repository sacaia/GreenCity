namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pb_jogador = new System.Windows.Forms.PictureBox();
            this.Level = new System.Windows.Forms.Timer(this.components);
            this.lb_level = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jogador)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_jogador
            // 
            this.pb_jogador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_jogador.Location = new System.Drawing.Point(380, 550);
            this.pb_jogador.Name = "pb_jogador";
            this.pb_jogador.Size = new System.Drawing.Size(150, 20);
            this.pb_jogador.TabIndex = 0;
            this.pb_jogador.TabStop = false;
            this.pb_jogador.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Level
            // 
            this.Level.Interval = 10000;
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_level.Location = new System.Drawing.Point(834, 34);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(84, 25);
            this.lb_level.TabIndex = 1;
            this.lb_level.Text = "Nivel: 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 592);
            this.Controls.Add(this.lb_level);
            this.Controls.Add(this.pb_jogador);
            this.MaximumSize = new System.Drawing.Size(950, 630);
            this.MinimumSize = new System.Drawing.Size(950, 630);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_jogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_jogador;
        private System.Windows.Forms.Timer Level;
        private System.Windows.Forms.Label lb_level;
    }
}

