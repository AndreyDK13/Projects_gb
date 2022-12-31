// Задача 5: * Найдите максимальное значение в матрице по каждой строке
// , получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке
// ,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2


int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[,] GenerateArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


int SumMaxInRows(int[,] arr)
{
    int SumMax = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int Max = arr[i,1];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (Max<arr[i,j]) Max = arr[i,j];
        }
        SumMax = SumMax+Max;
    }
    return SumMax;
}

int SumMinInColumns(int[,] arr)
{
    int SumMin = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int Min = arr[1,j];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (Min>arr[i,j]) Min = arr[i,j];
        }
        SumMin = SumMin+Min;
    }
    return SumMin;
}

int Diff(int SumMaxInRows, int SumMinInColumns)
{
    int diff = SumMaxInRows - SumMinInColumns;
    return diff;
}


int rows = Prompt("Input number of rows > ");
int columns = Prompt("Input number of columns > ");
int minimum = Prompt("Input minimum of array > ");
int maximum = Prompt("Input maximum of array > ");
int[,] array = GenerateArray(rows, columns, minimum, maximum);
PrintArray(array);
Console.WriteLine ($"{SumMaxInRows(array)} - {SumMinInColumns(array)} = {Diff(SumMaxInRows(array),SumMinInColumns(array))}");

