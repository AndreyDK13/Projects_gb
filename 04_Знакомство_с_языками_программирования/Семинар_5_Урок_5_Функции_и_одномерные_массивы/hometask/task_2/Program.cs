// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int summ(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i+1) % 2 == 1) summ += array[i];
    }
    return summ;
}

int len = Prompt("Input number of array elements > ");
int min = Prompt("Input MIN array element value > ");
int max = Prompt("Input MAX array element value > ");
int[] arr = Generate_Array(len, min, max);
Print_Array(arr);
Console.WriteLine($"SUMM of searching elements is {summ(arr)}");
