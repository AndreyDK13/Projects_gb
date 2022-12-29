// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
// ; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Правильно решать без массивов, т.к. оптимально через формулы

int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

// double[] GenerateArray(int len)
// {
//     double[] array = new int[len];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-1000.0, 10000.0);
//     }
//     return array;
// }

double Function (double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return (y);
}

double IntPoint (double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    return (x);
}

int b1 = Prompt ("Input b1 ");
int k1 = Prompt ("Input k1 ");
int b2 = Prompt ("Input b2 ");
int k2 = Prompt ("Input k2 ");
Console.WriteLine ($"({IntPoint(k1, b1, k2, b2)};{Function(k1, b1, IntPoint(k1, b1, k2, b2))})");
