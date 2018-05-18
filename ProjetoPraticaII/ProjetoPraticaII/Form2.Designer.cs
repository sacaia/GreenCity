namespace ProjetoPraticaII
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.txbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.llbLogin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ProjetoPraticaII.Properties.Resources.GreenCityText2;
            this.pictureBox1.Location = new System.Drawing.Point(41, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(44)))));
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(41, 294);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(298, 37);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Criar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(188, 235);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(153, 20);
            this.txbSenha.TabIndex = 2;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(188, 205);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(153, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(38, 230);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(65, 28);
            this.lbSenha.TabIndex = 7;
            this.lbSenha.Text = "Senha:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(38, 200);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(96, 28);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Username:";
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarSenha.Location = new System.Drawing.Point(38, 260);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(151, 28);
            this.lbConfirmarSenha.TabIndex = 11;
            this.lbConfirmarSenha.Text = "Confirmar senha:";
            // 
            // txbConfirmarSenha
            // 
            this.txbConfirmarSenha.Location = new System.Drawing.Point(188, 265);
            this.txbConfirmarSenha.Name = "txbConfirmarSenha";
            this.txbConfirmarSenha.Size = new System.Drawing.Size(153, 20);
            this.txbConfirmarSenha.TabIndex = 3;
            this.txbConfirmarSenha.UseSystemPasswordChar = true;
            this.txbConfirmarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbConfirmarSenha_KeyDown);
            // 
            // llbLogin
            // 
            this.llbLogin.AutoSize = true;
            this.llbLogin.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLogin.LinkColor = System.Drawing.Color.Blue;
            this.llbLogin.Location = new System.Drawing.Point(39, 351);
            this.llbLogin.Name = "llbLogin";
            this.llbLogin.Size = new System.Drawing.Size(140, 21);
            this.llbLogin.TabIndex = 13;
            this.llbLogin.TabStop = true;
            this.llbLogin.Text = "Já possui uma conta?";
            this.llbLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogin_LinkClicked);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(384, 387);
            this.Controls.Add(this.llbLogin);
            this.Controls.Add(this.txbConfirmarSenha);
            this.Controls.Add(this.lbConfirmarSenha);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 425);
            this.MinimumSize = new System.Drawing.Size(400, 425);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green City";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastro_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox txbConfirmarSenha;
        private System.Windows.Forms.LinkLabel llbLogin;
    }
}