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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEsgoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fezenda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEsgoto
            // 
            this.btnEsgoto.Location = new System.Drawing.Point(108, 125);
            this.btnEsgoto.Name = "btnEsgoto";
            this.btnEsgoto.Size = new System.Drawing.Size(80, 48);
            this.btnEsgoto.TabIndex = 1;
            this.btnEsgoto.Text = "Tratamento de esgoto";
            this.btnEsgoto.UseVisualStyleBackColor = true;
            this.btnEsgoto.Click += new System.EventHandler(this.btnEsgoto_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoPraticaII.Properties.Resources.MapaGrande;
            this.ClientSize = new System.Drawing.Size(792, 598);
            this.Controls.Add(this.btnEsgoto);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(808, 636);
            this.MinimumSize = new System.Drawing.Size(808, 636);
            this.Name = "frmPrincipal";
            this.Text = "Green City";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEsgoto;
    }
}