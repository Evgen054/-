// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.Write("Введите число C: ");
int C = int.Parse(Console.ReadLine()!);

bool CheckTriangele(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

if (CheckTriangele(A,B,C))
{
    Console.WriteLine("Да");
}
else
{
      Console.WriteLine("Нет");
}