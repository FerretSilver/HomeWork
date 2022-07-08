
// Задача 19
/*Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int oldNumber = number;
int newNumber = 0;
int digit = 0;

    while (number > 0)
    {
        digit = number % 10;
        newNumber = newNumber * 10 + digit;
        number = number / 10;
    }
    if (newNumber == oldNumber)
         Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");*/

//Задача 21

/*Console.Write("Введите X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine());
double Distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.WriteLine(Distance);*/

//Задача 23

/*Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int index = 1;
  int length = cube.Length;
  while (index <  length){
    cube[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }
}

void PrintArray(int[] number)
{
  int count = number.Length;
  int index = 1;
  while(index < count){
    Console.Write(number[index]+ " ");
    index++;
  }
}

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);*/