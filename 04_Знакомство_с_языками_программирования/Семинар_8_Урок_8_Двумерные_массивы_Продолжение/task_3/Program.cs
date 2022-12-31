// Ввести частотный словарь массива


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

void PrintArrayOne(int[] line)
{
    for (int i = 0; i < line.Length; i++)
    {
        System.Console.WriteLine($"{line[i]}\t");
    }
    System.Console.WriteLine();
}

int[] Dictionary(int[,] array)
{
    int[] Dict = new int[10];
    foreach (var item in array)
    {
        Dict[item]++;
    }
    return Dict;
}


int Rows = Prompt("Input number of rows >");
int Coloums = Prompt("Input number of coloums >");
int[,] Array = FillCreateArray(Rows, Coloums);
PrintArrayTwo(Array);
System.Console.WriteLine();
PrintArrayOne(Dictionary(Array));


