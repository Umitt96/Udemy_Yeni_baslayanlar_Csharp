using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach ile dizi yazdırma

            /* 
            string[] isimler = { "Ümit", "Rita", "Ritalin", "Ahmet" , "Zehra", "Necmettin"};

            //Console.WriteLine(isimler[1]);

            Console.WriteLine("İsimler dizisinin içeriği");
            foreach (string s in isimler) {
                Console.WriteLine("- "+ s);
            }*/

            //Matris yapısı

            string[,] bolgeler = new string[3, 3]
            {
                {"istanbul", "kocaeli", "izmit"},
                {"ankara", "konya", "null"},
                {"rize", "trabzon", "samsun"}
            };

            for (int i = 0; i < bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0;  j < bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }
            }

        }
    }
}