﻿//Задача №2

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
Console.WriteLine("Минимальное число: " + min);


Задача №4

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


Задача №6

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0)
{
    Console.WriteLine("Четное!");
}
else
{
    Console.WriteLine("Не четное!");
}


Задача №*/

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;
int even = index % 2;
string str = "";
while (index <= n)
{
    str = str + " " + index++;
}
if (even == 0)
{
    even += 1;
Console.Write(even);
}



