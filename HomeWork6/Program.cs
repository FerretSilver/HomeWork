//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*Console.WriteLine(" Введите количество элементов массива:");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];
int positiveNumber = 0;

FillArray(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
  if(numbers[i] > 0)
  {
    positiveNumber++;
  }
  
}
Console.WriteLine($"Количество чисел больше нуля: {positiveNumber}");

void FillArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().Next(- 10, 10);
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
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");