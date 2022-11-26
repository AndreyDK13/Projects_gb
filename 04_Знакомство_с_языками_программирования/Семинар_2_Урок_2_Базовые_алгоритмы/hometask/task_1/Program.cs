// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num = Prompt ("Введите трехзнчаное число ");
int check = num/100;

if (num > 0 && check > 0 && check <= 10) 
{
    int var = (num - num%10)%100/10;
    Console.Write($"Второе число в номере - {var}");    
}
else if (num < 0 && check < 0 && check >= -10) 
{
    int var = -(num - num%10)%100/10;
    Console.Write($"Второе число в номере - {var}");    
}
else Console.Write($"Число {num} не трехзначное, не обманывайте!");    

