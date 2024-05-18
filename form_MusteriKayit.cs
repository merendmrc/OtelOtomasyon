using OtelOtomasyon.classes;
using OtelOtomasyon.sýnýflar;

namespace OtelOtomasyon

{
    public partial class form_MusteriKayit : Form
    {
        private bool ad_giris = false;
        private bool soyad_giris = false;
        private bool mail_giris = false;
        private bool tel_giris = false;
        private bool sifre_giris = false;
        private bool sifret_giris = false;
        private bool yas_giris = false;
        private bool tckn_giris = false;
        public form_MusteriKayit()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (errSifreT.HasErrors || errAd.HasErrors || errSoyad.HasErrors || errMail.HasErrors || errSifre.HasErrors || errYas.HasErrors || errTel.HasErrors || errTckn.HasErrors)
            {
                MessageBox.Show("Lutfen bilgilerinizi kontrol ediniz...");
            }
            else if (Veritabani.Kayit_varsa("Musteriler", "musteri_tckn", txtTckn.Text.ToString()))
            {
                MessageBox.Show("Kimlik numaraniz ile sistemde mevcut hesabiniz bulunmaktadir.");
            }
            else
            {
                Musteri yeni_musteri = new Musteri(txtTckn.Text,txtAd.Text,txtSoyad.Text,txtYas.Text,txtMail.Text,txtTelefon.Text,txtSifre.Text);
                string sorgu = $"('{yeni_musteri.TCKN}', '{yeni_musteri.Ad}', '{yeni_musteri.Soyad}', {yeni_musteri.Yas}, '{yeni_musteri.Mail}', '{yeni_musteri.Tel}', '{yeni_musteri.Sifre}')";
                Veritabani.Ekle("Musteriler", sorgu);

            }

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            mail_giris = true;
            var (mailUygun, mailHata) = Gecerlilik.Mail_Kontrol(txtMail.Text);

            if (mailUygun)
            {
                txtMail.ForeColor = Color.Green;
                errMail.Clear();
            }
            else
            {
                txtMail.ForeColor = Color.Red;
                errMail.SetError(txtMail, mailHata);
            }

            if (ad_giris && soyad_giris && mail_giris && tel_giris && sifret_giris && sifre_giris && yas_giris && tckn_giris)
            {
                btn_Kayit.Enabled = true;
            }

        }


        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            ad_giris = true;
            var (ad_uygun, ad_hata) = Gecerlilik.Ad_kontrol(txtAd.Text);

            if (ad_uygun)
            {
                txtAd.ForeColor = Color.Green;
                errAd.Clear();
            }
            else
            {
                txtAd.ForeColor = Color.Red;
                errAd.SetError(txtAd, ad_hata);
            }
            if (ad_giris && soyad_giris && mail_giris && tel_giris && sifret_giris && sifre_giris && yas_giris && tckn_giris)
            {
                btn_Kayit.Enabled = true;
            }
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            soyad_giris = true;
            var (soyad_uygun, soyad_hata) = Gecerlilik.Ad_kontrol(txtSoyad.Text);

            if (soyad_uygun)
            {
                txtSoyad.ForeColor = Color.Green;
                errSoyad.Clear();
            }
            else
            {
                txtSoyad.ForeColor = Color.Red;
                errSoyad.SetError(txtSoyad, soyad_hata);
            }

            if (ad_giris && soyad_giris && mail_giris && tel_giris && sifret_giris && sifre_giris && yas_giris && tckn_giris)
            {
                btn_Kayit.Enabled = true;
            }
        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {
            yas_giris = true;

            var (Yas_uygun, Yas_hata) = Gecerlilik.Yas_Kontrol(txtYas.Text);

            if (Yas_uygun)
            {
                txtYas.ForeColor = Color.Green;
                errYas.Clear();
            }
            else
            {
                txtYas.ForeColor = Color.Red;
                errYas.SetError(txtYas, Yas_hata);
            }

            if (ad_giris && soyad_giris && mail_giris && tel_giris && sifret_giris && sifre_giris && yas_giris && tckn_giris)
            {
                btn_Kayit.Enabled = true;
            }
        }

        private void txtTckn_TextChanged(object sender, EventArgs e)
        {
            tckn_giris = true;
            var (Tckn_uygun, Tckn_hata) = Gecerlilik.Tckn_kontrol(txtTckn.Text);

            if (Tckn_uygun)
            {
                txtTckn.ForeColor = Color.Green;
                errTckn.Clear();
            }
            else
            {
                txtTckn.ForeColor = Color.Red;
                errTckn.SetError(txtTckn, Tckn_hata);
            }

            if (ad_giris && soyad_giris && mail_giris && tel_giris && sifret_giris && sifre_giris && tckn_giris && tckn_giris)
            {
                btn_Kayit.Enabled = true;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            sifre_giris = true;
            var (Sifre_uygun, Sifre_hata) = Gecerlilik.Sifre_kontrol(txtSifre.Text);

            if (Sifre_uygun)
            {
                txtSifre.ForeColor = Color.Green;
                errSifre.Clear();
            }
            else
            {
                txtSifre.ForeColor = Color.Red;
                errSifre.SetError(txtSifre, Sifre_hata);
            }
            if (ad_giris && soyad_giris && mail_giris && tel_giris && sifret_giris && sifre_giris && yas_giris && tckn_giris)
            {
                btn_Kayit.Enabled = true;
            }
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            tel_giris = true;
            var (TelNo_uygun, TelNo_hata) = Gecerlilik.TelNo_kontrol(txtTelefon.Text);

            if (TelNo_uygun)
            {
                txtTelefon.ForeColor = Color.Green;
                errTel.Clear();
            }
            else
            {
                txtTelefon.ForeColor = Color.Red;
                errTel.SetError(txtTelefon, TelNo_hata);
            }

            if (ad_giris && soyad_giris && mail_giris && tel_giris && sifret_giris && sifre_giris && yas_giris && tckn_giris)
            {
                btn_Kayit.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sifret_giris = true;
            if (txtSifre.Text != txtSifreT.Text)
            {
                errSifreT.SetError(txtSifreT, "Sifreler uyusmuyor.");
                txtSifreT.ForeColor = Color.Red;
            }
            else
            {
                errSifreT.Clear();
                txtSifreT.ForeColor = Color.Green;
            }
            if (ad_giris && soyad_giris && mail_giris && tel_giris && sifret_giris && sifre_giris && yas_giris && tckn_giris)
            {
                btn_Kayit.Enabled = true;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form giris = new form_MusteriGiris();
            giris.Show();

            this.Close();
        }
    }
}
