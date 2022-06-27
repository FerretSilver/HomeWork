//Задача №2

/*Console.WriteLine("Введите два числа:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;


if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    min = firstNumber;
    max = secondNumber;
}

Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);*/


Console.WriteLine("Введите три числа:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = firstNumber;

if (secondNumber > maxNumber)
{
    maxNumber = secondNumber;
}


if (thirdNumber > maxNumber)
{
    maxNumber = thirdNumber;
}

Console.WriteLine("Максимальное число: " + maxNumber);