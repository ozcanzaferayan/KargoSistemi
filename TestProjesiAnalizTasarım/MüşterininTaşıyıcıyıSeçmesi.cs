using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProjesiAnalizTasarım.Kişiler;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım
{
    public class MüşterininTaşıyıcıyıSeçmesi
    {
        public Müşteri işlemYapanMüşteri;
        public Taşıyıcı seçilecekTaşıyıcı;
        public Kargoİşi kargoİşi;
        public bool isCompleted;

        public MüşterininTaşıyıcıyıSeçmesi(Müşteri işlemYapanMüşteri)
        {
            this.işlemYapanMüşteri = işlemYapanMüşteri;
        }

        public void TaşıyıcıSeç(Taşıyıcı seçilecekTaşıyıcı)
        {
            this.seçilecekTaşıyıcı = seçilecekTaşıyıcı;
        }



        public void TaşıyıcıyıOnayla()
        {
            if (işlemYapanMüşteri != null && seçilecekTaşıyıcı != null)
            {
                isCompleted = true;
            }
            else
            {
                isCompleted = false;
            }
        }



        public void KargoİşiSeç(Kargoİşi kargoİşi)
        {
            this.kargoİşi = kargoİşi;
        }
    }
}
