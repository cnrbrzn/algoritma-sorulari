// See https://aka.ms/new-console-template for more information
Console.Write("Pozitif bir sayı giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Pozitif bir sayı giriniz: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n + " adet pozitif sayı giriniz: ");
List<int> l = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();
foreach(var item in l)
{
        if(item==m || item%m==0)
        Console.Write(item+" ");
}