using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProjesiAnalizTasarım.Kişiler;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım
{
    public class Teklif 
    {
        public int ID;
        public int kargoişiID;
        public Kişi kişi;
        public Fiyat fiyat;

        public Teklif(int kargoİşiID, Kişi müşteri, Fiyat fiyat)
        {
            this.ID = IDGenerator.GetTeklifID();
            this.kargoişiID = kargoİşiID;
            this.kişi = müşteri;
            this.fiyat = fiyat;
        }
    }
}
