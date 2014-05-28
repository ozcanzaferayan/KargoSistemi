using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım.Facade;
using TestProjesiAnalizTasarım.Kişiler;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım
{
    public class Register
    {
        public DBFacade facade;
        public Kişi kullanıcı;
        public Kargoİşi kargoİşi;
        public AçıkEksiltme açıkEksiltme;
        public MüşterininTaşıyıcıyıSeçmesi mts;
        public Register()
        {
            facade = DBFacade.GetInstance();
        }

        #region Kullanıcı Girişi
        public List<String> TümKullanıcılarıGetir()
        {
            return facade.GetAll(typeof(Kişi));
        }

        public List<String> KullanıcıEkle(string ad, string soyad, string kullanıcıTürü)
        {
            try
            {
                switch (kullanıcıTürü)
                {
                    case "0":
                        MüşteriEkle(new Müşteri(ad, soyad));
                        return TümKullanıcılarıGetir();
                    case "1":
                        TaşıyıcıEkle(new Taşıyıcı(ad, soyad));
                        return TümKullanıcılarıGetir();
                    default:
                        return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
            

        }

        public bool KullanıcıGirişi(int input)
        {
            if (!MüşteriGirişi(input))
            {
                if (!TaşıyıcıGirişi(input))
                {
                    return false;
                }
            }
            return true;
        }

        public List<String> KullanıcılarıGetir()
        {
            var kişiler = facade.GetAll(typeof(Kişi));
            if (kişiler == null) kişiler = new List<string>()
            { 
                "Sisteme kayıtlı Herhangi bir kişi bulunmamaktadır"
            };
            return kişiler;
        }

        public void MüşteriEkle(Müşteri m)
        {
            facade.Put(m, typeof(Müşteri));
        }

        public bool MüşteriGirişi(int OID)
        {
            kullanıcı = (Müşteri)facade.Get(OID, typeof(Müşteri));
            if (kullanıcı == null) return false;
            return true;
        }
        public void TaşıyıcıEkle(Taşıyıcı t)
        {
            facade.Put(t, typeof(Taşıyıcı));
        }

        public bool TaşıyıcıGirişi(int OID)
        {
            kullanıcı = (Taşıyıcı)facade.Get(OID, typeof(Taşıyıcı));
            if (kullanıcı == null) return false;
            return true;
        }
        #endregion

        #region Use Case UC1 : Kargo İşi Ekleme

        /// <summary>
        /// Yeni oluşturulan kargo işinin müşterisi ve ID'si atanıyor
        /// </summary>
        public List<String> KargoişiEkle()
        {
            kargoİşi = new Kargoİşi((Müşteri)kullanıcı);
            kargoİşi.ID = IDGenerator.GetKargoİşiID();
            return facade.GetAll(typeof(Kargoİşi));
        }

        /// <summary>
        /// Kargo İşi için description oluşturur ve kargo işine bu description'ı set eder.
        /// </summary>
        /// <param name="boyut"></param>
        /// <param name="ağırlık"></param>
        /// <param name="tür"></param>
        public void ÜrünOluştur(Boyut boyut, Ağırlık ağırlık, Tür.Türler tür)
        {
            ÜrünDescription üd = kargoİşi.ÜrünOluştur(boyut, ağırlık, tür);
            facade.Put(üd, typeof(ÜrünDescription));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ürünID">Eklenecek ürünün Description'ı</param>
        /// <param name="quantity">Eklenecek ürünün sayısı</param>
        public void ÜrünEkle(int ürünID, int quantity) 
        {
            ÜrünDescription eklenecekÜrünDesc = (ÜrünDescription)facade.Get(ürünID, typeof(ÜrünDescription));
            kargoİşi.ÜrünEkle(eklenecekÜrünDesc, quantity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fiyat">Teklif yapılabilecek en düşük fiyat</param>
        public void BaşlangıçFiyatıBelirle(Fiyat fiyat)
        {
            Teklif t = kargoİşi.BaşlangıçFiyatıBelirle(fiyat);
            facade.Put(t, typeof(Teklif));
        }

        public string Onay()
        {
            bool isComplete = kargoİşi.Onay();
            if (isComplete)
            {
                facade.Put(kargoİşi, typeof(Kargoİşi));
                return "Onaylandı!";
            }
            else
            {
                return "Onaylanamadı! Bilgilerden biri eksik!";
            }
        }

        #endregion

        #region Use Case UC2 : Taşıyıcının Açık Eksiltmeye Katılması
        public List<String> AçıkEksiltmeyeKatıl()
        {
            açıkEksiltme = new AçıkEksiltme((Taşıyıcı)kullanıcı);
            return facade.GetAll(typeof(Kargoİşi));
        }

        public void İşSeç(int kargoİşiID)
        {
            Kargoİşi kargoİşi = (Kargoİşi)facade.Get(kargoİşiID, typeof(Kargoİşi));
            açıkEksiltme.İşSeç(kargoİşi);
        }

        public string FiyatTeklifEt(Fiyat fiyat)
        {
            Teklif fiyatTeklifi = açıkEksiltme.FiyatTeklifEt(fiyat);
            if (fiyatTeklifi != null)
            {
                facade.Put(fiyatTeklifi, typeof(Teklif));
                return fiyat + " TL'lik teklif yapıldı.";
            }
            else
            {
                return "Teklif yapılamadı!\n" + fiyat + " TL'lik teklif minimum değerden fazla!";
            }
        }

        public string AçıkEksiltmeOnayla()
        {
            açıkEksiltme.Onayla();
            if (açıkEksiltme.isCompleted)
            {
                facade.Put(açıkEksiltme, typeof(AçıkEksiltme));
                return "Onaylandı.";
            }
            else
            {
                return "Eksik bir girdi var!";
            }
        }
        #endregion

        #region Use Case UC3 : Müşterinin Taşıyıcıyı Seçmesi


        public void TaşıyıcıSeçmeyeKatıl()
        {
            mts = new MüşterininTaşıyıcıyıSeçmesi((Müşteri)kullanıcı);
        }

        public void KargoİşiSeç(int kargoİşiID)
        {
            this.kargoİşi = facade.Get(kargoİşiID, typeof(Kargoİşi)) as Kargoİşi;
            mts.KargoİşiSeç(kargoİşi);
        }

        public void TeklifSeç(int teklifID)
        {
            Teklif teklif = (Teklif)facade.Get(teklifID, typeof(Teklif));
            Taşıyıcı taşıyıcı = teklif.kişi as Taşıyıcı;
            mts.TaşıyıcıSeç(taşıyıcı);
        }

        public string TaşıyıcıOnayla()
        {
            mts.TaşıyıcıyıOnayla();
            if (mts.isCompleted)
            {
                facade.Put(mts, typeof(MüşterininTaşıyıcıyıSeçmesi));
                return mts.seçilecekTaşıyıcı.Ad + " onaylandı.";
            }
            else
            {
                return "Eksik bilgi var";
            }
        }

        #endregion




        public List<string> KargoİşleriniGetir()
        {
            return facade.GetAll(typeof(Kargoİşi));
        }
    }
}
