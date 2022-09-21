Console.Write("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
int y = 0;
int one = 0;

if (x>100)
{
 y = x % 100;
 one = (x - y) / 100;
 Console.WriteLine($"Первая цифра введенного числа равна {one}");
}
