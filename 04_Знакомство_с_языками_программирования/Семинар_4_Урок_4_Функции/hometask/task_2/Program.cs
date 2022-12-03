// // Задача 2: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе. 
// Реализовать через функции.



int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits (int number)
{
    int result = 0;
    int num = number;
    while (num > 0)
    {
        result += num%10;
        num /= 10;
    }
    return result;
}

int number = Prompt("Input number ");
Console.WriteLine($"Sum of dights in number {number} is {SumOfDigits(number)}");