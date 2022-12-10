

// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник 
// с сторонами такой длины.

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckSizes(int A, int B, int C)
{
    if (A+B>C)
    {
        return true;
    }

    return false;
}

int A = Promt ($"Сторона A = ");
int B = Promt ($"Сторона B = ");
int C = Promt ($"Сторона C = ");
if (CheckSizes(A,B,C) && CheckSizes(B,A,C) && CheckSizes(C,B,A))
{
    Console.WriteLine ("Такой треугольник существует");
}
else 
{
    Console.WriteLine ("Такой треугольник НЕ существует");
}