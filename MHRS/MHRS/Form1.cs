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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      

        private void button3_Click(object sender, EventArgs e)
        {
            Hasta_Giris hstgrs = new Hasta_Giris();
            hstgrs.Show();
            this.Hide();
        }

        private void giris_doktor_Click(object sender, EventArgs e)
        {
            Hasta_Ekranı hst = new Hasta_Ekranı();
            hst.Show();
            this.Hide();    
        }

        private void giris_sekreter_Click(object sender, EventArgs e)
        {
            Sekreter_detay skr = new Sekreter_detay();
            skr.Show();
            this.Hide();
        }
    }
}
