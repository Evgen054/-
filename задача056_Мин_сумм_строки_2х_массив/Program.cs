// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7
Console.Clear();

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
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
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void NumberRowMinSumElements(int[,] array)
{
    int sumOneRow = 0;
    int minSumRow = 0;
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sumOneRow += array[0, i];
    }
    Console.WriteLine();
    // Console.Write($"Сумма первой строки: {sumOneRow}");


    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
            temp += array[i, j];
        if (temp < sumOneRow)
        {
            sumOneRow = temp;
            minSumRow = i;
        }

        temp = 0;
    }
    Console.WriteLine();
    Console.Write($"строка с минимальным значение: {minSumRow + 1}");
}


Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, 0, 9);
PrintArray(array);

Console.WriteLine();

NumberRowMinSumElements(array);

