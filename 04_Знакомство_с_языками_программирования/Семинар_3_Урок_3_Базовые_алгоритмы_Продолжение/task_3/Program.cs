// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Prompt ("Input x1 ");
int x2 = Prompt ("Input x1 ");
int y1 = Prompt ("Input y1 ");
int y2 = Prompt ("Input y2 ");
double distnace = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));

Console.WriteLine($"Distance is {distnace} >");