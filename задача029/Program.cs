// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

void FillArray(int[] num)
{
    int lenght = num.Length;
    int index = 0;
    while (index < lenght)
    {
        num[index] = new Random().Next(1, 9);
        index++;
    }
}

void PrintArray(int[] number)
{
    int lenght = number.Length;
    int index = 0;
    Console.Write("[");
    while (index < lenght)
    {
        Console.Write(number[index]);
        if (index != lenght - 1)
        {
            Console.Write(", ");
        }

        index++;
    }
    Console.Write("]");
}

void IfPrintArray(int[] number)
{
    int lenght = number.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.Write(number[index]);
        if (index != lenght - 1)
        {
            Console.Write(", ");
        }

        index++;
    }
}

int[] array = new int[8];

FillArray(array);
IfPrintArray(array);
Console.Write(" -> ");
PrintArray(array);