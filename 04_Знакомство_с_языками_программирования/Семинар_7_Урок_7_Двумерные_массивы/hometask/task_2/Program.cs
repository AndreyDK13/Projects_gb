// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1
// Колонка > 7
// 1, 7 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

double[,] FillArray(double[,] list, int min, int max)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            list[i, j] = Convert.ToDouble(new Random().Next(min*10, max*10)) / 10;
        }
    }
    return list;
}

void Verification (int x, int y, int m, int n, double [,] matr)
{  
    if (x>m+1 || y>n+1)
    {
        Console.WriteLine ("There is no such element");
    }
    else 
    {
        Console.WriteLine ($"Element is {matr[x-1,y-1]}");
    }
}

void PrintArrayTwo(double[,] matr)
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

int M = Prompt("Input number of rows > ");
int N = Prompt("Input number of columns > ");
int minimum = Prompt("Input minimum value > ");
int maximum = Prompt("Input maximum value > ");
double[,] array = new double[M, N];
PrintArrayTwo(FillArray(array, minimum, maximum));
int X = Prompt("Input the row number of searching element > ");
int Y = Prompt("Input the column number of searching element > ");
Verification (X, Y, M, N, array);
