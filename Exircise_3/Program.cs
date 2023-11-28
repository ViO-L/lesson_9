// / Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = Print("Input N: ");

int Print(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

if (n < 1)
{
  Console.WriteLine("Повторите ввод!");
  return;
}
Console.WriteLine(NaturalNumber(n, 1));