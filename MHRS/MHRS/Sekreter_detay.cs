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
    public partial class Sekreter_detay : Form
    {
        public Sekreter_detay()
        {
            InitializeComponent();
        }
    }
        namespace HastaneProjesi
    {
        partial class Sekreter_detay
        {
            private System.ComponentModel.IContainer components = null;

          

            #region Windows Form Designer generated code

            private void InitializeComponent()
            {
                this.groupBoxHastaBilgileri = new System.Windows.Forms.GroupBox();
                this.labelTcNo = new System.Windows.Forms.Label();
                this.labelAdSoyad = new System.Windows.Forms.Label();
                this.labelAdSoyadText = new System.Windows.Forms.Label();

                this.groupBoxDuyuruOlustur = new System.Windows.Forms.GroupBox();
                this.listBoxDuyuru = new System.Windows.Forms.ListBox();
                this.buttonOlustur = new System.Windows.Forms.Button();

                this.groupBoxRandevuPaneli = new System.Windows.Forms.GroupBox();
                this.textBoxId = new System.Windows.Forms.TextBox();
                this.textBoxTarih = new System.Windows.Forms.TextBox();
                this.textBoxSaat = new System.Windows.Forms.TextBox();
                this.textBoxBrans = new System.Windows.Forms.TextBox();
                this.textBoxDoktor = new System.Windows.Forms.TextBox();
                this.buttonKaydet = new System.Windows.Forms.Button();
                this.buttonGuncelle = new System.Windows.Forms.Button();

                this.groupBoxBranslar = new System.Windows.Forms.GroupBox();
                this.groupBoxDoktorlar = new System.Windows.Forms.GroupBox();

                this.panelAlt = new System.Windows.Forms.Panel();
                this.buttonDoktorPaneli = new System.Windows.Forms.Button();
                this.buttonBransPaneli = new System.Windows.Forms.Button();
                this.buttonRandevuListesi = new System.Windows.Forms.Button();

                // 
                // groupBoxHastaBilgileri
                // 
                this.groupBoxHastaBilgileri.Controls.Add(this.labelTcNo);
                this.groupBoxHastaBilgileri.Controls.Add(this.labelAdSoyad);
                this.groupBoxHastaBilgileri.Controls.Add(this.labelAdSoyadText);
                this.groupBoxHastaBilgileri.Location = new System.Drawing.Point(12, 12);
                this.groupBoxHastaBilgileri.Name = "groupBoxHastaBilgileri";
                this.groupBoxHastaBilgileri.Size = new System.Drawing.Size(200, 100);
                this.groupBoxHastaBilgileri.TabIndex = 0;
                this.groupBoxHastaBilgileri.TabStop = false;
                this.groupBoxHastaBilgileri.Text = "Hasta Bilgileri";

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
                // textBoxTcNo
               

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
                // labelAdSoyadText
                // 
                this.labelAdSoyadText.AutoSize = true;
                this.labelAdSoyadText.Location = new System.Drawing.Point(80, 60);
                this.labelAdSoyadText.Name = "labelAdSoyadText";
                this.labelAdSoyadText.Size = new System.Drawing.Size(16, 16);
                this.labelAdSoyadText.TabIndex = 3;
                this.labelAdSoyadText.Text = "--";

                // 
                // groupBoxDuyuruOlustur
                // 
                this.groupBoxDuyuruOlustur.Controls.Add(this.listBoxDuyuru);
                this.groupBoxDuyuruOlustur.Controls.Add(this.buttonOlustur);
                this.groupBoxDuyuruOlustur.Location = new System.Drawing.Point(12, 118);
                this.groupBoxDuyuruOlustur.Name = "groupBoxDuyuruOlustur";
                this.groupBoxDuyuruOlustur.Size = new System.Drawing.Size(200, 150);
                this.groupBoxDuyuruOlustur.TabIndex = 4;
                this.groupBoxDuyuruOlustur.TabStop = false;
                this.groupBoxDuyuruOlustur.Text = "Duyuru Oluştur";

                // 
                // listBoxDuyuru
                // 
                this.listBoxDuyuru.FormattingEnabled = true;
                this.listBoxDuyuru.ItemHeight = 16;
                this.listBoxDuyuru.Location = new System.Drawing.Point(9, 21);
                this.listBoxDuyuru.Name = "listBoxDuyuru";
                this.listBoxDuyuru.Size = new System.Drawing.Size(185, 84);
                this.listBoxDuyuru.TabIndex = 0;

                // 
                // buttonOlustur
                // 
                this.buttonOlustur.Location = new System.Drawing.Point(9, 111);
                this.buttonOlustur.Name = "buttonOlustur";
                this.buttonOlustur.Size = new System.Drawing.Size(185, 33);
                this.buttonOlustur.TabIndex = 1;
                this.buttonOlustur.Text = "Oluştur";
                this.buttonOlustur.UseVisualStyleBackColor = true;

                // 
                // groupBoxRandevuPaneli
                // 
                this.groupBoxRandevuPaneli.Controls.Add(this.textBoxId);
                this.groupBoxRandevuPaneli.Controls.Add(this.textBoxTarih);
                this.groupBoxRandevuPaneli.Controls.Add(this.textBoxSaat);
                this.groupBoxRandevuPaneli.Controls.Add(this.textBoxBrans);
                this.groupBoxRandevuPaneli.Controls.Add(this.textBoxDoktor);
                this.groupBoxRandevuPaneli.Controls.Add(this.buttonKaydet);
                this.groupBoxRandevuPaneli.Controls.Add(this.buttonGuncelle);
                this.groupBoxRandevuPaneli.Location = new System.Drawing.Point(218, 12);
                this.groupBoxRandevuPaneli.Name = "groupBoxRandevuPaneli";
                this.groupBoxRandevuPaneli.Size = new System.Drawing.Size(200, 250);
                this.groupBoxRandevuPaneli.TabIndex = 2;
                this.groupBoxRandevuPaneli.TabStop = false;
                this.groupBoxRandevuPaneli.Text = "Randevu Paneli";

                // 
                // textBoxId
                // 
                this.textBoxId.Location = new System.Drawing.Point(80, 27);
                this.textBoxId.Name = "textBoxId";
                this.textBoxId.Size = new System.Drawing.Size(100, 22);
                this.textBoxId.TabIndex = 2;
                this.textBoxId.Text = "Id";

                // 
                // textBoxTarih
                // 
                this.textBoxTarih.Location = new System.Drawing.Point(80, 55);
                this.textBoxTarih.Name = "textBoxTarih";
                this.textBoxTarih.Size = new System.Drawing.Size(100, 22);
                this.textBoxTarih.TabIndex = 3;
                this.textBoxTarih.Text = "Tarih";

                // 
                // textBoxSaat
                // 
                this.textBoxSaat.Location = new System.Drawing.Point(80, 83);
                this.textBoxSaat.Name = "textBoxSaat";
                this.textBoxSaat.Size = new System.Drawing.Size(100, 22);
                this.textBoxSaat.TabIndex = 4;
                this.textBoxSaat.Text = "Saat";

                // 
                // textBoxBrans
                // 
                this.textBoxBrans.Location = new System.Drawing.Point(80, 111);
                this.textBoxBrans.Name = "textBoxBrans";
                this.textBoxBrans.Size = new System.Drawing.Size(100, 22);
                this.textBoxBrans.TabIndex = 5;
                this.textBoxBrans.Text = "Branş";

                // 
                // textBoxDoktor
                // 
                this.textBoxDoktor.Location = new System.Drawing.Point(80, 139);
                this.textBoxDoktor.Name = "textBoxDoktor";
                this.textBoxDoktor.Size = new System.Drawing.Size(100, 22);
                this.textBoxDoktor.TabIndex = 6;
                this.textBoxDoktor.Text = "Doktor";

              

                // 
                // buttonKaydet
                // 
                this.buttonKaydet.Location = new System.Drawing.Point(9, 195);
                this.buttonKaydet.Name = "buttonKaydet";
                this.buttonKaydet.Size = new System.Drawing.Size(80, 45);
                this.buttonKaydet.TabIndex = 8;
                this.buttonKaydet.Text = "Kaydet";
                this.buttonKaydet.UseVisualStyleBackColor = true;

                // 
                // buttonGuncelle
                // 
                this.buttonGuncelle.Location = new System.Drawing.Point(100, 195);
                this.buttonGuncelle.Name = "buttonGuncelle";
                this.buttonGuncelle.Size = new System.Drawing.Size(80, 45);
                this.buttonGuncelle.TabIndex = 9;
                this.buttonGuncelle.Text = "Güncelle";
                this.buttonGuncelle.UseVisualStyleBackColor = true;

                // 
                // groupBoxBranslar
                // 
                this.groupBoxBranslar.Location = new System.Drawing.Point(424, 12);
                this.groupBoxBranslar.Name = "groupBoxBranslar";
                this.groupBoxBranslar.Size = new System.Drawing.Size(200, 100);
                this.groupBoxBranslar.TabIndex = 3;
                this.groupBoxBranslar.TabStop = false;
                this.groupBoxBranslar.Text = "Branşlar";

                // 
                // groupBoxDoktorlar
                // 
                this.groupBoxDoktorlar.Location = new System.Drawing.Point(424, 118);
                this.groupBoxDoktorlar.Name = "groupBoxDoktorlar";
                this.groupBoxDoktorlar.Size = new System.Drawing.Size(200, 100);
                this.groupBoxDoktorlar.TabIndex = 4;
                this.groupBoxDoktorlar.TabStop = false;
                this.groupBoxDoktorlar.Text = "Doktorlar";

                // 
                // panelAlt
                // 
                this.panelAlt.Controls.Add(this.buttonDoktorPaneli);
                this.panelAlt.Controls.Add(this.buttonBransPaneli);
                this.panelAlt.Controls.Add(this.buttonRandevuListesi);
                this.panelAlt.Location = new System.Drawing.Point(12, 274);
                this.panelAlt.Name = "panelAlt";
                this.panelAlt.Size = new System.Drawing.Size(612, 64);
                this.panelAlt.TabIndex = 5;

                // 
                // buttonDoktorPaneli
                // 
                this.buttonDoktorPaneli.Location = new System.Drawing.Point(9, 15);
                this.buttonDoktorPaneli.Name = "buttonDoktorPaneli";
                this.buttonDoktorPaneli.Size = new System.Drawing.Size(200, 45);
                this.buttonDoktorPaneli.TabIndex = 0;
                this.buttonDoktorPaneli.Text = "Doktor Paneli";
                this.buttonDoktorPaneli.UseVisualStyleBackColor = true;

                // 
                // buttonBransPaneli
                // 
                this.buttonBransPaneli.Location = new System.Drawing.Point(218, 15);
                this.buttonBransPaneli.Name = "buttonBransPaneli";
                this.buttonBransPaneli.Size = new System.Drawing.Size(200, 45);
                this.buttonBransPaneli.TabIndex = 1;
                this.buttonBransPaneli.Text = "Branş Paneli";
                this.buttonBransPaneli.UseVisualStyleBackColor = true;

                // 
                // buttonRandevuListesi
                // 
                this.buttonRandevuListesi.Location = new System.Drawing.Point(424, 15);
                this.buttonRandevuListesi.Name = "buttonRandevuListesi";
                this.buttonRandevuListesi.Size = new System.Drawing.Size(200, 45);
                this.buttonRandevuListesi.TabIndex = 2;
                this.buttonRandevuListesi.Text = "Randevu Listesi";
                this.buttonRandevuListesi.UseVisualStyleBackColor = true;

                // 
                // Sekreter_detay
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(636, 350);                
                this.Name = "Sekreter_detay";
                this.Text = "Sekreter Detay";
                this.groupBoxHastaBilgileri.ResumeLayout(false);
                this.groupBoxHastaBilgileri.PerformLayout();
                this.groupBoxDuyuruOlustur.ResumeLayout(false);
                this.groupBoxRandevuPaneli.ResumeLayout(false);
                this.groupBoxRandevuPaneli.PerformLayout();
                this.panelAlt.ResumeLayout(false);
                this.ResumeLayout(false);
            }

            private void ResumeLayout(bool v)
            {
                throw new NotImplementedException();
            }

            #endregion

            private System.Windows.Forms.GroupBox groupBoxHastaBilgileri;
            private System.Windows.Forms.Label labelTcNo;
            private System.Windows.Forms.Label labelAdSoyad;
            private System.Windows.Forms.TextBox textBoxTcNo;
            private System.Windows.Forms.Label labelAdSoyadText;

            private System.Windows.Forms.GroupBox groupBoxDuyuruOlustur;
            private System.Windows.Forms.ListBox listBoxDuyuru;
            private System.Windows.Forms.Button buttonOlustur;

            private System.Windows.Forms.GroupBox groupBoxRandevuPaneli;
            private System.Windows.Forms.TextBox textBoxId;
            private System.Windows.Forms.TextBox textBoxTarih;
            private System.Windows.Forms.TextBox textBoxSaat;
            private System.Windows.Forms.TextBox textBoxBrans;
            private System.Windows.Forms.TextBox textBoxDoktor;
            private System.Windows.Forms.Button buttonKaydet;
            private System.Windows.Forms.Button buttonGuncelle;

            private System.Windows.Forms.GroupBox groupBoxBranslar;
            private System.Windows.Forms.GroupBox groupBoxDoktorlar;

            private System.Windows.Forms.Panel panelAlt;
            private System.Windows.Forms.Button buttonDoktorPaneli;
            private System.Windows.Forms.Button buttonBransPaneli;
            private System.Windows.Forms.Button buttonRandevuListesi;

            public SizeF AutoScaleDimensions { get; private set; }
            public AutoScaleMode AutoScaleMode { get; private set; }
            public Size ClientSize { get; private set; }
            public string Name { get; private set; }
            public string Text { get; private set; }
            public object Controls { get; private set; }
        }
    }
}

