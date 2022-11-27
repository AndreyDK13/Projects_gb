// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt ("Input number ");
int index = 1;

int mod = number;
if (mod <0)
{
    mod = -mod;
}

while (index <= mod)
{
    int square = index * index;
    System.Console.WriteLine($"square of {index} is {square}");
    index ++;
}