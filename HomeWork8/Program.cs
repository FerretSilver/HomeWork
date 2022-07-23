//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());;
int[,] firstMassive = new int [m, n];


FillArray(firstMassive);
PrintArray(firstMassive);
Console.WriteLine();
OrderedArray(firstMassive);
Console.WriteLine("Отсортированный массив: \n");
PrintArray(firstMassive);



void OrderedArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] > array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;          
        }
      }
    }
  }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            firstMassive[i, j] = new Random().Next(0, 10); 
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

/*int [,] myArray = new int [4, 5];

FillArray(myArray);
PrintArray(myArray);
SumArray(myArray);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов №: " + MinSumRow(myArray));



int MinSumRow(int[,] array)
{
  int sum = 0;
  int minSum = 0;
  int indexMinSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {    
      for (int j = 0; j < array.GetLength(1); j++)
      if(i == 0)
      {
        sum += array[i, j];
        minSum += array[i, j];
      }
      else sum += array[i, j];            
      if (sum < minSum)
      {
        minSum = sum;
        indexMinSumRow = i;        
      }
      
      sum = 0;                   
    }    
    return indexMinSumRow + 1;   
     
}
void SumArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
    }
    Console.WriteLine($"Сумма элементов {i + 1} строки: {sum}");    
  }
}
void PrintArray(int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}
void FillArray(int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      myArray[i, j] = new Random().Next(1, 10);
    }
  }
}*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



/*int[,] firstMatrix = new int[4, 4];
int[,] secondMatrix = new int[4, 4];
int[,] multiplicationMatrix = new int[4,4];


FillArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
Console.WriteLine();
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();
MultiplicationArray(firstMatrix, secondMatrix, multiplicationMatrix);
PrintMultiplicationArray(multiplicationMatrix);




void MultiplicationArray(int[,] array, int[,] array2, int[,] multiplicationArray)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      multiplicationArray[i, j] = array[i, j] * array2[i, j];
    }
  }
}
void PrintMultiplicationArray(int[,] multiplicationArray)
{
  for (int i = 0; i < multiplicationArray.GetLength(0); i++)
  {
    for (int j = 0; j < multiplicationArray.GetLength(1); j++)
    {
      Console.Write($"{multiplicationArray[i, j] + " "}");
    }
    Console.WriteLine();
  }
}
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}*/


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
//построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 1



/*int[,,] myArray = new int[2, 1, 2];

FillArray(myArray);
PrintArray(myArray);

void FillArray(int[,,] array)
{
  
  for (int i = 0; i < array.GetLength(0); i++)
  {    
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = new Random().Next(10 , 99);
      }
    }
  }
  
}
void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {    
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
      }
      Console.WriteLine();
    }       
  }
    Console.WriteLine();
}*/