// // Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)




int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int [] GenerateArray (int Lenght, int minRange, int MaxRange)
{
    int []array = new int [Lenght];
    for (int i = 0;i<array.Length;i++)
    {
        array [i] = new Random().Next(minRange,MaxRange+1);
    }
    return array;
}

void PrintArray (int [] array)
{
    for (int i=0;i<array.Length; i++)
    {
        Console.Write($"{array[i]}, ");    
    }
}

int Lenght = Prompt ("Input array lenght ");
int Min_value = Prompt ("Input Min_value ");
int Max_value = Prompt ("Input Max_value ");
int [] arr = GenerateArray(Lenght, Min_value, Max_value);
PrintArray (arr);
