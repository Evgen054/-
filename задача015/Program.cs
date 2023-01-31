// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7");
int num = int.Parse(Console.ReadLine()!);
if (num > 0 && num < 6)
{
    Console.Write($"{num} -> нет");
}

if (num > 5 && num < 8)
{
    Console.Write($"{num} -> да");
}

if (num < 0 || num > 7)
{
    Console.WriteLine("Введите цифру от 1 до 7");
}