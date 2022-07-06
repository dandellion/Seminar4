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
int number = GetNumber("Введите число");
int summ = 0;
var div = 0;
while (number>0)
{
    div = number%10;
  summ=summ+div;
  number=number/10;  
}
Console.WriteLine(summ);
