// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);

string ConvertDecToBin(int num)
{
    string result = string.Empty;

    while (num != 0)
    {
        result = (num % 2).ToString() + result;
        num /= 2;
    }
    return result;

}

Console.Write(ConvertDecToBin(A));
