int[] GetArray(int number)
{
    int[] arr = new int[8];
    Random randomizer = new Random();

    for (int i = 0; i < 8; i++)
    {
        arr[i] = randomizer.Next(-number, number);
    }

    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i< 8; i++)
    {   if (i < 7)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}
Console.WriteLine("Введите максимально возможное число в массиве");
int maxNumber = int.Parse(Console.ReadLine());
int[] array = GetArray(maxNumber);
PrintArray(array);