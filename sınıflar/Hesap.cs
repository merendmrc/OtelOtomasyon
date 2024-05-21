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
            Veritabani.Ekle("Hesaplar", $"{this.Hesap_id},'{this.Hizmet}',{this.Tutar}");

        }

    }
}
