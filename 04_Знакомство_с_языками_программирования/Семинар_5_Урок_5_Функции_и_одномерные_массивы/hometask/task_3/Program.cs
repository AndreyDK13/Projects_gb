// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}


double [] Generate_Array (int Lenght, int minRange, int MaxRange)
{
    double []array = new double [Lenght];
    for (int i = 0;i<array.Length;i++)
    {
        array [i] = new Random().Next(minRange,MaxRange+1);
    }
    return array;
}

void Print_Array (double [] array)
{
    for (int i=0;i<array.Length; i++)
    {
        Console.WriteLine(array[i]);    
    }
}

double Searching_max (double[] array)
{
    double max = array [0];
    for (int i=1;i<array.Length;i++)
    {
        if (max < array [i]) max = array [i];
    }
    return max;
}

double Searching_min (double[] array)
{
    double min = array [0];
    for (int i=1;i<array.Length;i++)
    {
        if (min > array [i]) min = array [i];
    }
    return min;
}

double diff_max_min (double min, double max)
{
    double diff = max - min;
    return diff;
}

int Lenght = Prompt ("Input array lenght ");
int Min_value = Prompt ("Input Min_value ");
int Max_value = Prompt ("Input Max_value ");
double [] arr = Generate_Array(Lenght, Min_value, Max_value);
Print_Array (arr);
Console.WriteLine ($"MAX value = {Searching_max (arr)}");
Console.WriteLine ($"MIN value = {Searching_min (arr)}");
Console.WriteLine ($"Diff between MAX and MIN = {diff_max_min(Searching_min (arr), Searching_max (arr))}");