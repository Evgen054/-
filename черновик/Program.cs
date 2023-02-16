// //Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// //Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return result;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}");
//         if (i != array.Length-1)
//         {
//             Console.Write(", ");
//         }
//     }
// }

// int[] array = GetArray(12, -9, 10);
// // PrintArray(array);

// Console.Write(String.Join(", ", array));

// int positiveSum = 0;
// int negativeSum = 0;
// foreach(int el in array)
// {
//     positiveSum += el > 0 ? el : 0;
//     negativeSum += el < 0 ? el : 0;
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма  положительных элементов равно: {positiveSum}");
// Console.WriteLine($"Сумма  отрицательных элементов равно: {negativeSum}");


// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }
//     return result;
// }

// void SigChange(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
// }

// int[] array = GetArray(5, -10, 15);
// Console.Write(String.Join(", ", array));
// Console.Write("  ->  ");
// SigChange(array);
// Console.Write(String.Join(", ", array));


// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }
//     return result;
// }

// bool GetResult(int[] array, int number)
// {
//     foreach (int el in array)
//     {
//         if (el == number)
//         {
//             return true;
//         }
//     }
//     return false; 
// }

// int[] array = GetArray(5, -10, 99);
// Console.Write(String.Join(", ", array));

// Console.WriteLine();
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if (GetResult(array, n))
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }



// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// int[] array = GetArray(123, -99, 99);
// Console.Write(String.Join(", ", array));

// int DiapozonArray(int[] array)
// {
//     int diapozon = 0;
//     foreach (int el in array)
//     {
//         if (el > 10 && el < 99)
//         {
//             diapozon++;
//         }
//     }
//     return diapozon;
// }
// Console.WriteLine();
// Console.WriteLine();
// int res = DiapozonArray(array);
// Console.Write(res);



// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// int[] array = GetArray(5, 1, 9);
// Console.Write(String.Join(", ", array));

// int SumArray(int[] array)
// {
//     if (array.Length % 2 == 0)
//     {
//         int result = 0;
//         for (int i = 0; i < array.Length / 2; i++)
//         {
//             result = i * i - 1;
//             Console.Write(result);
//         }
//     }
// }

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)