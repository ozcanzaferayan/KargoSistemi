using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProjesiAnalizTasarım.ÜrünBilgileri
{
    public class ÜrünLineItem
    {
        public ÜrünDescription ürünDescription;
        public int quantity;

        public ÜrünLineItem(ÜrünDescription ürünDescription, int quantity)
        {
            this.ürünDescription = ürünDescription;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return ürünDescription.ToString() + " | " + this.quantity + " adet";
        }
    }
}
