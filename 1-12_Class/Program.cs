using _1_12_Class;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            araba arac_1 = new araba("siyah","ford","mustang",2,240);
            araba arac_2 = new araba("kırmızı", "renault", "clio", 4, 180);

           arac_1.Bilgi_goster();

            Console.WriteLine($"2. Aracın markası ve modeli {arac_2.Marka}: {arac_2.Model}");

        }
    }
}