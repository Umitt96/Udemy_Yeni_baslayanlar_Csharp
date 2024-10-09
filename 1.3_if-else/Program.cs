
// kullanıcıdan bir sayı girdisi al 
// Eğer girilecek sayı, 60 'tan büyükse ekranda "KAZANDIN" yazsın

Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());


if(sayi >= 60)
{
    Console.WriteLine("KAZANDIN!");
}

// Eğer 50'tan küçükse, "KAYBETTİN!" yazsın

else if (sayi <= 50)
{
    Console.WriteLine("KAYBETTİN!");
}

else
{
    Console.WriteLine("BU ARALIKTA ÇALIŞACAK BİR KOD YOK!");
}