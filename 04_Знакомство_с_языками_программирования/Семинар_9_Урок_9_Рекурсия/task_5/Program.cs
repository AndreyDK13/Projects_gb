// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”



int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool Power2Check(int number)
{
    if (number==2)
    {
        return true;
    }    
    return (number%2==0) && Power2Check(number = number/2);
}

int number = Prompt("Input number ");
System.Console.WriteLine(Power2Check(number));