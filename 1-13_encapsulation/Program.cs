using _1_13_encapsulation;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba araba = new araba();
            araba.Motor_acik();
            araba.Hizlan(100);
            araba.Hizlan(100);
            araba.Hizlan(100);
            araba.Hizlan(100);

            Console.WriteLine("Mevcut hız: "+ araba.Hizi_goster() +" km / h");

            araba.Motor_kapali();

        }
    }
}