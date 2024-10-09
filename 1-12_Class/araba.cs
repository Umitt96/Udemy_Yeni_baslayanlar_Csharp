using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1_12_Class
{
    class araba
    {
        public string Renk;
        public string Marka;
        public string Model;
        public int Kapi_sayisi;
        public int Max_hiz;


        //Constructor metot
        public araba(string renk, string marka, string model, int kapi_sayisi, int max_hiz)
        {
            this.Renk = renk;
            this.Marka = marka;
            this.Model = model;
            this.Kapi_sayisi = kapi_sayisi;
            this.Max_hiz = max_hiz;
        }

        public void Bilgi_goster()
        {
            Console.WriteLine($"Araba Bilgisi: \nRenk - {Renk}, \nModel - {Model}, \nKapı - {Kapi_sayisi}, " +
                                $"\nHız - {Max_hiz} km/h");
        }
    }

}
