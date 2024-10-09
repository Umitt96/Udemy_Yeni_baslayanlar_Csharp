using System;
using System.IO;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Okuma (Reading)
            string rd_dosya = "ornek.txt";

            string rd_icerik = File.ReadAllText(rd_dosya);

            Console.WriteLine("Dosyanın içeriği: \n\n" + rd_icerik);


            // Yazma (Writing)
            string wr_dosya_adi = "ornek_2.txt";

            string wr_icerik = "Tu Fui Ego Eris";

            File.WriteAllText(wr_dosya_adi, wr_icerik);
            Console.WriteLine("Dosya başarıyla yazdırıldı!");

            // Silme (Delete)
            File.Delete(wr_dosya_adi);

            // Güncelleme (Update)

            string yeni_icerik = "\n\n- Cem KARACA";

            File.AppendAllText(rd_dosya, yeni_icerik);

            Console.WriteLine("Dosya başarıyla güncellendi!");

        }
    }
}