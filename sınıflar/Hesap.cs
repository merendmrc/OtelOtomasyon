using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.sınıflar
{
    public class Hesap
    {
        public int Hesap_id {  get; set; }
        public string Hizmet { get; set; }
        public int Tutar { get; set; }


        public Hesap(string hizmet, int tutar)
        {
            Hesap_id = Rezervasyon.id_olustur("Hesaplar");
            Hizmet = hizmet;
            Tutar = tutar;
        }


        public void Hesap_olustur(int rez_id)
        {
            Veritabani.Ekle("Hesaplar", $"{this.Hesap_id},{rez_id},'{this.Hizmet}',{this.Tutar}");

        }

    }
}
