// Напишите программу, которая выводит 
// массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



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
    for (int j=0;j<array.Length; j++)
    {
        Console.WriteLine(array[j]);    
    }
}

int Lenght = Prompt ("Input array lenght ");
int Min_value = Prompt ("Input Min_value ");
int Max_value = Prompt ("Input Max_value ");
int [] arr = Generate_Array(Lenght, Min_value, Max_value);
Print_Array (arr);


// Console.WritLine($"{array}");
