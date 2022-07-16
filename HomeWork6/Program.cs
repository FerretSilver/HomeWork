//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Это решение которое разбирали на семинаре. Не совсем все понял. Пересмотреть семинар пока нет возможности(его еще нет в записи). Поэтому ниже решил по-своему)
/*Console.WriteLine("Введите числа через запятую: ");
string numbersString = Console.ReadLine() ?? "";
int[] numbers = ParseArray(numbersString, ',');
PrintArray(numbers);
int count = 0;
for(int i = 0; i< numbers.Length; i++)
{
    if(numbers[i] > 0)
        count++;
}
Console.WriteLine(count);

int[] ParseArray(string input, char separator)
{
    int[] numbers = new int[GetCountNumbersInString(input)];
    string subString = String.Empty;
    int numbersIndex = 0;
    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == separator)
        {
            numbers[numbersIndex++] = Convert.ToInt32(subString);
            subString = String.Empty;
        }
        else
        {
            subString += input[i];
        }
    }
    numbers[numbersIndex] = Convert.ToInt32(subString);
    return numbers;
}
int GetCountNumbersInString(string numbers)
{
    int countNumbers = 1;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] == ',')
            countNumbers++;
    }
    return countNumbers;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}*/



//Мое решение попроще. Здесь нет строки элементов, каждый вводится отдельно. "Специфический код заданий" вынес в отдельный метод)

/*Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] fillArray = new int[m];
int count = 0;
InputNumbers(m);
PrintArray(fillArray);

int Selection(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0)
    count++; 
  }
  return count;
}

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write("Введите число: ");
    fillArray[i] = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine();
}
void PrintArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    Console.Write(array[i] + ", ");
  }
  Console.WriteLine();
  Console.WriteLine();
}
Console.WriteLine("Введено чисел больше нуля: " + Selection(fillArray));*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
double k1 = InputInt("k1 = ");
double b1 = InputInt("b1 = ");
double k2 = InputInt("k2 = ");
double b2 = InputInt("b2 = ");

if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения равна [{x}, {y}]");

double InputInt(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}*/

