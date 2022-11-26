// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Масштабируем: выводим все числа от 1 до number, кратные заданному

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt ("Введите число ");
int div = Prompt ("Введите делитель ");
int index = 0;
int result = 0;

if (div==0)
{
    Console.Write("Нулю все числа кратны будут..");
}
else if (number >= div)
{
        while (index<number)
            {
                index = index + 1;
                if (index%div==0)
                {
                    result = index;
                    Console.Write($"{result}, ");
                }
            }
}
else Console.Write($"Вряд ли найдется число от 1 до {number}, кратное {div}");