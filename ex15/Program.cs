Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблиись!\nВведите номер дня недели: ");
    n = int.Parse(Console.ReadLine()!);
}
if (n < 1 || n > 5)
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");
