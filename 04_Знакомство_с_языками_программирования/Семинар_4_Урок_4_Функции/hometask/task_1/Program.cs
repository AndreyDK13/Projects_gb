// // Задача 1: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Реализовать через функции.



int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int NumberInPower (int number, int power)
{
    int result = 1;
    for (int i=1; i <= power; i++)
    {
        result *= number;
    }
    // Console.WriteLine($"{number} to the power of {power} is {result}");
    return result;
}

int A = Prompt("Input A ");
int B = Prompt("Input B ");
Console.WriteLine($"{A} to the power of {B} is {NumberInPower(A, B)}");