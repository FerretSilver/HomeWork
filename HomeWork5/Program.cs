//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*int[] numbers = new int[10];
int even = 0;

FillArray(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
  if(numbers[i] % 2 == 0)
  {
    even +=  1;
  }
  
}
Console.WriteLine($"Количество четных чисел {even}");

void FillArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
}

void PrintArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
  Console.WriteLine();
}*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


/*int[] numbers = new int[10];
int sumOddElement = 0;
int oddElement = 0;

FillArray(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
  if(i % 2 == 1)
  {
    oddElement = numbers[i];
    sumOddElement += oddElement;
    i++;
  }
  
}
Console.WriteLine($"Сумма  элементов с нечетными индексами {sumOddElement}");

void FillArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().Next(-10, 10);
  }
}

void PrintArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
  Console.WriteLine();
}*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] numbers = new double[10];
double maxValue = numbers[0];



FillArray(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
  if(numbers[i] > maxValue)
  {
    maxValue = numbers[i]; 
  }
}

double minValue = numbers[0];
for(int i = 0; i < numbers.Length; i++)
{
  if(numbers[i] < minValue)
  {
    minValue = numbers[i]; 
  }
}
double diffrence = maxValue - minValue;


Console.WriteLine($"Максимальный элемент: {Math.Round(maxValue, 2)}");
Console.WriteLine();
Console.WriteLine($"Минимальный элемент: {Math.Round(minValue, 2)}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом: {diffrence}");


void FillArray(double[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().NextDouble() * 10;
  }
}

void PrintArray (double[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write(Math.Round(array[i], 2) + " ");
  }
  Console.WriteLine();
  Console.WriteLine();
}
