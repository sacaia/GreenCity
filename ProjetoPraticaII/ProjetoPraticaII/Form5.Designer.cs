namespace ProjetoPraticaII
{
    partial class frmTratamentoDeEsgoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTratamentoDeEsgoto));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pn = new System.Windows.Forms.Panel();
            this.lbTexto = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(87, 29);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Titulo:";
            // 
            // pn
            // 
            this.pn.Controls.Add(this.pbImagem);
            this.pn.Controls.Add(this.lbTitulo);
            this.pn.Location = new System.Drawing.Point(51, 43);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(406, 262);
            this.pn.TabIndex = 1;
            // 
            // lbTexto
            // 
            this.lbTexto.Location = new System.Drawing.Point(56, 72);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(398, 103);
            this.lbTexto.TabIndex = 0;
            this.lbTexto.Text = resources.GetString("lbTexto.Text");
            // 
            // pbImagem
            // 
            this.pbImagem.BackgroundImage = global::ProjetoPraticaII.Properties.Resources.GreenCityText2;
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImagem.InitialImage = null;
            this.pbImagem.Location = new System.Drawing.Point(3, 135);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(400, 124);
            this.pbImagem.TabIndex = 1;
            this.pbImagem.TabStop = false;
            // 
            // frmTratamentoDeEsgoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 432);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.pn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTratamentoDeEsgoto";
            this.Text = "Tratamento de esgoto";
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.PictureBox pbImagem;
    }
}