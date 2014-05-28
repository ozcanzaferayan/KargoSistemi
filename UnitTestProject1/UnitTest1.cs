using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProjesiAnalizTasarım;
using TestProjesiAnalizTasarım.Kişiler;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Register actualregister;
        Müşteri actualMüşteri;
        Taşıyıcı actualTaşıyıcı;
        public UnitTest1()
        {
            actualregister = new Register();
            actualMüşteri = new Müşteri("Zafer", "asdasd");
            actualregister.kullanıcı = actualMüşteri;
            actualregister.KargoişiEkle();
            Boyut actualBoyut = new Boyut(3,4,5);
            Ağırlık actualAğırlık = new Ağırlık(10);
            Tür.Türler actualTür = Tür.Türler.EvcilHayvan;
            actualregister.ÜrünOluştur(actualBoyut, actualAğırlık, actualTür);
            actualregister.ÜrünEkle(0, 7);
            actualregister.BaşlangıçFiyatıBelirle(new Fiyat(20.0f));
            actualregister.Onay();
            actualTaşıyıcı = new Taşıyıcı(Kişi.KullanıcıTürleri.Taşıyıcı, "Ahmet", "Dellal");
            actualregister.TaşıyıcıEkle(actualTaşıyıcı);
            actualregister.TaşıyıcıGirişi(1);
            actualregister.AçıkEksiltmeyeKatıl();
            actualregister.İşSeç(0);
            actualregister.FiyatTeklifEt(new Fiyat(15));
            actualregister.MüşteriGirişi(0);
            actualregister.TaşıyıcıSeçmeyeKatıl();
            actualregister.KargoİşiSeç(0);
            actualregister.TeklifSeç(1);
            actualregister.TaşıyıcıOnayla();
        }


        #region Use Case UC1: Kargo İşi Ekleme Tests             

        [TestMethod]
        public void MüşteriKullanıcıGirişiTest()
        {
            actualregister.MüşteriEkle(actualMüşteri);
            actualregister.MüşteriGirişi(12);
            Assert.AreEqual(actualregister.kullanıcı, actualMüşteri);
        }

        [TestMethod]
        public void KargoİşiEkleIDTest()
        {
            Kargoİşi expectedKargoİşi = new Kargoİşi(actualMüşteri);
            expectedKargoİşi.ID = 1;
            Assert.AreEqual(expectedKargoİşi.ID, actualregister.kargoİşi.ID);
        }

        [TestMethod]
        public void KargoİşiEkleMüşteriTest()
        {
            Kargoİşi expectedKargoİşi = new Kargoİşi(actualMüşteri);
            expectedKargoİşi.ID = 0;
            Assert.AreEqual(expectedKargoİşi.müşteri, actualregister.kargoİşi.müşteri);
        }

        [TestMethod]
        public void ÜrünOluşturTest()
        {
            Boyut expectedBoyut = new Boyut(3,4,5);
            Ağırlık expectedAğırlık = new Ağırlık(10);
            Tür.Türler expectedTür = Tür.Türler.EvcilHayvan;
            ÜrünDescription expectedDescription = new ÜrünDescription(expectedBoyut, expectedAğırlık, expectedTür);
            Assert.AreEqual(expectedDescription.ürünID, 
                ((ÜrünDescription)actualregister.facade.Get(0, typeof(ÜrünDescription))).ürünID + 1,
                expectedDescription.ürünID + " != " + ((ÜrünDescription)actualregister.facade.Get(0, typeof(ÜrünDescription))).ürünID
                );
        }

        [TestMethod]
        public void ÜrünEkleTest()
        {
            Boyut expectedBoyut = new Boyut(3, 4, 5);
            Ağırlık expectedAğırlık = new Ağırlık(10);
            Tür.Türler expectedTür = Tür.Türler.EvcilHayvan;
            ÜrünDescription expectedDescription = new ÜrünDescription(expectedBoyut, expectedAğırlık, expectedTür);
            ÜrünLineItem expectedÜrünLineItem = new ÜrünLineItem(expectedDescription, 7);
            Assert.AreEqual(expectedÜrünLineItem.ürünDescription.ürünID, 
                actualregister.kargoİşi.ürünLineItem.ürünDescription.ürünID + 1);
        }

        [TestMethod]
        public void BaşlangıçFiyatıBelirleFiyatTest()
        {
            Fiyat expectedFiyat = new Fiyat(20.0f);
            Fiyat actualFiyat = actualregister.kargoİşi.minimumFiyat;
            Assert.AreEqual(expectedFiyat.değer, actualFiyat.değer);
        }

        [TestMethod]
        public void BaşlangıçFiyatıBelirleIDveKişiTest()
        {
            Fiyat expectedFiyat = new Fiyat(20.0f);
            Teklif expectedTeklif = new Teklif(0, actualMüşteri, expectedFiyat);
            Teklif actualTeklif = (Teklif)actualregister.facade.Get(0, typeof(Teklif));
            Assert.AreEqual(expectedTeklif.ID, actualTeklif.ID + 1);
            Assert.AreEqual(expectedTeklif.kişi, actualTeklif.kişi);
        }
        
        [TestMethod]
        public void KargoİşiOnayTest()
        {
            bool expectedIsComplete = true;
            bool actualIsComplete = actualregister.kargoİşi.isComplete;
            Assert.AreEqual(expectedIsComplete, actualIsComplete);
        }

        #endregion
        #region Use Case UC2: Açık Eksiltmeye Katılma Tests      

        [TestMethod]
        public void TaşıyıcıKullanıcıGirişiTest()
        {
            Assert.AreEqual(actualregister.kullanıcı, actualTaşıyıcı);
        }

        [TestMethod]
        public void AçıkEksiltmeyeKatılTest()
        {
            Assert.AreEqual(actualTaşıyıcı, actualregister.açıkEksiltme.taşıyıcı);
        }

        [TestMethod]
        public void İşSeçTest()
        {
            Assert.AreEqual(actualregister.kargoİşi, actualregister.açıkEksiltme.kargoİşi);
        }

        [TestMethod]
        public void FiyatTeklifiTest()
        {
            bool actualTeklifYapıldıMı = actualregister.açıkEksiltme.teklifYapıldıMı;
            Assert.AreEqual(true, actualTeklifYapıldıMı);
        }

        [TestMethod]
        public void AçıkEksiltmeOnayTest()
        {
            actualregister.AçıkEksiltmeOnayla();
            bool actualIscomplete = actualregister.açıkEksiltme.isCompleted;
            Assert.AreEqual(true, actualIscomplete);
        }
        #endregion
        #region Use Case UC3: Müşterinin Taşıyıcıyı Seçmesi Tests

        [TestMethod]
        public void MTSMüşteriKullanıcıGirişiTest()
        {
            Assert.AreEqual(actualMüşteri.Ad, actualregister.kullanıcı.Ad);
        }

        [TestMethod]
        public void TaşıyıcıSeçmeyeKatılTest()
        {
            Assert.AreEqual((Müşteri)actualregister.kullanıcı, 
                actualregister.mts.işlemYapanMüşteri);
        }

        [TestMethod]
        public void KargoİşiSeçTest()
        {
            Assert.AreEqual(actualregister.kargoİşi.ID, 
                actualregister.mts.kargoİşi.ID);
        }

        [TestMethod]
        public void TaşıyıcıTeklifiSeçTest()
        {
            Taşıyıcı actualTaşıyıcı = actualregister.mts.seçilecekTaşıyıcı;
            Assert.AreEqual(this.actualTaşıyıcı, actualTaşıyıcı);
        }

        [TestMethod]
        public void TaşıyıcıyıOnaylaTest()
        {
            
            bool actualIsCompleted = actualregister.mts.isCompleted;
            Assert.AreEqual(true, actualIsCompleted);
        }

        #endregion
    }
}
