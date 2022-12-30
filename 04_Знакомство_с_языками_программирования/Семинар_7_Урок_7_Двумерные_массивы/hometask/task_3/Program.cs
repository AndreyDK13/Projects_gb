// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[,] FillArray(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            list[i, j] = new Random().Next(1, 10);
        }
    }
    return list;
}

void PrintArrayTwo(int[,] matr)
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

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
    }
    System.Console.WriteLine();
}

double[] Average(int[,] matr)
{
    double[] list = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            summ = summ + matr[i, j];
        }
        // Console.Write($"{summ / matr.GetLength(0)}\t");
        double avg = summ / matr.GetLength(0);
        list[j] = avg;
    }
    return list;
}


int R = Prompt("Input the number of rows > ");
int C = Prompt("Input the number of columns > ");
int[,] array = new int[R, C];
PrintArrayTwo(FillArray(array));
Console.WriteLine("Averages: ");
PrintArray(Average(array));
