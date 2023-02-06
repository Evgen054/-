// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int SunF(int A)
{
    int count = 1;
    int prod = 1;
    while (count <= A)
    {
        prod = prod * count;
        count++;
    }
    return prod;
}

int N = SunF(num);

Console.WriteLine($"{num} -> {N}");