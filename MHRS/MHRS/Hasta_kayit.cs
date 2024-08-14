using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRS
{
    public partial class Hasta_kayit : Form
    {
        public Hasta_kayit()
        {
            InitializeComponent();
        }
        sql_baglan cbkbaglan = new sql_baglan(); 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hasta_kayit_Load(object sender, EventArgs e)
        {

            SqlCommand veriveri = new SqlCommand("insert into Mhrs_Table (hastaad,hastasoyad,hastatc,hastatelefon,hastasifre,hastacinsiyet) values (@hsad, @hssyd, @hstc, @hstlf, @hssfr, @hscnsyt)", cbkbaglan.baglan());
            veriveri.Parameters.AddWithValue("@hsad", hasta_ad_kayit.Text);
            veriveri.Parameters.AddWithValue("@hssyd", hasta_soyad_kayit.Text);
            veriveri.Parameters.AddWithValue("@hstc", hasta_tc_no_kayit.Text);
            veriveri.Parameters.AddWithValue("@hstlf", hasta_telefon_kayit.Text);
            veriveri.Parameters.AddWithValue("@hssfr", hasta_sifre_kayit.Text);
            veriveri.Parameters.AddWithValue("@hscnsyt", hasta_cinsiyet_kayit.Text);
            veriveri.ExecuteNonQuery();
            cbkbaglan.baglan().Close();
            MessageBox.Show("kayıt tamamlandı lütfen şifrenizi kaydediniz" +hasta_sifre_kayit.Text); 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kayıt_ol_Click(object sender, EventArgs e)
        {
            SqlCommand veriveri = new SqlCommand("insert into Mhrs_Table (hastaad,hastasoyad,hastatc,hastatelefon,hastasifre,hastacinsiyet) values (@hsad, @hssyd, @hstc, @hstlf, @hssfr, @hscnsyt)", cbkbaglan.baglan());
            veriveri.Parameters.AddWithValue("@hsad", hasta_ad_kayit.Text);
            veriveri.Parameters.AddWithValue("@hssyd", hasta_soyad_kayit.Text);
            veriveri.Parameters.AddWithValue("@hstc", hasta_tc_no_kayit.Text);
            veriveri.Parameters.AddWithValue("@hstlf", hasta_telefon_kayit.Text);
            veriveri.Parameters.AddWithValue("@hssfr", hasta_sifre_kayit.Text);
            veriveri.Parameters.AddWithValue("@hscnsyt", hasta_cinsiyet_kayit.Text);
            veriveri.ExecuteNonQuery();
            cbkbaglan.baglan().Close();
            MessageBox.Show("kayıt tamamlandı lütfen şifrenizi kaydediniz" + hasta_sifre_kayit.Text);
        }

        
    }
}
