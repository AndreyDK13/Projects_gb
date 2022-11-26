// Задача 1: Напишите программу
// , которая на вход принимает два числа и выдаёт
// , какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Масштабируем: из заданного количества целых чисел выбираем наибольшее и наименьшее


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int count = Prompt ("Количество чисел ");
int min = 0;
int max = 0;
int index = 1;



while (index<=count)
{
    int value = Prompt ("Число №" + index);
     if (index == 1)
     {
         min = value;
         max = value;
         index ++;
     }
    else if (value <= min)
    {
        min = value;
        index ++;
    }
    else if (value >= max)
    {
        max = value;
        index ++;
    }
    else index ++;
}

Console.WriteLine("MIN = " + min);
Console.WriteLine("MAX = " + max);