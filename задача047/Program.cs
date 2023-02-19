// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] GetArray(int row, int col, double minValue, double maxValue)
{
    double[,] array = new double[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
            array[i,j]= Math.Round(array[i,j], 1);
            
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

Console.Clear();
Console.WriteLine("Введите количество строк маcсива: ");
int row = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество cтолбцов маcсива: ");
int col = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(row, col, 0, 99);

PrintArray(array);
