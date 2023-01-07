// Задача *: Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
// Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int Lenght, int minRange, int MaxRange)
{
    int[] array = new int[Lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, MaxRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int MaxValue(int[] array, int minRange)
{
    int max = minRange;
    int max2 = minRange;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max2 = max;
            max = array[i];
        }
        else if (array[i] >= max2 && array[i] < max)
        {
            max2 = array[i];
        }
    }
    return max2;
}


int Lenght = Prompt("Input array lenght ");
int Min_value = Prompt("Input Min_value ");
int Max_value = Prompt("Input Max_value ");
int[] arr = GenerateArray(Lenght, Min_value, Max_value);
PrintArray(arr);
Console.WriteLine($"Second Max value is {MaxValue(arr, Min_value)}");

