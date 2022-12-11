// Задача 2: Задайте двумерный массив. 
// Найдите элементы, у которых обе позиции чётные
// , и замените эти элементы на их квадраты.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1   4  7  2
// 5  81  2  9
// 8   4  2  4

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

int[,] ArrayQuarter(int[,] matr)
{
    for (int i = 1; i < matr.GetLength(0); i=i+2)
    {
        for (int j = 1; j < matr.GetLength(1); j=j+2)
        {
                matr[i, j] = matr[i, j]*matr[i, j];
        }
    }
    return matr;
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

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");

int[,] array = new int[m, n];
PrintArray(FillArray(array));
Console.WriteLine("Update array is ");
PrintArray(ArrayQuarter(array));