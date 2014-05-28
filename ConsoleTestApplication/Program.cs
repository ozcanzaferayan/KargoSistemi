using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım;
using TestProjesiAnalizTasarım.Kişiler;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace ConsoleTestApplication
{
    class Program
    {
        static Register register;
        static List<String> kullanıcılar;
        static List<String> kargoİşleri;
        public static void InitializeVariables()
        {
            register = new Register();
        }

        static void Main(string[] args)
        {
            InitializeVariables();
            SistemAçılışı();
            
            
        }
        #region Sistem Açılışı
        public static void SistemAçılışı()
        {
            String input;
            kullanıcılar = register.KullanıcılarıGetir();
            if (kullanıcılar.Count == 0)
            {
                Console.WriteLine("Sistemde hiç kullanıcı yok!");
                Console.Write("Kaydolmak ister misiniz((k)aydol/(ç)ıkış):");
                input = Console.ReadLine();
                KullanıcıİşlemineKararVer(input);
            }
            foreach (var kullanıcı in kullanıcılar)
            {
                Console.WriteLine(kullanıcı);
            }
            Console.Write("Giriniz veya Kaydolunuz((g)iriş/(k)aydol/(ç)ıkış): ");
            input = Console.ReadLine();
            KullanıcıİşlemineKararVer(input);
        }
        #endregion
        

        #region Kullanıcı kaydolma, giriş, çıkış
        public static void KullanıcıİşlemineKararVer(String input)
        {
            switch (input)
            {
                case "g":
                    KullanıcıGirişi();
                    break;
                case "k":
                    KullanıcıKaydolma();
                    break;
                case "ç":
                    KullanıcıÇıkışı();
                    break;
                default:
                    Console.WriteLine("Yanlış input girdiniz!");
                    SistemAçılışı();
                    break;
            }
        }



        private static void KullanıcıKaydolma()
        {

            Console.Write("Adınız: ");
            String ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            String soyad = Console.ReadLine();
            Console.Write("Hangi türden bir kullanıcısınız(Müşteri(0)/Taşıyıcı(1)): ");
            String kullanıcıTürü = Console.ReadLine();
            kullanıcılar = register.KullanıcıEkle(ad, soyad, kullanıcıTürü);
            if (kullanıcılar != null)
            {
                Console.WriteLine("Kullanıcı Başarıyla Kaydedildi..");
                Console.WriteLine("Sistemdeki Kullanıcılar: ");
                SistemAçılışı();
            }
            else
            {
                Console.WriteLine("Kullanıcı Bilgileri Hatalı!");
                KullanıcıKaydolma();
            }

        }

        private static void KullanıcıGirişi()
        {
            int input;
            Console.Write("Kullanıcı ID'nizi giriniz: ");
            input = Convert.ToInt32(Console.ReadLine());
            if (!register.KullanıcıGirişi(input))
            {
                Console.WriteLine("Sistemde böyle bir ID yok!");
                KullanıcıGirişi();
            }
            else
            {
                Console.WriteLine("Kullanıcı girişi başarıyla tamamlandı..");
                KullanıcıMenüsünüGetir();
            }
        }
        private static void KullanıcıÇıkışı()
        {
            System.Environment.Exit(0);
        }
        #endregion

        

        private static void KullanıcıMenüsünüGetir()
        {
            kargoİşleri = register.KargoİşleriniGetir();
            if (kargoİşleri.Count == 0)
            {
                Console.WriteLine("Sistemde hiç kargo işi yok!");
            }
            else
            {
                ElemanlarıYazdır(kargoİşleri);
            }
            Console.Write("Yeni bir kargo işi eklemek ister misiniz?(e/h)");
            String input  = Console.ReadLine();
            if (KargoİşiEklensinMi(input))
            {
                register.KargoişiEkle();
            }
            else
            {
                KullanıcıMenüsünüGetir();
            }
        }

        private static bool KargoİşiEklensinMi(string input)
        {
            switch (input)
            {
                case "e":
                    return true;
                default:
                    return false;
            }
        }


        private static void ElemanlarıYazdır(List<string> elemanlar)
        {
            foreach (var eleman in elemanlar)
            {
                Console.WriteLine(eleman);
            }
        }


        
    }
}
