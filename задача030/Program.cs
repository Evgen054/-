// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

void FillArray(int[] col)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
    {
        col[index] = new Random().Next(0,2);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.Write(collection[index]);
        Console.Write(" ");
        index++;
    }
}


int[] array = new int[8];

FillArray(array);
PrintArray(array);

