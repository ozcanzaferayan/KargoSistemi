using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.ÜrünBilgileri
{
    public class ÜrünDescription : IDisposable
    {
        public int ürünID;
        public Boyut boyut;
        public Ağırlık ağırlık;
        public Tür.Türler tür;

        public ÜrünDescription(Boyut boyut, Ağırlık ağırlık, Tür.Türler tür)
        {
            this.ürünID = IDGenerator.GetÜrünID();
            this.boyut = boyut;
            this.ağırlık = ağırlık;
            this.tür = tür;
        }

        public override string ToString()
        {
            return this.tür.ToString() + " | " + this.ağırlık.ağırlık + " kg";
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
