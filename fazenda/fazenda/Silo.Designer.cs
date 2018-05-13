namespace fazenda
{
    partial class Silo
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
            this.lb_silo = new System.Windows.Forms.Label();
            this.lb_qtdcapim = new System.Windows.Forms.Label();
            this.lb_qtdcafe = new System.Windows.Forms.Label();
            this.lb_qtdmilho = new System.Windows.Forms.Label();
            this.lb_qtdtrigo = new System.Windows.Forms.Label();
            this.btn_mercado = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lb_dinheiro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_silo
            // 
            this.lb_silo.AutoSize = true;
            this.lb_silo.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_silo.Location = new System.Drawing.Point(191, 18);
            this.lb_silo.Name = "lb_silo";
            this.lb_silo.Size = new System.Drawing.Size(50, 30);
            this.lb_silo.TabIndex = 0;
            this.lb_silo.Text = "Silo";
            // 
            // lb_qtdcapim
            // 
            this.lb_qtdcapim.AutoSize = true;
            this.lb_qtdcapim.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtdcapim.Location = new System.Drawing.Point(87, 84);
            this.lb_qtdcapim.Name = "lb_qtdcapim";
            this.lb_qtdcapim.Size = new System.Drawing.Size(67, 19);
            this.lb_qtdcapim.TabIndex = 1;
            this.lb_qtdcapim.Text = "Capim : 0";
            // 
            // lb_qtdcafe
            // 
            this.lb_qtdcafe.AutoSize = true;
            this.lb_qtdcafe.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtdcafe.Location = new System.Drawing.Point(87, 112);
            this.lb_qtdcafe.Name = "lb_qtdcafe";
            this.lb_qtdcafe.Size = new System.Drawing.Size(56, 19);
            this.lb_qtdcafe.TabIndex = 2;
            this.lb_qtdcafe.Text = "Café : 0";
            // 
            // lb_qtdmilho
            // 
            this.lb_qtdmilho.AutoSize = true;
            this.lb_qtdmilho.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtdmilho.Location = new System.Drawing.Point(87, 139);
            this.lb_qtdmilho.Name = "lb_qtdmilho";
            this.lb_qtdmilho.Size = new System.Drawing.Size(59, 19);
            this.lb_qtdmilho.TabIndex = 3;
            this.lb_qtdmilho.Text = "Milho: 0";
            // 
            // lb_qtdtrigo
            // 
            this.lb_qtdtrigo.AutoSize = true;
            this.lb_qtdtrigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtdtrigo.Location = new System.Drawing.Point(87, 168);
            this.lb_qtdtrigo.Name = "lb_qtdtrigo";
            this.lb_qtdtrigo.Size = new System.Drawing.Size(59, 19);
            this.lb_qtdtrigo.TabIndex = 4;
            this.lb_qtdtrigo.Text = "Trigo : 0";
            // 
            // btn_mercado
            // 
            this.btn_mercado.Location = new System.Drawing.Point(348, 280);
            this.btn_mercado.Name = "btn_mercado";
            this.btn_mercado.Size = new System.Drawing.Size(75, 23);
            this.btn_mercado.TabIndex = 5;
            this.btn_mercado.Text = "Mercado";
            this.btn_mercado.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(29, 280);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 6;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // lb_dinheiro
            // 
            this.lb_dinheiro.AutoSize = true;
            this.lb_dinheiro.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dinheiro.Location = new System.Drawing.Point(87, 215);
            this.lb_dinheiro.Name = "lb_dinheiro";
            this.lb_dinheiro.Size = new System.Drawing.Size(92, 20);
            this.lb_dinheiro.TabIndex = 7;
            this.lb_dinheiro.Text = "Dinheiro : 0";
            // 
            // Silo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 348);
            this.Controls.Add(this.lb_dinheiro);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_mercado);
            this.Controls.Add(this.lb_qtdtrigo);
            this.Controls.Add(this.lb_qtdmilho);
            this.Controls.Add(this.lb_qtdcafe);
            this.Controls.Add(this.lb_qtdcapim);
            this.Controls.Add(this.lb_silo);
            this.Name = "Silo";
            this.Text = "Silo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_silo;
        private System.Windows.Forms.Label lb_qtdcapim;
        private System.Windows.Forms.Label lb_qtdcafe;
        private System.Windows.Forms.Label lb_qtdmilho;
        private System.Windows.Forms.Label lb_qtdtrigo;
        private System.Windows.Forms.Button btn_mercado;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lb_dinheiro;
    }
}