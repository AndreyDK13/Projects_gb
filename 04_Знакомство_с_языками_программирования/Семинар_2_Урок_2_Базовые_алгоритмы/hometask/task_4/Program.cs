// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать строки

// 6 -> да
// 7 -> да
// 1 -> нет


int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num = Prompt ("Номер дня в неделе ");
bool check = num > 0 && num <=7;

if (check==true) 
{
    if (num%5==2 || num%5==1)
    {
        Console.Write("выходной =)");           
    }
    else
    Console.Write("будний =(");    
}
else Console.Write("Это точно номер дня в неделе??");   
