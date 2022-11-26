// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Масштабируем: проверяем число на кратность другому числу (т.е. 2, 3 и тп на выбор)


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt ("Введите число ");
int div = Prompt ("Введите делитель ");

if (number%div == 0)
{
    Console.WriteLine($"Число {number} кратно {div}");
}
else Console.WriteLine($"Число {number} НЕ кратно {div}");