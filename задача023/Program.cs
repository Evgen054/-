// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число (N)");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
double result = 1;
Console.Write($"{N} -> ");
while (count <= N)
{
    result = Math.Pow(count, 3);
    Console.Write($"{result}");
    if (count != N)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
    count++;
}