using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string dosya = "notlarım.txt";

        if (!File.Exists(dosya))
        {
            File.Create(dosya).Close();
        }

        bool is_exit = false;

        while (!is_exit)
        {
            string[] notlar = File.ReadAllLines(dosya);

            Console.Clear();
            Console.WriteLine("----- Not Defteri Menüsü -----");
            Console.WriteLine("1. Not Ekleme");
            Console.WriteLine("2. Not Listesi");
            Console.WriteLine("3. Not Silme");
            Console.WriteLine("4. Çıkış");
            Console.Write("Bir seçenek girin (1-4): ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Lütfen notunuzu giriniz:");
                    string yeni_not = Console.ReadLine();

                    File.AppendAllText(dosya, yeni_not + Environment.NewLine);
                    Console.WriteLine("Not başarıyla eklendi!");
                    break;

                case 2:
                    if (notlar.Length == 0)
                    {
                        Console.WriteLine("Herhangi bir not bulunmuyor.");
                    }
                    else
                    {
                        Console.WriteLine("-----Notların Listesi------");
                        for (int i = 0; i < notlar.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {notlar[i]}");
                        }
                    }
                    break;

                case 3:
                    if (notlar.Length == 0)
                    {
                        Console.WriteLine("Silinecek not bulunmuyor.");
                    }
                    else
                    {
                        Console.WriteLine("Silmek istediğiniz notun numarasını girin:");
                        for (int i = 0; i < notlar.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {notlar[i]}");
                        }

                        int silmeSecim = Convert.ToInt32(Console.ReadLine());

                        if (silmeSecim > 0 && silmeSecim <= notlar.Length)
                        {
                            // Notu listeden çıkarıyoruz
                            List<string> notlarList = new List<string>(notlar);
                            notlarList.RemoveAt(silmeSecim - 1);

                            // Dosyayı yeniden yazıyoruz
                            File.WriteAllLines(dosya, notlarList.ToArray());
                            Console.WriteLine("Not başarıyla silindi!");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim.");
                        }
                    }
                    break;

                case 4:
                    is_exit = true;
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen 1-4 arasında bir değer girin.");
                    break;
            }

            if (!is_exit)
            {
                Console.WriteLine("Ana menüye dönmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }
}