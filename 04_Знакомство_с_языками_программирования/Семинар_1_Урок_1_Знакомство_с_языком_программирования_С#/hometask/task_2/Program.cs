// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

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