// Задача 2: задайте двухмерный массив. Напишите программу, которая заменяет строки на столбцы
// Если это невозможно - прграмма выводит сообщение для пользователя



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

void CheckAndPrint(int[,] list)
{
    if (list.GetLength(0) != list.GetLength(1)) Console.WriteLine("Error");
    else
    {
        Console.WriteLine("Reverse Array>>>>>");
        PrintArray(list);
    }
}

int[,] ReverseArray(int[,] list)
{
    int[,] reverse = new int[list.GetLength(1), list.GetLength(0)];
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            reverse[j,i] = list[i, j];
        }
    }
    return reverse;
}


int Rows = Prompt("Input number of rows >");
int Coloums = Prompt("Input number of coloums >");
int[,] Array = FillCreateArray(Rows, Coloums);
PrintArray(Array);
int[,] Reverse = ReverseArray(Array);
CheckAndPrint(Reverse);
