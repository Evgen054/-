// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите 3х значное число:");
int num = int.Parse(Console.ReadLine()!);
int k = 10;
int n = num;
while (num > 999)
{
    num = num / 10;
}
k = num % 10;
if (num < 100)
{
    Console.WriteLine($"{n} -> третьей цифры нет");
}
else
{
    Console.WriteLine($"{n} -> {k}");
}




