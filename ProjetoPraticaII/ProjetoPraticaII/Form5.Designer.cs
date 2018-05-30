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
            this.pnIntroducao = new System.Windows.Forms.Panel();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.lbTexto = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.pnIntroducao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(96, 43);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Titulo:";
            // 
            // pnIntroducao
            // 
            this.pnIntroducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(180)))));
            this.pnIntroducao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnIntroducao.Controls.Add(this.btnJogar);
            this.pnIntroducao.Controls.Add(this.btnAnt);
            this.pnIntroducao.Controls.Add(this.btnProx);
            this.pnIntroducao.Controls.Add(this.lbTexto);
            this.pnIntroducao.Controls.Add(this.pbImagem);
            this.pnIntroducao.Controls.Add(this.lbTitulo);
            this.pnIntroducao.Location = new System.Drawing.Point(46, 28);
            this.pnIntroducao.Name = "pnIntroducao";
            this.pnIntroducao.Size = new System.Drawing.Size(406, 363);
            this.pnIntroducao.TabIndex = 1;
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(3, 335);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(75, 23);
            this.btnAnt.TabIndex = 3;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(326, 335);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(75, 23);
            this.btnProx.TabIndex = 2;
            this.btnProx.Text = "Proximo";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // lbTexto
            // 
            this.lbTexto.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.Location = new System.Drawing.Point(5, 43);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(398, 143);
            this.lbTexto.TabIndex = 0;
            this.lbTexto.Text = resources.GetString("lbTexto.Text");
            // 
            // pbImagem
            // 
            this.pbImagem.BackgroundImage = global::ProjetoPraticaII.Properties.Resources.aguaReciclavelPequena;
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImagem.InitialImage = null;
            this.pbImagem.Location = new System.Drawing.Point(1, 189);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(400, 140);
            this.pbImagem.TabIndex = 1;
            this.pbImagem.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(162, 335);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // frmTratamentoDeEsgoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 434);
            this.Controls.Add(this.pnIntroducao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTratamentoDeEsgoto";
            this.Text = "Tratamento de esgoto";
            this.Load += new System.EventHandler(this.frmTratamentoDeEsgoto_Load);
            this.pnIntroducao.ResumeLayout(false);
            this.pnIntroducao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pnIntroducao;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnJogar;
    }
}