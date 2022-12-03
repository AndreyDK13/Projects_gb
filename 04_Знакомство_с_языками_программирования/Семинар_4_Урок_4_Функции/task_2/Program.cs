// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24



int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int Product(int number)
{
    int value = 1;
   for (int i=1; i<=number; i++)
   {
        value = value * i;
   }
   return value;
}

int number = Prompt ("Input number ");
Console.WriteLine($"Product of {number} = {Product(number)}");