﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
        return position;
    }
}

int[] array = new int[10]; // new int[10] Создай новй массив в котором будет 10 элементов.

FillArray(array);// Случайные числа массива 
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 4);
Console.WriteLine(pos);

// не работает :(