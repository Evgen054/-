/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNM(int n, int m)
{
    int res = n;
    if (n == m)
        return 0;
    else
    {
        n++;
        res = n + SumNM(n, m);
        return res;
    }
}

void SumFromMToN(int n, int m)
{
    Console.Write(SumNM(n - 1, m));
}


Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

SumFromMToN(n, m);