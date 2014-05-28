using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.Kişiler
{
    public class Müşteri: Kişi
    {
        public Müşteri(String Ad, String Soyad) : base( Ad, Soyad) 
        {
            Türü = KullanıcıTürleri.Müşteri;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
