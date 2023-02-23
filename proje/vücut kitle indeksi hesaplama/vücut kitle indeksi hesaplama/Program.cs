double boy;
double ağırlık;
double vki;
Console.WriteLine("boyu metre cinsinden girin");
bool cevap1 = double.TryParse(Console.ReadLine(), out boy);
Console.WriteLine("ağırlığı kg cinsinden girin");
bool cevap2 = double.TryParse(Console.ReadLine(), out ağırlık);

while (cevap1 == false || cevap2 == false)

{
    Console.WriteLine("sayı girin");
    cevap1 = double.TryParse(Console.ReadLine(), out boy);
    cevap2 = double.TryParse(Console.ReadLine(), out ağırlık);
    continue;
}
while (boy>=3)
{
    Console.WriteLine("metre cinsinden giriniz");
    cevap1 = double.TryParse(Console.ReadLine(), out boy);

    continue;
}
do
{

    vki = ağırlık / (boy * boy);

    if (vki>18 && vki<25)

    {
        Console.WriteLine("vücut kitle indeksi normaldir");
        break;
    }
    else if (vki>25&& vki<30)
    {
        Console.WriteLine("vücut kitle indeksi kilolu");
        break;
    }
    else if (vki>30)
    {
        Console.WriteLine("vücut kitle indeksi obez");
        break;
    }
    else if (vki>35)
    {
        Console.WriteLine("vücut kitle indeksi ciddi obez");
        break;
    }
    else
    {
        Console.WriteLine("vücut kitle indeksi tıp tanımlamalarına girmez");
        break;
    }
} while (boy>0&&boy<3);

