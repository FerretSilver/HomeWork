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

Console.WriteLine("Введите индекс строки:" );
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца:" );
int column = Convert.ToInt32(Console.ReadLine());
int [,] myArray = new int [10, 10];
FillArray(myArray);
PrintArray(myArray);
Fools(myArray);
Console.WriteLine($"Значение ячейки:  {myArray[row, column]}");
void Fools(int[,] array)
{
    if (row < 0 || row > 9 | column < 0 || column > 9)
    {           
        Console.WriteLine("Такого элемента нет!");
    }
    return; 
}


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


