// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5




int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int Counter(int number)
{
    int count = 0;
    while (number > 0)
        {
            count ++;
            number /=10;
        }
    return count;
}

int number = Prompt ("Input number ");
Console.WriteLine($"Count of digits in {number} = {Counter(number)}");