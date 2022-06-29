//Задача 10

/*Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num = (number % 10) % 10;
Console.WriteLine(num);*/



/*Задача 15
Console.WriteLine("Введите день недели по счету:");
int day = Convert.ToInt32(Console.ReadLine());

int saturday = 6;
int sunday = 7;
if (day == saturday || day == sunday)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет!");
}*/


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
if (number > 99)
{
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("Нет третьего числа!");
}



/*Задача 13

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while (true)
{
if (number <= 99)
{
    Console.WriteLine("Нет третьего числа!");
    break;
}
if (number <= 999)
{
    number = number % 10;
    Console.WriteLine(number);
    break;
}
if (number <= 9999)
{
    number = (number / 10) % 10;
    Console.WriteLine(number);
    break;
}
if (number <= 99999)
{
    number = (number / 100) % 10;
    Console.WriteLine(number);
    break;
}
if (number <= 999999)
{
    number = (number / 1000) % 10;
    Console.WriteLine(number);
    break;
}
if (number <= 9999999)
{
    number = (number / 10000) % 10;
    Console.WriteLine(number);
    break;
}
if (number <= 99999999)
{
    number = (number / 100000) % 10;
    Console.WriteLine(number);
    break;
}

}    */





    