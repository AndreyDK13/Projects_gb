// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 1 | 3 4
// 3 2 1 | 3 3
// _ _ _ | 1 1
// Результирующая матрица будет:
// 19 21
// 16 19


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
            array[i, j] = new Random().Next(0, 9);
        }
    }
    return array;
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

bool Check(int i, int k)
{
    bool check = false;
    if (i == k) check = true;
    return check;
}

int[,] ProductMatrix(int[,] matr1, int[,] matr2)
{
    int[,] productMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int l = 0; l < matr2.GetLength(1); l++)
        {
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                productMatrix[i, l] += matr1[i, j] * matr2[j, l];
            }
        }
    }
    return productMatrix;
}

int Rows1 = Prompt("Input number of 1t array rows >");
int Coloums1 = Prompt("Input number of 1t array coloums >");
int[,] Array1 = FillCreateArray(Rows1, Coloums1);
PrintArrayTwo(Array1);

Console.WriteLine();

int Rows2 = Prompt("Input number of 2d array rows >");
int Coloums2 = Prompt("Input number of 2d array colums >");
int[,] Array2 = FillCreateArray(Rows2, Coloums2);
PrintArrayTwo(Array2);

Console.WriteLine();

bool Checking = Check(Rows1, Coloums2);
if (Checking == true)
{
    Console.WriteLine("The product of matrices is");
    int[,] ProductMatr = ProductMatrix(Array1, Array2);
    Console.WriteLine();
    PrintArrayTwo(ProductMatr);
}
else Console.WriteLine("The product of matrices doesn't exist");
