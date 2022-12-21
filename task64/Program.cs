// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());
Summ(number);
void Summ (int number)
    {if (number < 0) Console.Write($"{number} не натуральное число");
     if (number == 0) return;
     Console.Write("{0,4}", number);
     Summ (number - 1);}
