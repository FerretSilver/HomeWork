//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.WriteLine("Введите количество строк:" );
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:" );
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] massive = new double[m, n];

// FillArray(massive);
// PrintArray(massive);

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {   
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array[i, j], 2) + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine();

// void FillArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            massive[i, j] = new Random().NextDouble() * 10;
//         }
//     }
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
/*
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс строки:" );
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца:" );
int column = Convert.ToInt32(Console.ReadLine());
int [,] myArray = new int [rows, columns];


FillArray(myArray);
PrintArray(myArray);
Console.WriteLine(myArray[row, column]);

if(row > rows || column > columns)
{
    Console.WriteLine("Такого индекса нет!");
}
return;


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(0, 10); 
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
}
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());;
int[,] massive = new int [m, n];



FillArray(massive);
PrintArray(massive);


for (int i = 0; i < n; i++)
{
  double average = 0;
  for (int j = 0; j < m; j++)
  {
    average += massive[j, i];
  }
  average = Math.Round(average / m, 1);
  Console.WriteLine($"Среднее арифметическое столбца {i+1}: {average}");
}*/


