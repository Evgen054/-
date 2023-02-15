// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();
int[] arrayFib(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i<array.Length; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
    return array;
}

Console.Write("Enter your Number: ");
int nFib = int.Parse(Console.ReadLine()!);
Console.Write(string.Join(", ", arrayFib(nFib)));






// Console.Clear();

// Console.Write("Введите число А: ");
// int num = int.Parse(Console.ReadLine()!);

// int[] NumFib(int num)
// {
//     int[] result = new int[num];
//     int temp = 1;
//     for (int i = 0; i < num; i++)
//     {
//         result[i] = temp + result[i];
//         temp = result[i];
//     }
//     return result;
// }

// int[] array = NumFib(num);

// void Print(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
// }

// Print(array);