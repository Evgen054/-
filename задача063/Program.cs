// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = 9;
int count = 5;

void NaturNumber(int n, int count)
{
    int temp = n;
    if (n < count)
    {
        return;
    }
    else
    {
        NaturNumber(n - 1, count);


        Console.Write(n);
        Console.Write(" ");

    }

}


NaturNumber(n, count);