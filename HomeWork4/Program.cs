//Задача 25
/*Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Degree(int numberA, int numberB)
{
int result = 1;
for(int i = 1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}
int degree = Degree(numberA, numberB);
Console.WriteLine(degree);*/

//Задача 27
/*Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int counter = Convert.ToString(numberN).Length;
int advance = 0;
int result = 0;

int SumNumber(int numberN)
{
  for (int i = 0; i < counter; i++)
  {
    advance = numberN - numberN % 10;
    result = result + (numberN - advance);
    numberN = numberN / 10;
  }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine(sumNumber);*/

//Задача 29

/*int[] myArray = new int [8];
for (int i = 0; i < myArray.Length; i++)
{
  myArray[i] = new Random().Next(1, 9);
}

PrintArray(myArray);

void PrintArray(int[] myArray)
{
  for (int i = 0; i < myArray.Length; i++)
  {
    Console.WriteLine(myArray[i] + " ");
  }
}*/

