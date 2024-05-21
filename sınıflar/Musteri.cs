using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using SimpleHashing.Net;


namespace OtelOtomasyon.sınıflar
{
    public class Musteri
    {
        SimpleHash sifrele = new SimpleHash();

        public string TCKN { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Sifre { get; set; }

        public List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

        public Musteri(string tckn, string ad, string soyad, string yas, string mail, string tel, string sifre)
        {
            TCKN = tckn;
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Mail = mail;
            Tel = tel;
            Sifre = sifrele.Compute(sifre);
        }

        public void SifreDegis(string YeniSifre)
        {
            Sifre =  sifrele.Compute(YeniSifre);
        }

        public void Rez_ekle(Rezervasyon rezervasyon)
        {
            Veritabani.Ekle("Rezervasyon", $"{rezervasyon.Rez_id},{rezervasyon.Oda_id},{rezervasyon.Hesap_id},'{rezervasyon.Baslangic}','{rezervasyon.Bitis}'");
            Veritabani.Ekle("Rezervasyonlar", $"{Rezervasyon.id_olustur("Rezervasyonlar")},'{this.TCKN}',{rezervasyon.Rez_id}");
        }

    }
}
