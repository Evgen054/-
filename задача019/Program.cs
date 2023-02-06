// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num3 = num / 100 % 10;
int num4 = num / 10 % 10;
int num5 = num % 10;


if (num > 9999 && num < 100000)
{
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число: ");
}