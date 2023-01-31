// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.WriteLine("Введите 3х значное число:");
int num = int.Parse(Console.ReadLine()!);

if (num > 0 && num < 1000)
{
    int n1 = num / 10;
    int n2 = n1 % 10;

    Console.Write($"{num} -> {n2}");
}
else
{
    Console.WriteLine("Введите 3-х значное число");
}
