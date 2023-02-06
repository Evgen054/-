// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Ввседите x0");
int x0 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввседите x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввседите y0");
int y0 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввседите y1");
int y1 = int.Parse(Console.ReadLine()!);

double A = Math.Pow(x1 - x0, 2);
double B = Math.Pow(y1 - y0, 2);

double C = Math.Sqrt(A + B);
double R = Math.Round(C,2);


Console.Write($"A ({x0},{x1}); B ({y0},{y1}) -> {R}");