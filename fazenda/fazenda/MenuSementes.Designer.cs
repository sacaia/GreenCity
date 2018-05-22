namespace fazenda
{
    partial class MenuSementes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_trigo = new System.Windows.Forms.Button();
            this.btn_cafe = new System.Windows.Forms.Button();
            this.btn_milho = new System.Windows.Forms.Button();
            this.btn_capim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual semente você deseja plantar?";
            // 
            // btn_trigo
            // 
            this.btn_trigo.Location = new System.Drawing.Point(29, 64);
            this.btn_trigo.Name = "btn_trigo";
            this.btn_trigo.Size = new System.Drawing.Size(75, 23);
            this.btn_trigo.TabIndex = 1;
            this.btn_trigo.Text = "Trigo";
            this.btn_trigo.UseVisualStyleBackColor = true;
            this.btn_trigo.Click += new System.EventHandler(this.btn_trigo_Click);
            // 
            // btn_cafe
            // 
            this.btn_cafe.Location = new System.Drawing.Point(149, 64);
            this.btn_cafe.Name = "btn_cafe";
            this.btn_cafe.Size = new System.Drawing.Size(75, 23);
            this.btn_cafe.TabIndex = 2;
            this.btn_cafe.Text = "Café";
            this.btn_cafe.UseVisualStyleBackColor = true;
            this.btn_cafe.Click += new System.EventHandler(this.btn_trigo_Click);
            // 
            // btn_milho
            // 
            this.btn_milho.Location = new System.Drawing.Point(295, 64);
            this.btn_milho.Name = "btn_milho";
            this.btn_milho.Size = new System.Drawing.Size(75, 23);
            this.btn_milho.TabIndex = 3;
            this.btn_milho.Text = "Milho";
            this.btn_milho.UseVisualStyleBackColor = true;
            this.btn_milho.Click += new System.EventHandler(this.btn_trigo_Click);
            // 
            // btn_capim
            // 
            this.btn_capim.Location = new System.Drawing.Point(444, 64);
            this.btn_capim.Name = "btn_capim";
            this.btn_capim.Size = new System.Drawing.Size(75, 23);
            this.btn_capim.TabIndex = 4;
            this.btn_capim.Text = "Capim";
            this.btn_capim.UseVisualStyleBackColor = true;
            this.btn_capim.Click += new System.EventHandler(this.btn_trigo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 265);
            this.Controls.Add(this.btn_capim);
            this.Controls.Add(this.btn_milho);
            this.Controls.Add(this.btn_cafe);
            this.Controls.Add(this.btn_trigo);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_trigo;
        private System.Windows.Forms.Button btn_cafe;
        private System.Windows.Forms.Button btn_milho;
        private System.Windows.Forms.Button btn_capim;
    }
}