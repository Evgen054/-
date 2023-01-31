// // Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.  
//  • 5, 25  ->  да  
//  • -4, 16  ->  да 
//   • 25, 5  ->  да  
//   • 8,9  ->  нет

Console.Clear();
Console.WriteLine("Enter Number 1: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Number 2: ");
int n2 = int.Parse(Console.ReadLine()!);
int sqr1 = n1 * n1;
int sqr2 = n2 * n2;
if (sqr1 == n2 || sqr2 == n1)
{
    Console.WriteLine($"OK!");
}
else
{
    Console.WriteLine($"bad!");
}
