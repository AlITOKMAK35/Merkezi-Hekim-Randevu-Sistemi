using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRS
{
    public partial class Hasta_Giris : Form
    {
        public Hasta_Giris()
        {
            InitializeComponent();
        }
        public string tcno;

        
        private void Hasta_Giris_Load(object sender, EventArgs e)
        {

        }
        sql_baglan cbkbaglan = new sql_baglan();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Hasta_kayit hstkyt = new Hasta_kayit();
            hstkyt.Show();
        }

        private void giris_yap_Click(object sender, EventArgs e)
        {
            giris_yap_Click(sender, e, tcno);
        }

        private void giris_yap_Click(object sender, EventArgs e, string tcno)
        {
            hasta_tc_no.Text = tcno;
            SqlCommand veriveri = new SqlCommand("Select * Form Mhrs_Table Where hastatc=@hstc and hastasifre=hssfr", cbkbaglan.baglan());
            veriveri.Parameters.AddWithValue("@hstc", hasta_tc_no.Text);
            veriveri.Parameters.AddWithValue("@hssfr", hasta_sifre.Text);
            SqlDataReader brs = veriveri.ExecuteReader();
            if(brs.Read())
            {
                Hasta_Ekranı br = new Hasta_Ekranı();
                br.tcno = hasta_tc_no.Text;
                br.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            cbkbaglan.baglan().Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
