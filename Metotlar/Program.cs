using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type-safe 
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }


            Console.WriteLine("--------------Metotlar-------");

            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            Console.WriteLine("----------");

            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır karpuzu", 10);

        }
    }
}
