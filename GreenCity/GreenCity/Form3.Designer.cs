namespace ProjetoPraticaII
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnEsgoto = new System.Windows.Forms.Button();
            this.btnFazenda = new System.Windows.Forms.Button();
            this.btnEnergia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEsgoto
            // 
            this.btnEsgoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(44)))));
            this.btnEsgoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsgoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsgoto.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsgoto.Location = new System.Drawing.Point(113, 141);
            this.btnEsgoto.Name = "btnEsgoto";
            this.btnEsgoto.Size = new System.Drawing.Size(97, 54);
            this.btnEsgoto.TabIndex = 6;
            this.btnEsgoto.Text = "Tratamento de esgoto";
            this.btnEsgoto.UseVisualStyleBackColor = false;
            this.btnEsgoto.Click += new System.EventHandler(this.btnEsgoto_Click);
            // 
            // btnFazenda
            // 
            this.btnFazenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(44)))));
            this.btnFazenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFazenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazenda.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazenda.Location = new System.Drawing.Point(635, 146);
            this.btnFazenda.Name = "btnFazenda";
            this.btnFazenda.Size = new System.Drawing.Size(110, 42);
            this.btnFazenda.TabIndex = 7;
            this.btnFazenda.Text = "Fazenda";
            this.btnFazenda.UseVisualStyleBackColor = false;
            this.btnFazenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnergia
            // 
            this.btnEnergia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(174)))), ((int)(((byte)(44)))));
            this.btnEnergia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnergia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnergia.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnergia.Location = new System.Drawing.Point(12, 361);
            this.btnEnergia.Name = "btnEnergia";
            this.btnEnergia.Size = new System.Drawing.Size(95, 41);
            this.btnEnergia.TabIndex = 8;
            this.btnEnergia.Text = "Energia";
            this.btnEnergia.UseVisualStyleBackColor = false;
            this.btnEnergia.Click += new System.EventHandler(this.btnEnergia_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoPraticaII.Properties.Resources.MapaGrande;
            this.ClientSize = new System.Drawing.Size(792, 598);
            this.Controls.Add(this.btnEnergia);
            this.Controls.Add(this.btnFazenda);
            this.Controls.Add(this.btnEsgoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(808, 636);
            this.MinimumSize = new System.Drawing.Size(808, 636);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green City";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEsgoto;
        private System.Windows.Forms.Button btnFazenda;
        private System.Windows.Forms.Button btnEnergia;
    }
}