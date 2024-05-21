using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections;

namespace OtelOtomasyon.sınıflar
{
    internal class Veritabani
    {
        private static string connectionString = "Data Source=MERENDMRC\\SQLEXPRESS;Initial Catalog=OtelOtomasyon;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static void Ekle(string tablo, string degerler)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {

                try
                {
                    baglanti.Open();
                    SqlCommand _sorgu = new SqlCommand($"INSERT INTO {tablo} values ({degerler})", baglanti);
                    _sorgu.ExecuteNonQuery();
                    MessageBox.Show("Kayit basarili.");
                }
                catch (Exception ex)
                {
                    baglanti.Close();
                    MessageBox.Show("baglanti sirasinda hata..\n" + ex);
                    throw;
                }
                finally
                {
                    baglanti.Close();
                }
            }

        }

        public static List<List<string>> Cek(string sutunlar, string tablo, string kosul = "1=1", string innerJoin = null)
        {
            ///<summary>
            ///Veritabanından belirli sütunları seçen ve belirli bir koşulu sağlayan verileri döndüren bir fonksiyon.
            ///</summary>
            ///<param name="sutunlar">Veritabanından hangi sütunların alınacağını belirler. Birden fazla sütun ismi virgülle ayrılarak yazılmalıdır.</param>
            ///<param name="tablo">Veritabanında hangi tablo üzerinde işlem yapılacağını belirler.</param>
            ///<param name="kosul">Veri seçiminde uygulanacak koşulu belirler. Varsayılan olarak "1=1" olarak ayarlanmıştır. Koşulun formatı "özellik_adi = deger" şeklinde olmalıdır.</param>
            ///<param name="innerJoin">Eğer tablo birleştirme işlemi yapılacaksa bu parametre kullanılır. Varsayılan olarak null'dır. Birleştirme formatı "tablo_adi on ozellik1=ozellik2" şeklinde olmalıdır.</param>
            ///<returns>Seçilen sütunlara sahip ve belirtilen koşulu sağlayan verileri içeren bir matris.</returns>


            List<List<string>> degerler = new List<List<string>>();
            string sorgu = $"select {sutunlar} from {tablo}";

            if (!string.IsNullOrEmpty(innerJoin))
            {
                sorgu += $" INNER JOIN {innerJoin} ";
            }
            sorgu += $" WHERE {kosul}";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {

                try
                {
                    baglanti.Open();
                    SqlCommand _sorgu = new SqlCommand(sorgu, baglanti);

                    using (SqlDataReader okuyucu = _sorgu.ExecuteReader())
                    {
                        
                        while(okuyucu.Read())
                        {
                            List<string> satir = new List<string>();
                            for (int i = 0; i < okuyucu.FieldCount; i++)
                            {
                                satir.Add(okuyucu[i].ToString());
                            }
                            degerler.Add(satir);
                        }
                    }


                    return degerler;
                }
                catch (Exception ex)
                {
                    baglanti.Close();
                    MessageBox.Show("Cekme sirasinda hata..\n" + ex);
                    throw;
                }
                finally
                {
                    baglanti.Close();
                }

            }

        }

        public static bool Kayit_varsa(string tablo,string id_sutunu ,string id)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                string sorgu = $"select * from {tablo} where {id_sutunu} = {id}";
                try
                {
                    baglanti.Open();
                    SqlCommand _sorgu = new SqlCommand(sorgu, baglanti);

                    using (SqlDataReader okuyucu = _sorgu.ExecuteReader())
                    {
                        okuyucu.Read();
                        if (okuyucu.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
                catch (Exception ex)
                {
                    baglanti.Close();
                    MessageBox.Show("kayit kontrol sirasinda hata..\n" + ex);
                    throw;
                }
                finally
                {
                    baglanti.Close();
                }

            }
        }
    }
}
