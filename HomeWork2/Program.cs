using System;
class HelloWorld {
  static void Main() {
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
  }
}