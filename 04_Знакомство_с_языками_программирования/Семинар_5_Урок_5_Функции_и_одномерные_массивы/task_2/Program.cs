// // Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray(int length, int minRange, int maxRange)
{
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minRange, maxRange + 1);
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] numbers = CreateArray(15,-10,10);
System.Console.WriteLine("Generate array");
PrintArray(numbers);
for (  int i = 0; i < numbers.Length; i++)
{
    numbers[i] = -numbers [i];
}
System.Console.WriteLine("Аrray: ");
PrintArray(numbers);