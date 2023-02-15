// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue- minValue)+ minValue;
        result [i] = Math.Round(result[i], 1);
    }
    return result;
}

double minValueArray(double[] array)
{

    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double maxValueArray(double[] array)
{

    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double DifferenceMinMaxArray(double max, double min)
{
    double result = max - min;
    result =Math.Round(result, 1);
    return result;
}

double[] array = GetArray(5, 1, 99);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");
Console.Write(" -> ");

Console.Write(String.Join(", ", DifferenceMinMaxArray(maxValueArray(array), minValueArray(array))));
Console.WriteLine();