// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Enter Number1: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Number2: ");
int n2 = int.Parse(Console.ReadLine()!);
int rest = n2 % n1;
if (rest == 0)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
    Console.WriteLine($"The rest is {rest} ");
}