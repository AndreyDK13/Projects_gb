// Задача 1: задайте двухмерный массивю Напишите программу, которая поменяет местами первую и последнюю строчки массива


int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[,] FillCreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArrayOne(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int[] FirstRowArray(int[,] array)
{
    int[] firstRowArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                firstRowArray[j] = array[i, j];
            }
        }
    }
    return firstRowArray;
}

int[] LastRowArray(int[,] array)
{
    int[] lastRowArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == array.GetLength(1) - 1)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                lastRowArray[j] = array[i, j];
            }
        }
    }
    return lastRowArray;
}

int[,] ChangeRowsArray(int[,] array, int[] firstRow, int[] lastRow)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) array[i, j] = lastRow[j];
            else if (i == array.GetLength(1)-1) array[i, j] = firstRow[j];
        }
    }
    return array;
}


int Rows = Prompt("Input number of rows >");
int Coloums = Prompt("Input number of coloums >");
int[,] Array = FillCreateArray(Rows, Coloums);
PrintArray(Array);

int[] firstRowArr = FirstRowArray(Array);
Console.WriteLine(); 
Console.WriteLine("The first row >>>>>");
PrintArrayOne(firstRowArr);

int[] lastRowArr = LastRowArray(Array);
Console.WriteLine(); 
Console.WriteLine("The last row >>>>>");
PrintArrayOne(lastRowArr);

Console.WriteLine();
Console.WriteLine("The new array >>>>>");
PrintArray(ChangeRowsArray(Array, firstRowArr, lastRowArr));