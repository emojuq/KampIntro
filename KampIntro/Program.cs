using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type Safety - Tip Güvemliği
            // Don't repeat yourself - kendini tekrarlama
            //değer tutucu - alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDün = 7.35;
            double dolarBugün = 7.45;

            if (dolarDün>dolarBugün)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDün<dolarBugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }





            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
           
            

        }
    }
}
