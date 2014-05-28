using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProjesiAnalizTasarım.ÜrünBilgileri;
using TestProjesiAnalizTasarım.Kişiler;

namespace TestProjesiAnalizTasarım
{
    public class Kargoİşi
    {
        public Müşteri müşteri;
        public int ID;
        public ÜrünLineItem ürünLineItem;
        public Fiyat minimumFiyat;
        public bool isComplete;

        public Kargoİşi(Müşteri müşteri)
        {
            this.müşteri = müşteri;
        }

        public ÜrünDescription ÜrünOluştur(Boyut boyut, Ağırlık ağırlık, Tür.Türler tür)
        {
            ÜrünDescription üd = new ÜrünDescription(boyut, ağırlık, tür);
            return üd;
        }

        internal void ÜrünEkle(ÜrünDescription eklenecekÜrünDesc, int quantity)
        {
            this.ürünLineItem = new ÜrünLineItem(eklenecekÜrünDesc, quantity);
        }

        public Teklif BaşlangıçFiyatıBelirle(Fiyat fiyat)
        {
            this.minimumFiyat = fiyat;
            Teklif t = new Teklif(ID, müşteri, fiyat);
            return t;
        }

        internal bool Onay()
        {
            if (this.ID != null && this.minimumFiyat != null && this.müşteri != null && 
                this.ürünLineItem != null)
            {
                this.isComplete = true;
                return isComplete;
            }
            else
            {
                this.isComplete = false;
                return isComplete;
            }
        }

        public override string ToString()
        {
            return "ID: " + ID + "\n" +
                "LineItem: " + ürünLineItem.ToString() + "\n" +
                "Fiyat: " + minimumFiyat.değer.ToString() + "\n" +
                "Müşteri: " + müşteri.ToString(); 
        }
    }
}
