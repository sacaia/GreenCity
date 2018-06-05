namespace fazenda
{
    partial class frmPlantacaoSementes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantacaoSementes));
            this.planta = new System.Windows.Forms.ImageList(this.components);
            this.btn_mudarsemente = new System.Windows.Forms.Button();
            this.hint_plantacao = new System.Windows.Forms.ToolTip(this.components);
            this.plantacresce = new System.Windows.Forms.Timer(this.components);
            this.lb_sementeescolhida = new System.Windows.Forms.Label();
            this.pb_1 = new System.Windows.Forms.ProgressBar();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_adubo = new System.Windows.Forms.PictureBox();
            this.pb_2 = new System.Windows.Forms.ProgressBar();
            this.pb_3 = new System.Windows.Forms.ProgressBar();
            this.pb_4 = new System.Windows.Forms.ProgressBar();
            this.panel_explicacao = new System.Windows.Forms.Panel();
            this.lb_explicacaoTitulo = new System.Windows.Forms.Label();
            this.lb_explicacao = new System.Windows.Forms.Label();
            this.pb_explicacao2 = new System.Windows.Forms.PictureBox();
            this.pb_explicacao = new System.Windows.Forms.PictureBox();
            this.btn_explicacaoJogar = new System.Windows.Forms.Button();
            this.btn_explicacoVoltar = new System.Windows.Forms.Button();
            this.brn_explicacaoProximo = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_historia = new System.Windows.Forms.Button();
            this.pb_botaomenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_adubo)).BeginInit();
            this.panel_explicacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_explicacao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_explicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_botaomenu)).BeginInit();
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
            this.lb_sementeescolhida.BackColor = System.Drawing.Color.Transparent;
            this.lb_sementeescolhida.Location = new System.Drawing.Point(672, 436);
            this.lb_sementeescolhida.Name = "lb_sementeescolhida";
            this.lb_sementeescolhida.Size = new System.Drawing.Size(101, 13);
            this.lb_sementeescolhida.TabIndex = 5;
            this.lb_sementeescolhida.Text = "Semente Escolhida:";
            // 
            // pb_1
            // 
            this.pb_1.BackColor = System.Drawing.SystemColors.Control;
            this.pb_1.Location = new System.Drawing.Point(614, 198);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(159, 23);
            this.pb_1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_1.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.pb_adubo);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(0, 592);
            this.panelMenu.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(32, 249);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 126);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(32, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // pb_adubo
            // 
            this.pb_adubo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_adubo.BackgroundImage")));
            this.pb_adubo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_adubo.Location = new System.Drawing.Point(32, 440);
            this.pb_adubo.Name = "pb_adubo";
            this.pb_adubo.Size = new System.Drawing.Size(139, 126);
            this.pb_adubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_adubo.TabIndex = 6;
            this.pb_adubo.TabStop = false;
            this.pb_adubo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_adubo_MouseDown);
            // 
            // pb_2
            // 
            this.pb_2.BackColor = System.Drawing.SystemColors.Control;
            this.pb_2.Location = new System.Drawing.Point(423, 198);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(159, 23);
            this.pb_2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_2.TabIndex = 15;
            // 
            // pb_3
            // 
            this.pb_3.BackColor = System.Drawing.SystemColors.Control;
            this.pb_3.Location = new System.Drawing.Point(423, 381);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(159, 23);
            this.pb_3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_3.TabIndex = 16;
            // 
            // pb_4
            // 
            this.pb_4.BackColor = System.Drawing.SystemColors.Control;
            this.pb_4.Location = new System.Drawing.Point(614, 381);
            this.pb_4.Name = "pb_4";
            this.pb_4.Size = new System.Drawing.Size(159, 23);
            this.pb_4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_4.TabIndex = 17;
            // 
            // panel_explicacao
            // 
            this.panel_explicacao.Controls.Add(this.lb_explicacaoTitulo);
            this.panel_explicacao.Controls.Add(this.lb_explicacao);
            this.panel_explicacao.Controls.Add(this.pb_explicacao2);
            this.panel_explicacao.Controls.Add(this.pb_explicacao);
            this.panel_explicacao.Controls.Add(this.btn_explicacaoJogar);
            this.panel_explicacao.Controls.Add(this.btn_explicacoVoltar);
            this.panel_explicacao.Controls.Add(this.brn_explicacaoProximo);
            this.panel_explicacao.Location = new System.Drawing.Point(1, 2);
            this.panel_explicacao.Name = "panel_explicacao";
            this.panel_explicacao.Size = new System.Drawing.Size(820, 584);
            this.panel_explicacao.TabIndex = 18;
            // 
            // lb_explicacaoTitulo
            // 
            this.lb_explicacaoTitulo.AutoSize = true;
            this.lb_explicacaoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_explicacaoTitulo.Location = new System.Drawing.Point(453, 537);
            this.lb_explicacaoTitulo.Name = "lb_explicacaoTitulo";
            this.lb_explicacaoTitulo.Size = new System.Drawing.Size(275, 20);
            this.lb_explicacaoTitulo.TabIndex = 7;
            this.lb_explicacaoTitulo.Text = "Problemas com Adubos Químicos";
            // 
            // lb_explicacao
            // 
            this.lb_explicacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_explicacao.Location = new System.Drawing.Point(27, 247);
            this.lb_explicacao.Name = "lb_explicacao";
            this.lb_explicacao.Size = new System.Drawing.Size(745, 240);
            this.lb_explicacao.TabIndex = 6;
            this.lb_explicacao.Text = resources.GetString("lb_explicacao.Text");
            // 
            // pb_explicacao2
            // 
            this.pb_explicacao2.BackgroundImage = global::ProjetoPraticaII.Properties.Resources.baciaHidrografica;
            this.pb_explicacao2.Location = new System.Drawing.Point(422, 12);
            this.pb_explicacao2.Name = "pb_explicacao2";
            this.pb_explicacao2.Size = new System.Drawing.Size(341, 207);
            this.pb_explicacao2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_explicacao2.TabIndex = 5;
            this.pb_explicacao2.TabStop = false;
            // 
            // pb_explicacao
            // 
            this.pb_explicacao.Image = global::ProjetoPraticaII.Properties.Resources.aduboQuimico;
            this.pb_explicacao.Location = new System.Drawing.Point(31, 12);
            this.pb_explicacao.Name = "pb_explicacao";
            this.pb_explicacao.Size = new System.Drawing.Size(341, 207);
            this.pb_explicacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_explicacao.TabIndex = 3;
            this.pb_explicacao.TabStop = false;
            // 
            // btn_explicacaoJogar
            // 
            this.btn_explicacaoJogar.Enabled = false;
            this.btn_explicacaoJogar.Location = new System.Drawing.Point(186, 537);
            this.btn_explicacaoJogar.Name = "btn_explicacaoJogar";
            this.btn_explicacaoJogar.Size = new System.Drawing.Size(75, 23);
            this.btn_explicacaoJogar.TabIndex = 2;
            this.btn_explicacaoJogar.Text = "Jogar";
            this.btn_explicacaoJogar.UseVisualStyleBackColor = true;
            this.btn_explicacaoJogar.Click += new System.EventHandler(this.btn_explicacaoJogar_Click);
            // 
            // btn_explicacoVoltar
            // 
            this.btn_explicacoVoltar.Enabled = false;
            this.btn_explicacoVoltar.Location = new System.Drawing.Point(63, 537);
            this.btn_explicacoVoltar.Name = "btn_explicacoVoltar";
            this.btn_explicacoVoltar.Size = new System.Drawing.Size(75, 23);
            this.btn_explicacoVoltar.TabIndex = 1;
            this.btn_explicacoVoltar.Text = "Voltar";
            this.btn_explicacoVoltar.UseVisualStyleBackColor = true;
            this.btn_explicacoVoltar.Click += new System.EventHandler(this.btn_explicacoVoltar_Click);
            // 
            // brn_explicacaoProximo
            // 
            this.brn_explicacaoProximo.Location = new System.Drawing.Point(308, 537);
            this.brn_explicacaoProximo.Name = "brn_explicacaoProximo";
            this.brn_explicacaoProximo.Size = new System.Drawing.Size(75, 23);
            this.brn_explicacaoProximo.TabIndex = 0;
            this.brn_explicacaoProximo.Text = "Próximo";
            this.brn_explicacaoProximo.UseVisualStyleBackColor = true;
            this.brn_explicacaoProximo.Click += new System.EventHandler(this.brn_explicacaoProximo_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(614, 227);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(159, 148);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(423, 227);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(159, 148);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(423, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 148);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // btn_historia
            // 
            this.btn_historia.BackgroundImage = global::ProjetoPraticaII.Properties.Resources.duvida;
            this.btn_historia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_historia.Location = new System.Drawing.Point(778, 556);
            this.btn_historia.Name = "btn_historia";
            this.btn_historia.Size = new System.Drawing.Size(31, 30);
            this.btn_historia.TabIndex = 11;
            this.btn_historia.UseVisualStyleBackColor = true;
            this.btn_historia.Click += new System.EventHandler(this.btn_historia_Click);
            // 
            // pb_botaomenu
            // 
            this.pb_botaomenu.BackColor = System.Drawing.Color.Transparent;
            this.pb_botaomenu.Image = global::ProjetoPraticaII.Properties.Resources.fazenda_SetaMenuDireita;
            this.pb_botaomenu.Location = new System.Drawing.Point(1, 200);
            this.pb_botaomenu.Name = "pb_botaomenu";
            this.pb_botaomenu.Size = new System.Drawing.Size(76, 88);
            this.pb_botaomenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_botaomenu.TabIndex = 9;
            this.pb_botaomenu.TabStop = false;
            this.pb_botaomenu.Click += new System.EventHandler(this.pb_botaomenu_Click);
            this.pb_botaomenu.MouseEnter += new System.EventHandler(this.pb_botaomenu_MouseEnter);
            this.pb_botaomenu.MouseLeave += new System.EventHandler(this.pb_botaomenu_MouseLeave);
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
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // frmPlantacaoSementes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ProjetoPraticaII.Properties.Resources.fundo_fazenda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 589);
            this.Controls.Add(this.panel_explicacao);
            this.Controls.Add(this.pb_4);
            this.Controls.Add(this.pb_3);
            this.Controls.Add(this.pb_2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_historia);
            this.Controls.Add(this.pb_botaomenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.lb_sementeescolhida);
            this.Controls.Add(this.btn_mudarsemente);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlantacaoSementes";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_adubo)).EndInit();
            this.panel_explicacao.ResumeLayout(false);
            this.panel_explicacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_explicacao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_explicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_botaomenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList planta;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_mudarsemente;
        private System.Windows.Forms.ToolTip hint_plantacao;
        private System.Windows.Forms.Timer plantacresce;
        private System.Windows.Forms.Label lb_sementeescolhida;
        private System.Windows.Forms.PictureBox pb_adubo;
        private System.Windows.Forms.ProgressBar pb_1;
        private System.Windows.Forms.PictureBox pb_botaomenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_historia;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ProgressBar pb_2;
        private System.Windows.Forms.ProgressBar pb_3;
        private System.Windows.Forms.ProgressBar pb_4;
        private System.Windows.Forms.Panel panel_explicacao;
        private System.Windows.Forms.PictureBox pb_explicacao2;
        private System.Windows.Forms.PictureBox pb_explicacao;
        private System.Windows.Forms.Button btn_explicacaoJogar;
        private System.Windows.Forms.Button btn_explicacoVoltar;
        private System.Windows.Forms.Button brn_explicacaoProximo;
        private System.Windows.Forms.Label lb_explicacaoTitulo;
        private System.Windows.Forms.Label lb_explicacao;
    }
}

