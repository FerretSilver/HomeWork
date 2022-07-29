//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> ""1, 2, 3, 4, 5""

//M = 4; N = 8. -> ""4, 5, 6, 7, 8""
/*int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");

PrintNumber(m, n);

void PrintNumber(int m, int n)
{
    if (n < m)
    return;
    PrintNumber(m, n - 1);
    Console.Write($"{n},");
}
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


/*int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");


int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine($"Сумма значений элементов = {Sum(m, n)}");

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


/*int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0)
  return n + 1;
  else if (n == 0)
  return Ack(m - 1, 1);
  else
  return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}*/

