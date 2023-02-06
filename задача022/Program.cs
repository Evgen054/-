// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.Clear();
Console.WriteLine("Ввседите число");
int num = int.Parse(Console.ReadLine()!);
int index = 1;
int k = 1;
Console.Write($"{num} ->");
while (index <= num)
{
    k = index * index;
    Console.Write($" {k}");
    if (index != num)
    {
        Console.Write($", ");
    }
    index++;
}