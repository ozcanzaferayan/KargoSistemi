using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProjesiAnalizTasarım.Kişiler;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım
{
    public class AçıkEksiltme
    {
        public Taşıyıcı taşıyıcı;
        public Kargoİşi kargoİşi { get; set; }
        public bool teklifYapıldıMı;
        public bool isCompleted;

        public AçıkEksiltme(Taşıyıcı taşıyıcı)
        {
            this.taşıyıcı = taşıyıcı;
        }

        public void İşSeç(Kargoİşi kargoİşi)
        {
            this.kargoİşi = kargoİşi;
        }

        public Teklif FiyatTeklifEt(Fiyat fiyat)
        {
            if (fiyat.değer < kargoİşi.minimumFiyat.değer)
            {
                Teklif teklif = new Teklif(this.kargoİşi.ID, this.taşıyıcı, fiyat);
                teklifYapıldıMı = true;
                return teklif;
            }
            else
            {
                teklifYapıldıMı = false;
                return null;
            }
        }

        public void Onayla()
        {
            if (this.teklifYapıldıMı && this.kargoİşi != null && this.taşıyıcı != null)
            {
                isCompleted = true;
            }
            else
            {
                isCompleted = false;
            }
        }
    }
}
