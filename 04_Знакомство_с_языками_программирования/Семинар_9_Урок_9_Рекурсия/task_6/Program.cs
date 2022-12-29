// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool SimpleNumber(int number,int divider)
{
    if(divider==1)
    {
        return true;
    }
    if(number%divider!=0)
    {
        return SimpleNumber(number,divider-1);
    }
    else
    {
        return false;
    }
}
bool SimpleNumberPublic(int number)
{
    return SimpleNumber(number,number-1);
}


int number = Prompt("Input number ");
System.Console.WriteLine(SimpleNumberPublic(number));