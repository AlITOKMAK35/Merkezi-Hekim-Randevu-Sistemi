namespace MHRS
{
    partial class Hasta_kayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hasta_ad_kayit = new System.Windows.Forms.TextBox();
            this.hasta_soyad_kayit = new System.Windows.Forms.TextBox();
            this.hasta_tc_no_kayit = new System.Windows.Forms.MaskedTextBox();
            this.hasta_telefon_kayit = new System.Windows.Forms.MaskedTextBox();
            this.hasta_sifre_kayit = new System.Windows.Forms.TextBox();
            this.hasta_cinsiyet_kayit = new System.Windows.Forms.ComboBox();
            this.kayıt_ol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Kayıt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(128, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tc No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şifre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cinsiyet";
            // 
            // hasta_ad_kayit
            // 
            this.hasta_ad_kayit.Location = new System.Drawing.Point(131, 89);
            this.hasta_ad_kayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasta_ad_kayit.Name = "hasta_ad_kayit";
            this.hasta_ad_kayit.Size = new System.Drawing.Size(92, 20);
            this.hasta_ad_kayit.TabIndex = 8;
//            this.hasta_ad_kayit.TextChanged += new System.EventHandler(this.hasta_ad_kayit_TextChanged);
            // 
            // hasta_soyad_kayit
            // 
            this.hasta_soyad_kayit.Location = new System.Drawing.Point(131, 127);
            this.hasta_soyad_kayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasta_soyad_kayit.Name = "hasta_soyad_kayit";
            this.hasta_soyad_kayit.Size = new System.Drawing.Size(92, 20);
            this.hasta_soyad_kayit.TabIndex = 9;
            // 
            // hasta_tc_no_kayit
            // 
            this.hasta_tc_no_kayit.Location = new System.Drawing.Point(131, 162);
            this.hasta_tc_no_kayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasta_tc_no_kayit.Mask = "00000000000";
            this.hasta_tc_no_kayit.Name = "hasta_tc_no_kayit";
            this.hasta_tc_no_kayit.Size = new System.Drawing.Size(92, 20);
            this.hasta_tc_no_kayit.TabIndex = 10;
            // 
            // hasta_telefon_kayit
            // 
            this.hasta_telefon_kayit.Location = new System.Drawing.Point(131, 200);
            this.hasta_telefon_kayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasta_telefon_kayit.Mask = "(999) 000-0000";
            this.hasta_telefon_kayit.Name = "hasta_telefon_kayit";
            this.hasta_telefon_kayit.Size = new System.Drawing.Size(92, 20);
            this.hasta_telefon_kayit.TabIndex = 11;
            // 
            // hasta_sifre_kayit
            // 
            this.hasta_sifre_kayit.Location = new System.Drawing.Point(131, 241);
            this.hasta_sifre_kayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasta_sifre_kayit.Name = "hasta_sifre_kayit";
            this.hasta_sifre_kayit.Size = new System.Drawing.Size(92, 20);
            this.hasta_sifre_kayit.TabIndex = 12;
            // 
            // hasta_cinsiyet_kayit
            // 
            this.hasta_cinsiyet_kayit.FormattingEnabled = true;
            this.hasta_cinsiyet_kayit.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.hasta_cinsiyet_kayit.Location = new System.Drawing.Point(131, 276);
            this.hasta_cinsiyet_kayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasta_cinsiyet_kayit.Name = "hasta_cinsiyet_kayit";
            this.hasta_cinsiyet_kayit.Size = new System.Drawing.Size(92, 21);
            this.hasta_cinsiyet_kayit.TabIndex = 13;
            // 
            // kayıt_ol
            // 
            this.kayıt_ol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıt_ol.Location = new System.Drawing.Point(62, 345);
            this.kayıt_ol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kayıt_ol.Name = "kayıt_ol";
            this.kayıt_ol.Size = new System.Drawing.Size(97, 34);
            this.kayıt_ol.TabIndex = 14;
            this.kayıt_ol.Text = "Kayıt Ol";
            this.kayıt_ol.UseVisualStyleBackColor = true;
            this.kayıt_ol.Click += new System.EventHandler(this.kayıt_ol_Click);
            // 
            // Hasta_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 544);
            this.Controls.Add(this.kayıt_ol);
            this.Controls.Add(this.hasta_cinsiyet_kayit);
            this.Controls.Add(this.hasta_sifre_kayit);
            this.Controls.Add(this.hasta_telefon_kayit);
            this.Controls.Add(this.hasta_tc_no_kayit);
            this.Controls.Add(this.hasta_soyad_kayit);
            this.Controls.Add(this.hasta_ad_kayit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hasta_kayit";
            this.Text = "Hasta_kayit";
            this.Load += new System.EventHandler(this.Hasta_kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hasta_ad_kayit;
        private System.Windows.Forms.TextBox hasta_soyad_kayit;
        private System.Windows.Forms.MaskedTextBox hasta_tc_no_kayit;
        private System.Windows.Forms.MaskedTextBox hasta_telefon_kayit;
        private System.Windows.Forms.TextBox hasta_sifre_kayit;
        private System.Windows.Forms.ComboBox hasta_cinsiyet_kayit;
        private System.Windows.Forms.Button kayıt_ol;
    }
}