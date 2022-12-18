// // Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр. 
// Использовать рекурсию.
// // 453 -> 12
// // 45 -> 9



int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SummNumbers(int number)
{
    if (number ==0)
    {
        return 0;
    }
    return number%10 + SummNumbers(number / 10);
}

int number = Prompt("Введите число ");
System.Console.Write(SummNumbers(number));