Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
int y = 0;

if ((x+y)%2 == 0)
{
 y = x/2;
 Console.Write($"Число {x} является ЧЕТНЫМ");
}
else
{
 Console.Write($"Число {x} является НЕЧЕТНЫМ");
}

