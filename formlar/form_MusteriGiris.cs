using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyon.classes;
using SimpleHashing.Net;
using OtelOtomasyon.sınıflar;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace OtelOtomasyon
{

    public partial class form_MusteriGiris : Form
    {
        public static Musteri oturum;

        public form_MusteriGiris()
        {
            InitializeComponent();
        }

        private static bool Sifre_dogrulama(string sifre,string tckn)
        {
            SimpleHash dogrula = new SimpleHash();
            var x = Veritabani.Cek("Musteri_sifre", "Musteriler", $"Musteri_tckn = '{tckn}'");
            if (dogrula.Verify(sifre, x[0][0]))
            {
                return true;
            }
            return false;
        }

        private void form_MusteriGiris_Load(object sender, EventArgs e)
        {
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Form kayitform = new form_MusteriKayit();
            kayitform.Show();
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!Gecerlilik.Tckn_kontrol(txtTckn.Text).Item1)
            {
                MessageBox.Show("Kimlik numaranizi yanlis girdiniz.");
            }
            else if (!Veritabani.Kayit_varsa("Musteriler", "Musteri_tckn", txtTckn.Text))
            {
                MessageBox.Show("Kimlik numaranizla kayitli hesap bulunamadi.");
            }
            else if (!Gecerlilik.Sifre_kontrol(txtSifre.Text).Item1)
            {
                MessageBox.Show("Sifrenizi kontrol ediniz.");
            }
            else if (!Sifre_dogrulama(txtSifre.Text, txtTckn.Text))
            {
                MessageBox.Show("Sifrenizi yanlis girdiniz.") ;
            }
            else
            {
                var x = Veritabani.Cek("*", "Musteriler", $"Musteri_tckn = {txtTckn.Text}")[0];
                oturum = new Musteri(x[0], x[1], x[2], x[3], x[4], x[5], x[6]);
                MessageBox.Show("giris basarili");
                Form form = new Musteri_anasayfa();
                form.Show();
                this.Close();

            }

        }
    }
}
