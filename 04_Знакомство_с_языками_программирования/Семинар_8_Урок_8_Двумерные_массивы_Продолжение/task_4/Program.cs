// Вывести двухмерный массивУбрать из него столбец и строку, которые пересекаются на минимальном элементе

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

(int I, int J) MinElementIJ(int[,] matr)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[minI,minJ] > matr[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    return (minI, minJ);
}

int [,] DeleteMinIJ(int[,] matr, int I, int J)
{
    int[,] newArray = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i<I && j<J)
            {
                newArray[i, j] = matr[i,j];
            }
            else if (i<I && j>J)
            {
                newArray[i, j-1] = matr[i,j];
            }           
            else if (i>I && j<J)
            {
                newArray[i-1, j] = matr[i,j];
            }     
            else if (i>I && j>J)
            {
                newArray[i-1, j-1] = matr[i,j];
            }                             
        }
    }
    return newArray;    
}


int Rows = Prompt("Input number of rows >");
int Coloums = Prompt("Input number of coloums >");
int[,] Array = FillCreateArray(Rows, Coloums);
(int A, int B) = MinElementIJ (Array);
PrintArrayTwo(Array);
System.Console.WriteLine();
PrintArrayTwo(DeleteMinIJ(Array, A, B));