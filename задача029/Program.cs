// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] FillArray()
{
    int[] array = new int[9];
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
    return array;
}

void PrintArray(int[] number)
{
    int lenght = number.Length;
    int index = 0;

    while (index < lenght)
    {
        Console.Write(number[index]);
        if (index != lenght - 1)
        {
            Console.Write(", ");
        }

        index++;
    }
   
}

void IfPrintArray(int[] number)
{
    int lenght = number.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.Write(number[index]);
        if (index != lenght - 1)
        {
            Console.Write(", ");
        }

        index++;
    }
}


int[] array = FillArray();
IfPrintArray(array);
Console.Write(" -> ");
PrintArray(array);