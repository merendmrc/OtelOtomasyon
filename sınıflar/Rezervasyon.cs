using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.sınıflar
{
    public class Rezervasyon
    {
        public int Rez_id {  get; set; }
        public int Oda_id {  get; set; }
        public int Hesap_id {  get; set; }  
        public string Baslangic {  get; set; }
        public string Bitis {  get; set; }

        public bool Aktif;
        public static int id_olustur(string tablo)
        {
            int id = 1;
            var x = Veritabani.Cek("*", tablo);
            List<int> list = new List<int>();

            if(x.Count<1)
            {
                return id;
            }
            foreach (var i in x)
            {
                list.Add(int.Parse(i[0]));
            }
            while (true)
            {
                if (!list.Contains(id))
                {
                    return id;
                }
                id++;
            }
        }

        public Rezervasyon(int oda_id, string baslangic, string bitis)
        {
            Rez_id = id_olustur("Rezervasyon");
            Oda_id = oda_id;
            Baslangic = baslangic;
            Bitis  = bitis;
            Aktif = (Convert.ToDateTime(baslangic)<= DateTime.Now && Convert.ToDateTime(bitis) >= DateTime.Now) ? true : false;
            Hesap_id = Rezervasyon.id_olustur("Hesaplar");

        }

        public void Rezervasyon_olustur()
        {
            Oda oda = new Oda(Oda_id);
            form_MusteriGiris.oturum.Rez_ekle(this);     
            Hesap hesap = new Hesap("Konaklama ucreti", Convert.ToDateTime(Bitis).Subtract(Convert.ToDateTime(Baslangic)).Days * oda.Oda_fiyat);
            hesap.Hesap_olustur(this.Rez_id);
        }
    }
}
