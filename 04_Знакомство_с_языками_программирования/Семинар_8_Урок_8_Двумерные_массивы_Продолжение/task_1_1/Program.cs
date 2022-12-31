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

int[,] ReplaceRows(int[,] list)
{
    for (int j = 0; j < list.GetLength(1); j++)
    {
        int lastRow = list.GetLength(0) - 1;
        int Number = list[0, j];
        list[0, j] = list[lastRow, j];
        list[lastRow, j] = Number;
    }
    return list;
}


int Rows = Prompt("Input number of rows >");
int Coloums = Prompt("Input number of coloums >");
int[,] Array = FillCreateArray(Rows, Coloums);
PrintArray(Array);
Console.WriteLine("Replace First and Last rows of array >>>");
PrintArray(ReplaceRows(Array));