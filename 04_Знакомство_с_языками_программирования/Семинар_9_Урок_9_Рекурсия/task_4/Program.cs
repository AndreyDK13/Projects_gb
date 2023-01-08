// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”




int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Power(int number, int power)
{
    if (power ==0)
    {
        return 1;
    }
    return number*Power(number, power-1);
}

int number = Prompt("Input number ");
int power = Prompt("Input power ");
System.Console.Write(Power(number, power));