// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumRes(int n)
{
    int num = 0;
    while (n > 0)
    {
        num = num + n % 10;
        n = n / 10;
       
    }
    return num;
}

Console.Clear();

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int result = SumRes(A);
Console.Write($"{A} -> {result}");