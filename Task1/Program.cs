int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}
int numberOne = GetNumber("Введите первое число");
int numberTwo = GetNumber("Введите второе число");
int result = 1;
for (int i = 1; i <= numberTwo; i++)
{
    result=result*numberOne;
}
Console.WriteLine(result);