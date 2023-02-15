// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}

int CountElement(int[] array)
{
  int count = 0;
  foreach(int el in array)
  {
    if (el > 10 && el < 100)
    {
        count++;
    }
  }
  return count;
}

int[] array = GetArray(8, 0, 123);
Console.Write(String.Join(", ", array));
Console.Write(" -> ");
int result = CountElement(array);
Console.Write(result);