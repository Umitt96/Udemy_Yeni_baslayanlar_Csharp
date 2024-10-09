// While döngüsü örnek

/*
string selam = "Merhaba C#";
bool oldu_mu = true;

while (oldu_mu)
{
    Console.WriteLine(selam);
    Console.WriteLine("Ben Ritalin");
}
*/
// Do While döngüsü

/*
int sayi = 5;

do
{
    Console.WriteLine("1 ile 10 arasında bir sayı giriniz");
    sayi = Convert.ToInt32(Console.ReadLine());
}

while (sayi < 1 || sayi > 10);
Console.WriteLine("Geçerli bir sayı girdiniz: " + sayi);
*/

// For döngüsü

/*
for (int i = 1; i <= 10; i++) {

    Console.Write(i + " ");
}


for(int i = 0; i <= 20; i += 2)
{
    Console.WriteLine(i);
}
*/

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + " sayısının karesi: "+ i*i);
}