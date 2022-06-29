//Задача 9

/*Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num = (number % 100) % 10;
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









    