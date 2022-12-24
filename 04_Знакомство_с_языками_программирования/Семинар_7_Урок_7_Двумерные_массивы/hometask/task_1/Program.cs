// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


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

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");
int minimum = Prompt("Введите количество строк > ");
int maximum = Prompt("Введите количество строк > ");
double[,] array = new double[m, n];
PrintArrayTwo(FillArray(array, minimum, maximum));
