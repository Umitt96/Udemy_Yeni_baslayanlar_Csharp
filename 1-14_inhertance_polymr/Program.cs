using System;

namespace MyApp 
{
    class Hayvan
    {
        public string isim { get; set; }

        public void Ses_cikar()
        {
            Console.WriteLine($"{isim} bir ses çıkarıyor!");
        }

    }


    class Kopek : Hayvan
    {
        public void Havla()
        {
            Console.WriteLine($"{isim} havlıyor...");
        }
    }

    class Kedi : Hayvan
    {
        public void Miyavla()
        {
            Console.WriteLine($"{isim} miyavlıyor...");
        }
    }
    class Balik : Hayvan
    {
        public void Gluk_Gluk()
        {
            Console.WriteLine($"{isim} boğuluyor...");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek();
            kopek.isim = "Shiva";

            kopek.Ses_cikar();
            kopek.Havla();


            Kedi kedi_1 = new Kedi();
            kedi_1.isim = "Tekir";
            kedi_1.Miyavla();

            Balik balik_1 = new Balik();
            balik_1.isim = "Rex";
            balik_1.Gluk_Gluk();
        }
    }
}