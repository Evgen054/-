// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int SumNun(int A)
{
    int count = 0;
    while (A != 0)
    {
        A = A / 10;
        count++;
    }
    return count;

}


Console.Clear();
Console.WriteLine("Введите число N:");
int num = int.Parse(Console.ReadLine()!);

int B = SumNun(num);
Console.Write($"{num} -> {B}");