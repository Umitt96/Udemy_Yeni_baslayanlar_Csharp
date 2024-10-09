// günleri kullanıcıdan al, buna göre bir yorum yap

Console.WriteLine("Bugün günlerden ne?");
string gun = Console.ReadLine();

switch (gun)
{
    case "pazartesi":
        Console.WriteLine("Bugün çok yoğun bir gün, ve enerjim fazla");
        break;

    case "salı":
        Console.WriteLine("Bugün biraz durgun, üzerimde bir rehavet var");
        break;

    case "çarşamba":
        Console.WriteLine("Bugün oldukça dengeli, her şey yolunda gidiyor");
        break;

    case "perşembe":
        Console.WriteLine("Bugün hafif bir stres var, ama hala odaklanabilirim");
        break;

    case "cuma":
        Console.WriteLine("Bugün oldukça heyecan verici, hafta sonu yaklaşıyor");
        break;

    case "cumartesi":
        Console.WriteLine("Bugün rahat ve keyifli, enerjim düşük");
        break;

    case "pazar":
        Console.WriteLine("Bugün huzurlu ve sakin, rahatlama zamanı");
        break;

default:
        Console.WriteLine("Lütfen geçerli bir gün giriniz");
        break;
}
