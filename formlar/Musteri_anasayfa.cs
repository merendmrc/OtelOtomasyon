using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyon.formlar;
using OtelOtomasyon.sınıflar;

namespace OtelOtomasyon
{
    public partial class Musteri_anasayfa : Form
    {
        public Musteri_anasayfa()
        {
            InitializeComponent();
        }

        private void Musteri_anasayfa_Load(object sender, EventArgs e)
        {
            if (form_MusteriGiris.oturum != null)
            {
                label1.Text = $"Hosgeldiniz {form_MusteriGiris.oturum.Ad} {form_MusteriGiris.oturum.Soyad}";
            }
            else
            {
                label1.Text = "Lutfen giris yapiniz...";
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            Form form = new form_RezervasyonYap();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new form_MusteriGiris();
            this.Close();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (form_MusteriGiris.oturum != null)
            {
                DialogResult sonuc = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Oturum Kapatma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    form_MusteriGiris.oturum = null;
                    label1.Text = "Lutfen oturum aciniz..";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new form_Rezervasyonlarim();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
        }
    }
}
