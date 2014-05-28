using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.ÜrünBilgileri
{
    public class Boyut
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Boyut(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
