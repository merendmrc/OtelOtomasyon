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
using OtelOtomasyon.sınıflar;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OtelOtomasyon.formlar
{
    public partial class form_Rezervasyonlarim : Form
    {
        public form_Rezervasyonlarim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void form_Rezervasyonlarim_Load(object sender, EventArgs e)
        {
            var x = Veritabani.Cek("Musteriler.musteri_ad,Musteriler.musteri_soyad,Rezervasyon.oda_no,Rezervasyon.baslangic_tarih,Rezervasyon.bitis_tarih,Musteriler.musteri_tckn,Oda_tip.oda_tip,Rezervasyon.rezervasyon_id", "Rezervasyonlar", innerJoin: "Musteriler on Rezervasyonlar.musteri_tckn = Musteriler.musteri_tckn inner join Rezervasyon on Rezervasyonlar.rezervasyon_id = Rezervasyon.rezervasyon_id inner join Odalar on Rezervasyon.oda_no = Odalar.oda_no inner join Oda_tip on Odalar.odatip_id = Oda_tip.odatip_id", kosul: $"Rezervasyonlar.musteri_tckn = '{form_MusteriGiris.oturum.TCKN}'");
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Ad", typeof(string));
            dataTable.Columns.Add("Soyad", typeof(string));
            dataTable.Columns.Add("Oda no", typeof(string));
            dataTable.Columns.Add("Giris tarihi", typeof(string));
            dataTable.Columns.Add("Cikis tarihi", typeof(string));
            dataTable.Columns.Add("Tckn", typeof(string));
            dataTable.Columns.Add("Oda Tip", typeof(string));
            dataTable.Columns.Add("Rez_id", typeof(string));

            foreach (var rowList in x)
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < rowList.Count; i++)
                {
                    row[i] = rowList[i];
                }
                dataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Tckn"].Visible = false;
            dataGridView1.Columns["Oda Tip"].Visible = false;
            dataGridView1.Columns["Rez_id"].Visible = false;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "butonlarr";
            buttonColumn.Text = "Detay";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];


                var hizmetler = Veritabani.Cek("*", "Hesaplar", kosul: $"rezervasyon_id = {selectedRow.Cells["Rez_id"].Value}");

                MessageBox.Show(hizmetler.Count.ToString());

                string Hizmetler = "Fatura:\n";
                int Total_ucret = 0;

                for (int i = 0; i < hizmetler.Count; i++)
                {
                    Hizmetler += string.Format("{0}: {1:N2}₺\n", hizmetler[i][2], hizmetler[i][3]);
                    Total_ucret += Convert.ToInt32(hizmetler[i][3]);
                }

                

                string ad = selectedRow.Cells["Ad"].Value.ToString();
                string soyad = selectedRow.Cells["Soyad"].Value.ToString();
                string tckn = selectedRow.Cells["Tckn"].Value.ToString();
                DateTime giris = Convert.ToDateTime(selectedRow.Cells["Giris tarihi"].Value);
                DateTime cikis = Convert.ToDateTime(selectedRow.Cells["Cikis tarihi"].Value);
                string sgiris = giris.ToShortDateString();
                string scikis = cikis.ToShortDateString();
                string Total_gun = cikis.Subtract(giris).Days.ToString();
                string Oda_tip = selectedRow.Cells["Oda Tip"].Value.ToString();




                string Mesaj = $"Ad: {ad}\nSoyad: {soyad}\nTCKN:{tckn}\nOda turu: {Oda_tip}\nGiris tarihi: {sgiris}\nCikis tarihi: {scikis}\nToplam konaklanan gun: {Total_gun}\n{Hizmetler}\nToplam ucret: {Total_ucret}₺";
                MessageBox.Show(Mesaj, "Hesap özet");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detaylar gosterilirken hata\n" +ex);
                throw;
            }
        }
    }
}
