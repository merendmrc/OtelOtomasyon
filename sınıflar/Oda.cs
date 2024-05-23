using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.sınıflar
{
    internal class Oda
    {
        public int Oda_id {  get; set; }
        public string Oda_tur {  get; set; }

        public int Oda_fiyat { get; set; }
        public bool Oda_durum { get; set; }

        public Oda(int oda_id)
        {
            Oda_id = oda_id;
            var x = Veritabani.Cek("oda_tip,gunluk_ucret", "Odalar", innerJoin:  "Oda_tip on Odalar.odatip_id = Oda_tip.odatip_id", kosul: $"oda_no= {Oda_id}");
            Oda_tur = x[0][0].ToString();
            Oda_durum = true;
            Oda_fiyat = Convert.ToInt32(x[0][1]);
        }
    }
}
