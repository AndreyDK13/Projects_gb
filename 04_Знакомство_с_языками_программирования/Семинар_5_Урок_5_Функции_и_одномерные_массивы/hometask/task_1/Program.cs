// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Заменил на кратно заданному числу




int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}


int[] Generate_Array(int Lenght, int minRange, int MaxRange)
{
    int[] array = new int[Lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, MaxRange + 1);
    }
    return array;
}

void Print_Array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + "\t");
    }
}

int Counter(int[] array, int divider)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % divider == 0) counter++;
    }
    return counter;
}

int len = Prompt("Input number of array elements > ");
int min = Prompt("Input MIN array element value > ");
int max = Prompt("Input MAX array element value > ");
int[] arr = Generate_Array(len, min, max);
Print_Array(arr);
int div = Prompt("Input Divider > ");
Console.Write($"Count is > {Counter(arr, div)}");
