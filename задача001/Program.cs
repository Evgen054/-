// Задача №1. Напишите программу, которая на вход
// принимает два числа и проверяет, является ли первое
// число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Введите число_1");
int num1 = Convert.ToInt32((Console.ReadLine()));

Console.WriteLine("Введите число_2");
int num2 = Convert.ToInt32((Console.ReadLine()));

// int qr = num2 * num2;

double qr = Math.Pow(num2, 2);
if (qr == num1)
{
    Console.WriteLine($"Число {num1} является квадратом числа {num2}");
}
else
{
    Console.WriteLine("Нет не является");
}