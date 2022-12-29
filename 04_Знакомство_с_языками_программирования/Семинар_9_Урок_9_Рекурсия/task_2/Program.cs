// Задайте значения M и N. Напишите программу,
// которая рекурсивно выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int start, int finish)
{
    if (start == finish)
    {
        return;
    }

    System.Console.Write($"{start}; ");
    PrintNumbers(start + 1, finish);
    //System.Console.Write($"{start}; ");
}

int start = Prompt("Введите число ");
int finish = Prompt("Введите число ");
PrintNumbers(start, finish);