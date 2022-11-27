﻿// Напишите программу, которая по заданному номеру четверти
// , показывает диапазон возможных координат точек 
// в этой четверти (x и y)

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int quarter = Prompt ("Введите номер четверти:");

switch (quarter)
{
    case 1:
        System.Console.WriteLine($"Диапазон значений x>0, y>0");
        break;
    case 2:
        System.Console.WriteLine($"Диапазон значений x<0, y>0");
        break;        
    case 3:
        System.Console.WriteLine($"Диапазон значений x<0, y<0");
        break;
    case 4:
        System.Console.WriteLine($"Диапазон значений x>0, y<0");
        break; 
    default:
        System.Console.WriteLine($"Это не соответствует номеру четверти!");
        break;                    
}
