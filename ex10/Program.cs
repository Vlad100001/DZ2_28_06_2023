Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n > 99 && n < 1000)
{n = n / 10;
n= n % 10;
Console.WriteLine(n);}
else
Console.WriteLine("ошибка");
    