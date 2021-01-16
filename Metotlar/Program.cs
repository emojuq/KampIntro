using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[]
            {
                urun1,urun2
            };

            // Console.WriteLine()' ı hızlı yazmak için cw + 2 kere tab

            //type safe
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("--------------Metotlar-------------");

            //instance - örnek
            //enxapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut",12,10);
            sepetManager.Ekle2("Elma","Yeşil Elma",12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);
          



        }
    }
}

// Don't repeat yourself - DRY - Clean Code - Best Practice
