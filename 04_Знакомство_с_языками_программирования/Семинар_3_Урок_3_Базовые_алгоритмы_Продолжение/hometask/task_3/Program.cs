// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int Cube (int number)
{
    int cube = number * number * number;
    return cube;
}

void result (int number)
{
for (int i = 1;i<=number;i++)
    {
        int result = 0;
        result =+ Cube(i);
        Console.WriteLine (result);
    }
}

int number = Prompt ("Input number ");
result (number);