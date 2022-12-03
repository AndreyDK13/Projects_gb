// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int diff(int number1, int number2)
{
    int diff = number1 - number2;
    return diff;
}

int square(int number)
{
    int square = number * number;
    return square;
}

double distance(int num1, int num2, int num3)
{
    double distance = Math.Sqrt(num1+num2+num3);
    return distance;
}

int x1 = Prompt ("Input x1 ");
int y1 = Prompt ("Input y1 ");
int z1 = Prompt ("Input z1 ");
int x2 = Prompt ("Input x2 ");
int y2 = Prompt ("Input y2 ");
int z2 = Prompt ("Input z2 ");
double dist = distance(square(diff(x1,x2)), square(diff(y1,y2)), square(diff(z1,z2)));
Console.WriteLine($"Distance is {dist}");
