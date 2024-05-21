using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan gunSayisi = dateTimePicker2.Value.Subtract(dateTimePicker1.Value);
            /*
            MessageBox.Show($"'Konaklama ucreti',{gunSayisi.Days}");
            Veritabani.Ekle("Hesaplar", $"'Konaklama ucreti',{gunSayisi.Days}");
            Veritabani.Ekle("Rezervasyon", $"{comboBox2.SelectedIndex},25,'{dateTimePicker1.Text}','{dateTimePicker2.Text}'");
            Veritabani.Ekle("Rezervasyonlar", $"{77777777777},24");
             
             */

        }
    }
}
