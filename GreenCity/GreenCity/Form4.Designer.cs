namespace fazenda
{
    partial class frmMenuFazenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuFazenda));
            this.pb_celeiro = new System.Windows.Forms.PictureBox();
            this.pb_silo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_celeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_silo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_celeiro
            // 
            this.pb_celeiro.BackColor = System.Drawing.Color.Transparent;
            this.pb_celeiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_celeiro.BackgroundImage")));
            this.pb_celeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_celeiro.Image = ((System.Drawing.Image)(resources.GetObject("pb_celeiro.Image")));
            this.pb_celeiro.Location = new System.Drawing.Point(622, 226);
            this.pb_celeiro.Name = "pb_celeiro";
            this.pb_celeiro.Size = new System.Drawing.Size(156, 136);
            this.pb_celeiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_celeiro.TabIndex = 0;
            this.pb_celeiro.TabStop = false;
            this.pb_celeiro.Click += new System.EventHandler(this.pb_celeiro_Click);
            this.pb_celeiro.MouseEnter += new System.EventHandler(this.pb_celeiro_MouseEnter);
            this.pb_celeiro.MouseLeave += new System.EventHandler(this.pb_celeiro_MouseLeave);
            // 
            // pb_silo
            // 
            this.pb_silo.BackColor = System.Drawing.Color.Transparent;
            this.pb_silo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_silo.BackgroundImage")));
            this.pb_silo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_silo.Image = ((System.Drawing.Image)(resources.GetObject("pb_silo.Image")));
            this.pb_silo.Location = new System.Drawing.Point(784, 146);
            this.pb_silo.Name = "pb_silo";
            this.pb_silo.Size = new System.Drawing.Size(53, 235);
            this.pb_silo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_silo.TabIndex = 1;
            this.pb_silo.TabStop = false;
            this.pb_silo.Click += new System.EventHandler(this.pb_silo_Click);
            this.pb_silo.MouseEnter += new System.EventHandler(this.pb_celeiro_MouseEnter);
            this.pb_silo.MouseLeave += new System.EventHandler(this.pb_celeiro_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pb_celeiro_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pb_celeiro_MouseLeave);
            // 
            // frmMenuFazenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_silo);
            this.Controls.Add(this.pb_celeiro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuFazenda";
            this.Text = "MenuFazenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuFazenda_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_celeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_silo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_celeiro;
        private System.Windows.Forms.PictureBox pb_silo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}