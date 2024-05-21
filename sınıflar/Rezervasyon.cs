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
        public static int id_olustur(string tablo)
        {
            int id = 1;
            var x = Veritabani.Cek("*", tablo);
            List<int> list = new List<int>();

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

            Oda oda = new Oda(oda_id);
            Rez_id = id_olustur("Rezervasyon");
            Oda_id = oda.Oda_id;
            Baslangic = baslangic;
            Bitis  = bitis;

            Hesap hesap = new Hesap("Konaklama ucreti", Convert.ToDateTime(bitis).Subtract(Convert.ToDateTime(baslangic)).Days * oda.Oda_fiyat);
            Hesap_id = hesap.Hesap_id;

            form_MusteriGiris.oturum.Rez_ekle(this);
        }

    }
}
