  Bu proje, kullanicilarin otel'den rezervasyon yapabilecegi, yaptigi rezervasyonlar hakkinda detayli bilgileri goruntulebildigi ve odalarina siparis verebildigi bir otel otomasyonudur.

  Kullanici bilgileri veritabaninda tutulur. Veri tabaninda tutulur, veri tabani tablolari su sekildedir;
Musteri, Rezervasyonlar, Rezervasyon, Hesap, Oda, Oda_tip. 

  Veritabani islemleri icin "Veritabani" Class'i kullanilir. Bu class temelde 3 metoda sahiptir; Ekle() -> Veritabanina kayit yapar,Cek() Veritabanindan veri ceker,
Kayit_varsa()-> Veritabaninda aranan tabloda gonderilen id ile kayit olup olmadigini sorgular.

  Projedeki butun imputlarin kontrolleri "Input_kontrol" sinifinda yapilir. Bu sinif yaygin input turlerinin formatlarina uygunluk durumunu kontrol etmek icin yazilmistir.
Sinifin icerdigi methodlar baslica su sekildedir; Ad_kontrol(), Mail_kontrol(), Tel_kontrol(), Sifre_kontrol()....


  
  
