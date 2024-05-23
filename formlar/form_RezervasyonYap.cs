using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyon.sınıflar;

namespace OtelOtomasyon
{
    public partial class form_RezervasyonYap : Form
    {
        public form_RezervasyonYap()
        {
            InitializeComponent();
        }


        private bool Gunler_bosmu(List<List<string>> veriler, DateTime baslangic, DateTime bitis)
        {
            bool bos_mu = true;

            for (int i = 0; i < veriler.Count(); i++)
            {
                DateTime db_baslangic = Convert.ToDateTime(veriler[i][0]);
                DateTime db_bitis = Convert.ToDateTime(veriler[i][1]);
                DateTime en_gec_baslangic = (baslangic < db_baslangic) ? db_baslangic : baslangic;
                DateTime diger_rez_bitis = (baslangic > db_baslangic) ? db_bitis : bitis;

                if (en_gec_baslangic < diger_rez_bitis)
                {

                    bos_mu = false;
                    break;
                }
                if (!bos_mu) break;

            }
            return bos_mu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && cmbOda_no.SelectedIndex != -1)
            {
                if (form_MusteriGiris.oturum != null)
                {
                    bool durum = Gunler_bosmu(Veritabani.Cek("baslangic_tarih,bitis_tarih", "Rezervasyon", kosul: $" oda_no = '{cmbOda_no.Text.Split(" ")[1]}'"), dateGiris.Value, dateBitis.Value);
                    if (durum)
                    {
                        var oda = Veritabani.Cek("oda_no,gunluk_ucret,oda_tip,oda_ozellikler", "Odalar", innerJoin: "Oda_tip on Odalar.odatip_id = Oda_tip.odatip_id", kosul: $"oda_no = {int.Parse(cmbOda_no.SelectedItem.ToString().Split(" ")[1])}")[0];
                        string bilgiler = $"Oda: {oda[0]}\nOda tipi: {oda[2]}\nOda ozellikler: {oda[3]}\nGiris tarihi: {dateGiris.Text}\nCikis tarihi: {dateBitis.Text}\nKonaklanacak gun sayisi: {(dateBitis.Value.Subtract(dateGiris.Value)).Days.ToString()}\nUcret: {(dateBitis.Value.Subtract(dateGiris.Value)).Days * int.Parse(oda[1])}";
                        string Soru = $"Rezervasyon Bilgileri:\n{bilgiler}\n\nOnaylıyor musunuz?";
                        string Baslik = "Rezervasyon Onayı";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult cevap;

                        cevap = MessageBox.Show(Soru, Baslik, buttons);

                        if (cevap == DialogResult.Yes)
                        {
                            Rezervasyon rezervasyon = new Rezervasyon(Convert.ToInt32(cmbOda_no.SelectedItem.ToString().Split(" ")[1]), dateGiris.Text, dateBitis.Text);
                            rezervasyon.Rezervasyon_olustur();
                            MessageBox.Show("Rezervasyonunuz basariyla gerceklesti. İyi gunler dileriz..");
                            this.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Oda dolu.");
                    }

                }
                else
                {
                    MessageBox.Show("Rezervasyon yapmak icin oturum acmaniz gerekmektedir...");
                    Form form = new form_MusteriGiris();
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Oda türü- oda numarasi seçimlerinizi kontrol ediniz..");
            }
        }

        private void form_RezervasyonYap_Load(object sender, EventArgs e)
        {
            dateGiris.MinDate = DateTime.Now;
            dateBitis.MinDate = dateGiris.Value.AddDays(1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOda_no.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dateGiris_ValueChanged_1(object sender, EventArgs e)
        {
            dateBitis.MinDate = dateGiris.Value.AddDays(1);
        }

        private void cmbOda_no_DropDown(object sender, EventArgs e)
        {
            Gunleri_yukle();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gunleri_yukle()
        {
            cmbOda_no.Items.Clear();
            int baslangic = 1;
            int bitis = 21;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    baslangic = 1;
                    bitis = 11;
                    break;
                case 1:

                    baslangic = 11;
                    bitis = 16;
                    break;
                case 2:
                    baslangic = 16;
                    bitis = 21;
                    break;
            }

            for (int i = baslangic; i < bitis; i++)
            {
                if (Gunler_bosmu(Veritabani.Cek("baslangic_tarih,bitis_tarih", "Rezervasyon", kosul: $" oda_no = '{i.ToString()}'"), dateGiris.Value, dateBitis.Value))
                {
                    cmbOda_no.Items.Add("Oda " + (i));
                }
            }

            if (cmbOda_no.Items.Count < 1)
            {
                MessageBox.Show($"Aradiginiz tarihler arasinda {comboBox1.SelectedText} odalarin hepsi rezerve eidlmistir.");
                dateGiris.Focus();
                cmbOda_no.SelectedIndex = -1;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gunleri_yukle();
        }
    }
}


