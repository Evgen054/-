// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void ReturnValueElement(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int lengthR = array.GetLength(0) - 1;
        int lengthC = array.GetLength(1) - 1;
        if (a > lengthR || b > lengthC || a <= 0 || b <= 0)
        {
            Console.Write($"{a + 1}{b + 1} -> Такого числа нет");
            break;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                Console.Write($"[Элемент найден -> {array[i, j]}");
                break;
            }
        }
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение элемента строки: ");
int elementRow = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите значение элемента строки: ");
int elementCol = int.Parse(Console.ReadLine()!) - 1;

int[,] array = GetArray(row, col, -10, 10);

PrintArray(array);

ReturnValueElement(array, elementRow, elementCol);

