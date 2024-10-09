// minik bir hesap makinesi yap, ve try-catch kullan

try
{
    Console.WriteLine("Bir sayı giriniz");
    int sayi_1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bir sayı daha giriniz");
    int sayi_2 = Convert.ToInt32(Console.ReadLine());

    int sonuc = sayi_1 / sayi_2;
    Console.WriteLine("İşlem sonucu: " + sonuc);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Sıfıra bölme yapamazsınız!");
}

catch (FormatException)
{
    Console.WriteLine("Sadece sayı ifadesi girebilirsiniz! (Yani 'Beş' yazmak bir çözüm değil...)");
}
