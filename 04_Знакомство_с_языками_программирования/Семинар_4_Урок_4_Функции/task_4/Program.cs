// Задача *: Напишите программу
// , которая из массива случайных чисел. 
// Ищет второй максимум 
// (число меньше максимального элемента
// , но больше всех остальных). 
// Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5



int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}


int [] Generate_Array (int Lenght, int minRange, int MaxRange)
{
    int []array = new int [Lenght];
    for (int i = 0;i<array.Length;i++)
    {
        array [i] = new Random().Next(minRange,MaxRange+1);
    }
    return array;
}

void Print_Array (int [] array)
{
    for (int i=0;i<array.Length; i++)
    {
        Console.WriteLine(array[i]);    
    }
}

int max_value (int[] array)
{
    int max_value_1 = array [0];
    int max_value_2 = array [0];
    for (int i=1;i<array.Length;i++)
    {
        if (max_value_1 < array [i])
        {
            max_value_1 = array [i];
        }
    }
    for (int i=1;i<array.Length;i++)
    {
        if (array [i] == max_value_1)
        {
            continue;
        }
        if (max_value_2 < array [i])
        {
             max_value_2 = array [i];
        }
    }
    return max_value_2;
}

int Lenght = Prompt ("Input array lenght ");
int Min_value = Prompt ("Input Min_value ");
int Max_value = Prompt ("Input Max_value ");
int [] arr = Generate_Array(Lenght, Min_value, Max_value);
Print_Array (arr);
Console.WriteLine ($"Second Max value is {max_value (arr)}");

// Console.WritLine($"{array}");

// int max_value (int[] array)
// {
//     int max_value = array [0];
//     for (int i=1;i<array.Length;i++)
//     {
//         if (max_value < array [i])
//         {
//             max_value = array [i];
//         }
//     }
//     return max_value;
// }