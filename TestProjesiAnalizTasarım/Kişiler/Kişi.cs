using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.Kişiler
{
    public abstract class Kişi
    {

        public enum KullanıcıTürleri { Müşteri, Taşıyıcı };
        public int OID { get; set; }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public KullanıcıTürleri Türü { get; set; }
        public Kişi(KullanıcıTürleri türü, String ad, String soyad)
        {
            this.Türü = türü;
            this.OID = IDGenerator.GetKişiID();
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Kişi(string Ad1, string Soyad1)
        {
            this.OID = IDGenerator.GetKişiID();
            this.Ad = Ad1;
            this.Soyad = Soyad1;
        }

        public override string ToString()
        {
            return OID + " | " + Türü.ToString() + " | " + this.Ad + " | " + this.Soyad;
        }

    }
}
