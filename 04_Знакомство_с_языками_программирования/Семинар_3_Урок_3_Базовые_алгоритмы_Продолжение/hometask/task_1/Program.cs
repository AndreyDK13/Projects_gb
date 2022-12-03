// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int Reverse(int number)
{
    int unnumber = 0;
    while (number > 0)
    {
        unnumber = unnumber*10 + number%10;
        number = number/10;
    }
    return unnumber;
}

void Answer(int number)
{
    if(number == Reverse(number))
    {
        Console.WriteLine($"{number} is polindrome");
    }
    else Console.WriteLine($"{number} is not polindrome");
}

// int check(int number)
// {
//     if(number == Reverse(number))
//     {
//         return System.Console.WriteLine($"{number} is polindrome");
//     }
//     else return System.Console.WriteLine($"{number} is not polindrome");
// }
// check(number);

int number = Prompt ("Input number ");
Answer (number);



