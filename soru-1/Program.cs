// See https://aka.ms/new-console-template for more information
Console.Write("Pozitif bir sayı giriniz: ");
int n = Convert.ToInt32(Console.ReadLine().Trim());
Console.WriteLine(n + " adet pozitif sayı giriniz: ");
List<int> m = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();
foreach(var item in m)
{
        if(item%2==0)
        Console.Write(item+" ");
}