using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.Kişiler
{
    public class Taşıyıcı : Kişi
    {
        public Taşıyıcı(String Ad, String Soyad) : base(Ad, Soyad) 
        {
            this.Türü = KullanıcıTürleri.Taşıyıcı;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
