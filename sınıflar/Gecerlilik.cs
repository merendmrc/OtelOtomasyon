using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.classes
{
    internal class Gecerlilik
    {
        private static bool uygun;
        private static string hatamsg = "";
        private static int ozelkarakter;
        private static int bosluk;
        private static int buyukharf;
        private static int rakamlar;

        private static (int, int, int, int) Karakter_turler(string kelime)
        {
            //Alinan string'in icerdigi ozel karakter sayisini, bosluk sayisini, buyuk harf sayisini doner.
            //Args: kelime(string, ozel karakter sayisi donulecek kelime.)
            //Returns: Item1: ozelkarakter(integer)
            //         Item2: bosluk(interger)
            //         Item3: buyukharf(integer)
            //         Item4: rakamlar(integer)

            ozelkarakter = 0;
            bosluk = 0;
            buyukharf = 0;
            rakamlar = 0;

            foreach (char c in kelime)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    ozelkarakter++;
                }
                if (c == ' ')
                {
                    bosluk++;
                }
                if (char.IsUpper(c))
                {
                    buyukharf++;
                }
                if (char.IsDigit(c))
                {
                    rakamlar++;
                }
            }

            return (ozelkarakter, bosluk, buyukharf, rakamlar);
        }

        private static bool UcTekrar(string kelime)
        {
            //verilen kelimede ayni karakter 3 kere art arda geciyor ise true; gecmiyor ise false doner.
            for (int i = 0; i < kelime.Length - 2; i++)
            {
                if (kelime[i] == kelime[i + 1] && kelime[i + 1] == kelime[i + 2])
                {
                    return true;
                }
            }
            return false;
        }


        public static (bool, string) Ad_kontrol(string kelime)
        {
            //Alinan string'in bir 'isim' formatina uygunlugunu kontrol eder.
            //Args: kelime(string) : kontrol edilecek kelime
            //Returns : Item1 : uygun(boolean)
            //          Item2 : hatamsg(string)
            //---------------------------------------------------------------
            //kelime null veya karakter sayisi 0 --> (false,hata mesaji)
            //kelime karakter sayisi (1,25) arasinda degil --> (false,hata mesaji)
            //kelime 1 veya daha fazla ozel karakter iceriyor --> (false,hata mesaji)
            //diger durumlar --> (true,hata mesaji(bos string))

            uygun = true;
            hatamsg = "";
            kelime = kelime.Trim();
            ozelkarakter = Karakter_turler(kelime).Item1;

            if (string.IsNullOrEmpty(kelime))
            //ad bos mu kontrolu
            {
                hatamsg += "Bu kisim bos birakilamaz.";
                uygun = false;
            }
            else if (kelime.Length <= 1 || kelime.Length >= 25)
            //ad uzunluk kontrolu
            {
                hatamsg += "adiniz en az iki, en fazla 25 karakter icermelidir.\n";
                uygun = false;
            }
            if (ozelkarakter > 0)
            //ozel karakter iceriyor mu kontrolu
            {
                hatamsg += "adiniz ozel karakter iceremez.";
                uygun = false;
            }
            return (uygun, hatamsg);
        }

        public static (bool, string) Mail_Kontrol(string mail)
        {
            //Alinan stringin email formatina uygunlugunu kontrol eder.
            //Args: mail(string) kontrol edilecek string
            //Returns: Item1: uygun(boolean)
            //         Item2: hatamsg(string)
            //----------------------------------------------------
            //mail null veya karakter sayisi 0 --> (false,hatamsg)
            //mail '@' veya '.' icermiyor --> (false,hata mesaji)
            //mail bosluk iceriyor --> (false,hata mesaji)
            //mail'in '@' sembolunden once, '@' ve '.' arasinda ve '.' sembolunden sonra en az 2 karakter icermiyorsa --> (false,hata mesaji)
            //diger durumlar --> (true,hata mesaji(bos string))

            uygun = true;
            hatamsg = "";
            mail = mail.Trim();
            (ozelkarakter, bosluk, _, _) = Karakter_turler(mail);


            if (string.IsNullOrEmpty(mail))
            //mail bos mu kontrolu
            {
                hatamsg += "Bu kisim bos birakilamaz.";
                uygun = false;
            }
            else if (!mail.Contains("@") || !mail.Contains("."))
            {
                hatamsg += "Mail formati su sekilde olmalidir: 'birisi@example.com'\n";
                uygun = false;
            }
            else if (bosluk > 0)
            {
                hatamsg += "E-mail'iniz bosluk iceremez.\n";
                uygun = false;
            }
            else
            {
                int atIndex = mail.IndexOf("@");
                int dotIndex = mail.IndexOf(".");

                string ad = mail.Substring(0, atIndex);
                string domain = mail.Substring(atIndex + 1, dotIndex - atIndex - 1);
                string uzanti = mail.Substring(dotIndex + 1, mail.Length - dotIndex - 1);

                if (ad.Length < 2)
                {
                    hatamsg += "E-mail'inizin '@' isaretinden once en az iki karakter icermesi gerekir\n.";
                    uygun = false;
                }
                if (domain.Length < 2)
                {
                    hatamsg += "En az 2 karakterlik bir alan adi gereklidir.\n";
                    uygun = false;

                }
                else if (Karakter_turler(domain).Item1 > 0)
                {
                    hatamsg += "Alan adiniz ozel karakter iceremez.\n";
                    uygun = false;
                }
                if (uzanti.Length < 2)
                {
                    hatamsg += "En az 2 karakterlik bir uzanti gereklidir.\n";
                    uygun = false;
                }

                else if (Karakter_turler(uzanti).Item1 > 0)
                {
                    hatamsg += "Uzanti kismi ozel karakter iceremez.\n";
                    uygun = false;
                }

            }
            return (uygun, hatamsg);
        }

        public static (bool, string) Sifre_kontrol(string Sifre)
        {
            uygun = true;
            hatamsg = "";
            (ozelkarakter, bosluk, buyukharf, _) = Karakter_turler(Sifre);

            if (string.IsNullOrEmpty(Sifre))
            {
                uygun = false;
                hatamsg += "Bu alan bos birakilamaz.\n";

            }
            else if (Sifre.Length < 10 || Sifre.Length > 30)
            {
                uygun = false;
                hatamsg += "Sifreniz en az 10, en fazla 30 karakter icermelidir.\n";
            }
            else
            {
                if (bosluk > 0)
                {
                    uygun = false;
                    hatamsg += "Sifreniz bosluk icermemelidir.\n";
                }
                if (ozelkarakter < 1)
                {
                    uygun = false;
                    hatamsg += "Sifreniz en az 1 tane ozel karakter icermelidir.\n";
                }
                if (buyukharf < 1)
                {
                    uygun = false;
                    hatamsg += "Sifreniz en az 1 tane buyuk harf icermelidir.\n";
                }
                if (UcTekrar(Sifre))
                {
                    uygun = false;
                    hatamsg += "Sifrenizde bir karakter 3 kere art arda kullanilamaz.\n";
                }

            }

            return (uygun, hatamsg);
        }

        public static (bool, string) TelNo_kontrol(string TelNo)
        {
            uygun = true;
            hatamsg = "";

            if (string.IsNullOrEmpty(TelNo))
            {
                uygun = false;
                hatamsg += "Bu alan bos birakilamaz.\n";

            }
            else if (TelNo.Length != 10)
            {
                uygun = false;
                hatamsg += "Lutfen telefon numaranizi 5xx xxx xx xx seklinde 10 haneden olusacak sekilde giriniz.\n";
            }
            else if (Karakter_turler(TelNo).Item4 != 10)
            {
                uygun = false;
                hatamsg += "Telefon numaranizi kontrol ediniz.\n";
            }
            else if (!TelNo.StartsWith("5"))
            {
                uygun = false;
                hatamsg += "Telefon numaraniz '5' rakami ile baslamalidir.\n";
            }
            return (uygun, hatamsg);
        }

        public static (bool, string) Tckn_kontrol(string tckn)
        {
            uygun = true;
            hatamsg = "";
            if (string.IsNullOrEmpty(tckn))
            {
                uygun = false;
                hatamsg += "Bu alan bos birakilamaz.\n";

            }
            else if (tckn.Length != 11)
            {
                uygun = false;
                hatamsg += "Kimlik numaraniz 11 haneden olusmalidir.";
            }
            else if (Karakter_turler(tckn).Item4 != 11)
            {
                uygun = false;
                hatamsg += "Kimlik numaranizi kontrol ediniz.\n";
            }
            else if (tckn.StartsWith("0"))
            {
                uygun = false;
                hatamsg += "Kimlik numaraniz '0' rakami ile baslamalidir.\n";
            }
            return (uygun, hatamsg);
        }

        public static (bool, string) Yas_Kontrol(string yas)
        {
            uygun = true;
            hatamsg = "";
            if (string.IsNullOrEmpty(yas))
            {
                uygun = false;
                hatamsg += "Bu alan bos birakilamaz.\n";

            }
            else if (Karakter_turler(yas).Item4 != yas.Length)
            {
                uygun = false;
                hatamsg += "Yasinizi kontrol eidniz.";
            }
            else if (int.Parse(yas) <= 0 || int.Parse(yas)>= 150)
            {
                uygun = false;
                hatamsg += "Yasinizi kontrol eidniz.";
            }
            return (uygun, hatamsg);
        }
    }

}
