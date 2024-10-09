// ATM sistemini taklit eden bir proje yapacağız.

int pin = 1234;
int curr_attempts = 0;
int max_attempts = 3;
decimal balance = 12000m;


//mevcut deneme, max denemeden fazla değilse sürekli çalışsın
while( curr_attempts < max_attempts)
{
    Console.WriteLine("PIN kodunuzu giriniz: ");
    int input_pin = Convert.ToInt32(Console.ReadLine());

    if(input_pin == pin)
    {
        Console.Clear();
        bool is_exit = false;

        while(!is_exit)
        {
            Console.WriteLine("----- ATM Ana Menü -----");
            Console.WriteLine("1. Bakiye Sorgulama");
            Console.WriteLine("2. Para Ekleme");
            Console.WriteLine("3. Para Çekme");
            Console.WriteLine("4. Çıkış");

            Console.WriteLine("Bir seçenek girin (1-4)");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1: Console.WriteLine("Mevcut bakiyeniz " + balance + " TL"); break;
                case 2:
                    Console.WriteLine("Eklenecek bakiyeyi giriniz: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());

                    balance += deposit;
                    Console.WriteLine("Güncellenen bakiyeniz " + balance + " TL");
                    break;

                case 3:
                    Console.WriteLine("Ne kadar para çekeceksiniz: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());

                    if(withdraw < balance)
                    {
                        balance -= withdraw;
                        Console.WriteLine("İşlem başarılı! Güncellenen bakiyeniz " + balance + " TL");
                    }
                    else
                    {
                        Console.WriteLine("Bakiye yetersiz!");
                    }

                    break;

                case 4:
                    Console.WriteLine("Programdan çıkış yapılıyor...");
                    is_exit = true;
                    break;
            }

            if (!is_exit)
            {
                Console.WriteLine("Bir tuşa basarak ana menüye dönün...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    else
    {
        curr_attempts++;
        if(curr_attempts < max_attempts)
        {
            Console.WriteLine($"Hatalı PIN! Kalan deneme sayısı: {max_attempts - curr_attempts}");
        }
        else
        {
            Console.WriteLine("Hesabınız kilitlendi! Daha fazla deneme yapamazsınız");
        }
    }
}