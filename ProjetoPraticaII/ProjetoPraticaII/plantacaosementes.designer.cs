namespace fazenda
{
    partial class plantacaosementes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plantacaosementes));
            this.planta = new System.Windows.Forms.ImageList(this.components);
            this.bichotimer = new System.Windows.Forms.Timer(this.components);
            this.btn_mudarsemente = new System.Windows.Forms.Button();
            this.hint_plantacao = new System.Windows.Forms.ToolTip(this.components);
            this.plantacresce = new System.Windows.Forms.Timer(this.components);
            this.lb_sementeescolhida = new System.Windows.Forms.Label();
            this.pb_adubo = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pb_adubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // planta
            // 
            this.planta.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("planta.ImageStream")));
            this.planta.TransparentColor = System.Drawing.Color.Transparent;
            this.planta.Images.SetKeyName(0, "planta1.png");
            this.planta.Images.SetKeyName(1, "planta2.png");
            this.planta.Images.SetKeyName(2, "planta3.png");
            this.planta.Images.SetKeyName(3, "planta4.png");
            this.planta.Images.SetKeyName(4, "plantaMorrendo.png");
            this.planta.Images.SetKeyName(5, "plantaMorrendo2.png");
            this.planta.Images.SetKeyName(6, "plantaMorrendo3.png");
            this.planta.Images.SetKeyName(7, "plantaMorta.png");
            // 
            // bichotimer
            // 
            this.bichotimer.Enabled = true;
            this.bichotimer.Interval = 1000;
            this.bichotimer.Tick += new System.EventHandler(this.bichotimer_Tick);
            // 
            // btn_mudarsemente
            // 
            this.btn_mudarsemente.Location = new System.Drawing.Point(698, 466);
            this.btn_mudarsemente.Name = "btn_mudarsemente";
            this.btn_mudarsemente.Size = new System.Drawing.Size(75, 23);
            this.btn_mudarsemente.TabIndex = 4;
            this.btn_mudarsemente.Text = "Sementes";
            this.btn_mudarsemente.UseVisualStyleBackColor = true;
            this.btn_mudarsemente.Click += new System.EventHandler(this.btn_mudarsemente_Click);
            // 
            // hint_plantacao
            // 
            this.hint_plantacao.ToolTipTitle = "Planta";
            // 
            // plantacresce
            // 
            this.plantacresce.Enabled = true;
            this.plantacresce.Interval = 1000;
            this.plantacresce.Tick += new System.EventHandler(this.plantacresce_Tick);
            // 
            // lb_sementeescolhida
            // 
            this.lb_sementeescolhida.AutoSize = true;
            this.lb_sementeescolhida.Location = new System.Drawing.Point(672, 436);
            this.lb_sementeescolhida.Name = "lb_sementeescolhida";
            this.lb_sementeescolhida.Size = new System.Drawing.Size(101, 13);
            this.lb_sementeescolhida.TabIndex = 5;
            this.lb_sementeescolhida.Text = "Semente Escolhida:";
            // 
            // pb_adubo
            // 
            this.pb_adubo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_adubo.BackgroundImage")));
            this.pb_adubo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_adubo.Location = new System.Drawing.Point(31, 451);
            this.pb_adubo.Name = "pb_adubo";
            this.pb_adubo.Size = new System.Drawing.Size(139, 126);
            this.pb_adubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_adubo.TabIndex = 6;
            this.pb_adubo.TabStop = false;
            this.pb_adubo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_adubo_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(31, 298);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 126);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(31, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(31, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(614, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pb_1
            // 
            this.pb_1.Location = new System.Drawing.Point(614, 192);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(159, 23);
            this.pb_1.TabIndex = 7;
            // 
            // plantacaosementes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 589);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.pb_adubo);
            this.Controls.Add(this.lb_sementeescolhida);
            this.Controls.Add(this.btn_mudarsemente);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "plantacaosementes";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_adubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList planta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer bichotimer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_mudarsemente;
        private System.Windows.Forms.ToolTip hint_plantacao;
        private System.Windows.Forms.Timer plantacresce;
        private System.Windows.Forms.Label lb_sementeescolhida;
        private System.Windows.Forms.PictureBox pb_adubo;
        private System.Windows.Forms.ProgressBar pb_1;
    }
}

