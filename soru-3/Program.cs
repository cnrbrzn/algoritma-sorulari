// See https://aka.ms/new-console-template for more information
Console.Write("Pozitif bir sayı giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n + " adet kelime giriniz: ");
List<string> l = Console.ReadLine().TrimEnd().Split(' ').ToList();
l.Reverse();
foreach(var item in l)
{
        Console.Write(item + " ");
}