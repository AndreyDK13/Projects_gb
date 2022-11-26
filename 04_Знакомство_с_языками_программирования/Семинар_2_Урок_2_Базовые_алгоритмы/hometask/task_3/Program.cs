// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . Не использовать строки

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num = Prompt ("Введите число ");
int check = num/100;

if (num > 0 && check > 0) 
{
    int var = (num-num%100)%1000/100;
    Console.Write($"Третья цифра в числе - {var}");    
}
else if (num < 0 && check < 0) 
{
    int var = -(num-num%100)%1000/100;
    Console.Write($"Третья цифра в числе - {var}");    
}
else Console.Write($"В числе {num} нет трех цифр!");    

