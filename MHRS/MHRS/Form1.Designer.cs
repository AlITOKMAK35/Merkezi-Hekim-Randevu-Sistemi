namespace MHRS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.giris_doktor = new System.Windows.Forms.Button();
            this.giris_sekreter = new System.Windows.Forms.Button();
            this.giris_hasta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giris_doktor
            // 
            this.giris_doktor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.giris_doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_doktor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.giris_doktor.Location = new System.Drawing.Point(18, 26);
            this.giris_doktor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giris_doktor.Name = "giris_doktor";
            this.giris_doktor.Size = new System.Drawing.Size(144, 116);
            this.giris_doktor.TabIndex = 0;
            this.giris_doktor.Text = "Doktor";
            this.giris_doktor.UseVisualStyleBackColor = false;
            this.giris_doktor.Click += new System.EventHandler(this.giris_doktor_Click);
            // 
            // giris_sekreter
            // 
            this.giris_sekreter.BackColor = System.Drawing.Color.Sienna;
            this.giris_sekreter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_sekreter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.giris_sekreter.Location = new System.Drawing.Point(18, 147);
            this.giris_sekreter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giris_sekreter.Name = "giris_sekreter";
            this.giris_sekreter.Size = new System.Drawing.Size(144, 120);
            this.giris_sekreter.TabIndex = 1;
            this.giris_sekreter.Text = "Sekreter";
            this.giris_sekreter.UseVisualStyleBackColor = false;
            this.giris_sekreter.Click += new System.EventHandler(this.giris_sekreter_Click);
            // 
            // giris_hasta
            // 
            this.giris_hasta.BackColor = System.Drawing.Color.SaddleBrown;
            this.giris_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_hasta.Location = new System.Drawing.Point(18, 280);
            this.giris_hasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giris_hasta.Name = "giris_hasta";
            this.giris_hasta.Size = new System.Drawing.Size(144, 115);
            this.giris_hasta.TabIndex = 2;
            this.giris_hasta.Text = "Hasta";
            this.giris_hasta.UseVisualStyleBackColor = false;
            this.giris_hasta.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MHRS.Properties.Resources._24132049_Milli_EYitim_BakanlYYY_Arma_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(490, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(471, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Özel limit kurs ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MHRS.Properties.Resources.MHRS_Logo_1;
            this.ClientSize = new System.Drawing.Size(826, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.giris_hasta);
            this.Controls.Add(this.giris_sekreter);
            this.Controls.Add(this.giris_doktor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris_doktor;
        private System.Windows.Forms.Button giris_sekreter;
        private System.Windows.Forms.Button giris_hasta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

