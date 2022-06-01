// See https://aka.ms/new-console-template for more information
int kelime=0;
int harf=0;
Console.Write("Bir cümle giriniz: ");
List<string> cumle = Console.ReadLine().TrimEnd().Split(' ').ToList();
foreach(var item in cumle)
{
        kelime++;
        harf +=item.Length;
}
Console.WriteLine("Kelime Sayısı :"+kelime);
Console.WriteLine("Harf Sayısı :"+harf);