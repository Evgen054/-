// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер четверти (от 1 до 4)");
int ch1 = int.Parse(Console.ReadLine()!);
// if (num >= 1 && num <= 4)
// {
//     if (num == 1)
//     {
//         Console.Write("X > 0 и Y > 0");
        
//     }
//     else if (num == 2)
//     {
//         Console.Write("X < 0 и Y > 0");
//     }
//     else if (num == 3)
//     {
//         Console.Write("X < 0 и Y < 0");
//     }
//     else if (num == 4)
//     {
//         Console.Write("X > 0 и Y < 0");
//     }
// }

// else
// {
//     Console.WriteLine("Введите число от 1 до 4");
// }

switch (ch1)
{
    case 1:
        Console.Write("X>0 , Y>0 ");
        break;

    case 2:
        Console.Write("X<0 , Y>0 ");
        break;
    case 3:
        Console.Write("X<0 , Y<0 ");
        break;
    case 4:
        Console.Write("X<0 , Y>0 ");
        break;
    default:
        Console.Write("Ввкдите число от 1 до 4 ");
        break;

}
