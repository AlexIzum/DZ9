// Задача 66:  Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите начальное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int n = Convert.ToInt32(Console.ReadLine());
SummNumbers(m, n, 0);

void SummNumbers(int m, int n, int sum)
  {if (m > n)
    {Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;}
   sum = sum + (m++);
   SummNumbers(m, n, sum);}

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30