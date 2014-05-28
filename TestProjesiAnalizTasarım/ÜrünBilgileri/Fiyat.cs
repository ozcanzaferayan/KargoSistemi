using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.ÜrünBilgileri
{
    public class Fiyat
    {
        public double değer;
        public Fiyat(double değer)
        {
            this.değer = değer;
        }

        public override string ToString()
        {
            return değer.ToString();
        }
    }
}
