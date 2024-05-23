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
            //oturum'un acik olmasina bagli olarak butonlarin enable ozelliklerini ayarlar
            if (form_MusteriGiris.oturum != null)
            {
                label1.Text = $"Hosgeldiniz {form_MusteriGiris.oturum.Ad} {form_MusteriGiris.oturum.Soyad}";
                btnCikis.Enabled = true;
                btnGiris.Enabled = false;
                btnRezervasyonlarim.Enabled = true;
                btnRezervasyonYap.Enabled = true;
                btnSiparisVer.Enabled = true;
                
            }
            else
            {
                label1.Text = "Lutfen giris yapiniz...";
                btnCikis.Enabled = false;
                btnGiris.Enabled = true;
                btnRezervasyonlarim.Enabled = false;
                btnRezervasyonYap.Enabled = false;
                btnSiparisVer.Enabled = false;
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
            this.Hide();
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
                    this.Close();
                    Form form = new Musteri_anasayfa();
                    form.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(form_MusteriGiris.oturum != null)
            {
                Form form = new form_Rezervasyonlarim();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lutfen giris yapiniz...");
                Form form = new form_MusteriGiris();
                this.Close();
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = Veritabani.Cek("K.oda_no,K.rezervasyon_id", "Rezervasyonlar R", kosul: $"R.musteri_tckn = '{form_MusteriGiris.oturum.TCKN}'AND K.baslangic_tarih <= GETDATE() AND K.bitis_tarih >= GETDATE();", innerJoin: "Musteriler M ON R.musteri_tckn = M.musteri_tckn inner JOIN Rezervasyon K ON R.rezervasyon_id = K.rezervasyon_id");
            
            if(x.Count == 0)
            {
                MessageBox.Show("Bugun aktif rezervasyonunuz bulunmamaktadir.\nSiparisler sadece ayni gun icin verilebilir");
            }
            else
            {
                Form form = new form_SiparisVer(x);
                form.ShowDialog();
            }
        }
    }
}
