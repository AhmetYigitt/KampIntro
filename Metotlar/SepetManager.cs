using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi : "+ urun.Adi);

        }

        public void Ekle2(string urunAdi, string urunAciklamasi, double urunFiyatı)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
