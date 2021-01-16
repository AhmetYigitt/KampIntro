using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "Engin";
            kurs1.IzlenmeOrani = 458;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.KursunEgitmeni = "kerem";
            kurs2.IzlenmeOrani = 785;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c++";
            kurs3.KursunEgitmeni = "berkay";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "python";
            kurs4.KursunEgitmeni = "yiğit";
            kurs4.IzlenmeOrani = 7850;


            //Console.WriteLine(kurs1.KursAdi + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : "+kurs.KursunEgitmeni);
            }
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string KursunEgitmeni { get; set; }
            public int IzlenmeOrani { get; set; }

        }
    }
}
