int N;
Console.Write("Введите N:");
N = int.Parse(Console.ReadLine());

int index;
index = 1;

while (index <= N)
{
  if (index % 2 == 0)
  {
    Console.Write(index + " ");
  }
  index = index + 1;
}
