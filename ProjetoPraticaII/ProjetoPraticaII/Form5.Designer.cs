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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTratamentoDeEsgoto));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnIntroducao = new System.Windows.Forms.Panel();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.lbTexto = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbItem3 = new System.Windows.Forms.PictureBox();
            this.pbItem2 = new System.Windows.Forms.PictureBox();
            this.pbItem1 = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.pnIntroducao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
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
            this.pnIntroducao.Location = new System.Drawing.Point(12, 12);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.pbItem3);
            this.panel1.Controls.Add(this.pbItem2);
            this.panel1.Controls.Add(this.pbItem1);
            this.panel1.Controls.Add(this.pbMain);
            this.panel1.Location = new System.Drawing.Point(424, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 363);
            this.panel1.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbItem3
            // 
            this.pbItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbItem3.Location = new System.Drawing.Point(312, 270);
            this.pbItem3.Name = "pbItem3";
            this.pbItem3.Size = new System.Drawing.Size(140, 89);
            this.pbItem3.TabIndex = 3;
            this.pbItem3.TabStop = false;
            this.pbItem3.Click += new System.EventHandler(this.pbItem3_Click);
            // 
            // pbItem2
            // 
            this.pbItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbItem2.Location = new System.Drawing.Point(159, 270);
            this.pbItem2.Name = "pbItem2";
            this.pbItem2.Size = new System.Drawing.Size(140, 89);
            this.pbItem2.TabIndex = 2;
            this.pbItem2.TabStop = false;
            this.pbItem2.Click += new System.EventHandler(this.pbItem2_Click);
            // 
            // pbItem1
            // 
            this.pbItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbItem1.Location = new System.Drawing.Point(3, 270);
            this.pbItem1.Name = "pbItem1";
            this.pbItem1.Size = new System.Drawing.Size(140, 89);
            this.pbItem1.TabIndex = 1;
            this.pbItem1.TabStop = false;
            this.pbItem1.Click += new System.EventHandler(this.pbItem1_Click);
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMain.Location = new System.Drawing.Point(3, 3);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(449, 261);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
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
            // frmTratamentoDeEsgoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnIntroducao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTratamentoDeEsgoto";
            this.Text = "Tratamento de esgoto";
            this.Load += new System.EventHandler(this.frmTratamentoDeEsgoto_Load);
            this.pnIntroducao.ResumeLayout(false);
            this.pnIntroducao.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.PictureBox pbItem3;
        private System.Windows.Forms.PictureBox pbItem2;
        private System.Windows.Forms.PictureBox pbItem1;
        private System.Windows.Forms.Timer timer;
    }
}