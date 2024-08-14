using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRS
{
    public partial class Hasta_Ekranı : Form
    {
        internal string tcno;

        public Hasta_Ekranı()
        {
            InitializeComponent();
        }

        private void randevu_al_Click(object sender, EventArgs e)
        {

        }
    }
    namespace HastaneProjesi
    {
        partial class Hasta_Ekrani : Hasta_EkraniBase
        {
            private System.ComponentModel.IContainer components = null;

            #region Windows Form Designer generated code

            private void InitializeComponent()
            {
                this.labelTcNo = new System.Windows.Forms.Label();
                this.labelAdSoyad = new System.Windows.Forms.Label();
                this.labelTcNoText = new System.Windows.Forms.Label();
                this.labelAdSoyadText = new System.Windows.Forms.Label();
                this.groupBoxHastaBilgileri = new System.Windows.Forms.GroupBox();
                this.groupBoxRandevuPaneli = new System.Windows.Forms.GroupBox();
                this.comboBoxBrans = new System.Windows.Forms.ComboBox();
                this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
                this.richTextBoxSikayet = new System.Windows.Forms.RichTextBox();
                this.buttonRandevu = new System.Windows.Forms.Button();
                this.linkLabelBilgileriGuncelle = new System.Windows.Forms.LinkLabel();
                this.labelBrans = new System.Windows.Forms.Label();
                this.labelDoktor = new System.Windows.Forms.Label();
                this.labelSikayet = new System.Windows.Forms.Label();
                this.groupBoxGecmisRandevular = new System.Windows.Forms.GroupBox();
                this.groupBoxAcikRandevular = new System.Windows.Forms.GroupBox();
                this.groupBoxHastaBilgileri.SuspendLayout();
                this.groupBoxRandevuPaneli.SuspendLayout();

                // 
                // labelTcNo
                // 
                this.labelTcNo.AutoSize = true;
                this.labelTcNo.Location = new System.Drawing.Point(6, 30);
                this.labelTcNo.Name = "labelTcNo";
                this.labelTcNo.Size = new System.Drawing.Size(45, 16);
                this.labelTcNo.TabIndex = 0;
                this.labelTcNo.Text = "Tc No:";
                // 
                // labelAdSoyad
                // 
                this.labelAdSoyad.AutoSize = true;
                this.labelAdSoyad.Location = new System.Drawing.Point(6, 60);
                this.labelAdSoyad.Name = "labelAdSoyad";
                this.labelAdSoyad.Size = new System.Drawing.Size(68, 16);
                this.labelAdSoyad.TabIndex = 1;
                this.labelAdSoyad.Text = "Ad Soyad:";
                // 
                // labelTcNoText
                // 
                this.labelTcNoText.AutoSize = true;
                this.labelTcNoText.Location = new System.Drawing.Point(80, 30);
                this.labelTcNoText.Name = "labelTcNoText";
                this.labelTcNoText.Size = new System.Drawing.Size(16, 16);
                this.labelTcNoText.TabIndex = 2;
                this.labelTcNoText.Text = "--";
                // 
                // labelAdSoyadText
                // 
                this.labelAdSoyadText.AutoSize = true;
                this.labelAdSoyadText.Location = new System.Drawing.Point(80, 60);
                this.labelAdSoyadText.Name = "labelAdSoyadText";
                this.labelAdSoyadText.Size = new System.Drawing.Size(16, 16);
                this.labelAdSoyadText.TabIndex = 3;
                this.labelAdSoyadText.Text = "--";
                // 
                // groupBoxHastaBilgileri
                // 
                this.groupBoxHastaBilgileri.Controls.Add(this.labelTcNo);
                this.groupBoxHastaBilgileri.Controls.Add(this.labelAdSoyadText);
                this.groupBoxHastaBilgileri.Controls.Add(this.labelAdSoyad);
                this.groupBoxHastaBilgileri.Controls.Add(this.labelTcNoText);
                this.groupBoxHastaBilgileri.Location = new System.Drawing.Point(12, 12);
                this.groupBoxHastaBilgileri.Name = "groupBoxHastaBilgileri";
                this.groupBoxHastaBilgileri.Size = new System.Drawing.Size(200, 100);
                this.groupBoxHastaBilgileri.TabIndex = 0;
                this.groupBoxHastaBilgileri.TabStop = false;
                this.groupBoxHastaBilgileri.Text = "Hasta Bilgileri";
                // 
                // groupBoxRandevuPaneli
                // 
                this.groupBoxRandevuPaneli.Controls.Add(this.labelBrans);
                this.groupBoxRandevuPaneli.Controls.Add(this.labelDoktor);
                this.groupBoxRandevuPaneli.Controls.Add(this.labelSikayet);
                this.groupBoxRandevuPaneli.Controls.Add(this.comboBoxBrans);
                this.groupBoxRandevuPaneli.Controls.Add(this.comboBoxDoktor);
                this.groupBoxRandevuPaneli.Controls.Add(this.richTextBoxSikayet);
                this.groupBoxRandevuPaneli.Controls.Add(this.buttonRandevu);
                this.groupBoxRandevuPaneli.Controls.Add(this.linkLabelBilgileriGuncelle);
                this.groupBoxRandevuPaneli.Location = new System.Drawing.Point(12, 118);
                this.groupBoxRandevuPaneli.Name = "groupBoxRandevuPaneli";
                this.groupBoxRandevuPaneli.Size = new System.Drawing.Size(200, 220);
                this.groupBoxRandevuPaneli.TabIndex = 1;
                this.groupBoxRandevuPaneli.TabStop = false;
                this.groupBoxRandevuPaneli.Text = "Randevu Paneli";
                // 
                // labelBrans
                // 
                this.labelBrans.AutoSize = true;
                this.labelBrans.Location = new System.Drawing.Point(6, 30);
                this.labelBrans.Name = "labelBrans";
                this.labelBrans.Size = new System.Drawing.Size(43, 16);
                this.labelBrans.TabIndex = 4;
                this.labelBrans.Text = "Branş:";
                // 
                // labelDoktor
                // 
                this.labelDoktor.AutoSize = true;
                this.labelDoktor.Location = new System.Drawing.Point(6, 60);
                this.labelDoktor.Name = "labelDoktor";
                this.labelDoktor.Size = new System.Drawing.Size(50, 16);
                this.labelDoktor.TabIndex = 5;
                this.labelDoktor.Text = "Doktor:";
                // 
                // labelSikayet
                // 
                this.labelSikayet.AutoSize = true;
                this.labelSikayet.Location = new System.Drawing.Point(6, 90);
                this.labelSikayet.Name = "labelSikayet";
                this.labelSikayet.Size = new System.Drawing.Size(55, 16);
                this.labelSikayet.TabIndex = 6;
                this.labelSikayet.Text = "Şikayet:";
                // 
                // comboBoxBrans
                // 
                this.comboBoxBrans.FormattingEnabled = true;
                this.comboBoxBrans.Location = new System.Drawing.Point(70, 27);
                this.comboBoxBrans.Name = "comboBoxBrans";
                this.comboBoxBrans.Size = new System.Drawing.Size(121, 24);
                this.comboBoxBrans.TabIndex = 0;
                // 
                // comboBoxDoktor
                // 
                this.comboBoxDoktor.FormattingEnabled = true;
                this.comboBoxDoktor.Location = new System.Drawing.Point(70, 57);
                this.comboBoxDoktor.Name = "comboBoxDoktor";
                this.comboBoxDoktor.Size = new System.Drawing.Size(121, 24);
                this.comboBoxDoktor.TabIndex = 1;
                // 
                // richTextBoxSikayet
                // 
                this.richTextBoxSikayet.Location = new System.Drawing.Point(70, 87);
                this.richTextBoxSikayet.Name = "richTextBoxSikayet";
                this.richTextBoxSikayet.Size = new System.Drawing.Size(121, 80);
                this.richTextBoxSikayet.TabIndex = 2;
                this.richTextBoxSikayet.Text = "";
                // 
                // buttonRandevu
                // 
                this.buttonRandevu.Location = new System.Drawing.Point(70, 173);
                this.buttonRandevu.Name = "buttonRandevu";
                this.buttonRandevu.Size = new System.Drawing.Size(121, 23);
                this.buttonRandevu.TabIndex = 3;
                this.buttonRandevu.Text = "Randevu";
                this.buttonRandevu.UseVisualStyleBackColor = true;
                // 
                // linkLabelBilgileriGuncelle
                // 
                this.linkLabelBilgileriGuncelle.AutoSize = true;
                this.linkLabelBilgileriGuncelle.Location = new System.Drawing.Point(67, 199);
                this.linkLabelBilgileriGuncelle.Name = "linkLabelBilgileriGuncelle";
                this.linkLabelBilgileriGuncelle.Size = new System.Drawing.Size(102, 16);
                this.linkLabelBilgileriGuncelle.TabIndex = 4;
                this.linkLabelBilgileriGuncelle.TabStop = true;
                this.linkLabelBilgileriGuncelle.Text = "Bilgileri Güncelle";
                // 
                // groupBoxGecmisRandevular
                // 
                this.groupBoxGecmisRandevular.Location = new System.Drawing.Point(218, 12);
                this.groupBoxGecmisRandevular.Name = "groupBoxGecmisRandevular";
                this.groupBoxGecmisRandevular.Size = new System.Drawing.Size(200, 160);
                this.groupBoxGecmisRandevular.TabIndex = 2;
                this.groupBoxGecmisRandevular.TabStop = false;
                this.groupBoxGecmisRandevular.Text = "Geçmiş Randevular";
                // 
                // groupBoxAcikRandevular
                // 
                this.groupBoxAcikRandevular.Location = new System.Drawing.Point(218, 178);
                this.groupBoxAcikRandevular.Name = "groupBoxAcikRandevular";
                this.groupBoxAcikRandevular.Size = new System.Drawing.Size(200, 160);
                this.groupBoxAcikRandevular.TabIndex = 3;
                this.groupBoxAcikRandevular.TabStop = false;
                this.groupBoxAcikRandevular.Text = "Açık Randevular";
                // 
                // Hasta_Ekrani
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(434, 348);
                
                this.groupBoxHastaBilgileri.ResumeLayout(false);
                this.groupBoxHastaBilgileri.PerformLayout();
                this.groupBoxRandevuPaneli.ResumeLayout(false);
                this.groupBoxRandevuPaneli.PerformLayout();
            }

            #endregion

            private System.Windows.Forms.Label labelTcNo;
            private System.Windows.Forms.Label labelAdSoyad;
            private System.Windows.Forms.Label labelTcNoText;
            private System.Windows.Forms.Label labelAdSoyadText;
            private System.Windows.Forms.GroupBox groupBoxHastaBilgileri;
            private System.Windows.Forms.GroupBox groupBoxRandevuPaneli;
            private System.Windows.Forms.ComboBox comboBoxBrans;
            private System.Windows.Forms.ComboBox comboBoxDoktor;
            private System.Windows.Forms.RichTextBox richTextBoxSikayet;
            private System.Windows.Forms.Button buttonRandevu;
            private System.Windows.Forms.LinkLabel linkLabelBilgileriGuncelle;
            private System.Windows.Forms.Label labelBrans;
            private System.Windows.Forms.Label labelDoktor;
            private System.Windows.Forms.Label labelSikayet;
            private System.Windows.Forms.GroupBox groupBoxGecmisRandevular;
            private System.Windows.Forms.GroupBox groupBoxAcikRandevular;

            public SizeF AutoScaleDimensions { get; private set; }
            public AutoScaleMode AutoScaleMode { get; private set; }
            public Size ClientSize { get; private set; }
            public object Controls { get; private set; }
        }
    }

}

