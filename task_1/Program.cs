int a, b, max;
Console.WriteLine("Введите a:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
b = int.Parse(Console.ReadLine());
if (a > b)
{
  max = a;
}
else
{
  max = b;
}
Console.Write("max = ");
Console.Write(max);