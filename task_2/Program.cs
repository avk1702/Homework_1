int a, b, c, max;
Console.WriteLine("Введите a:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c:");
c = int.Parse(Console.ReadLine());
max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.Write(max);
