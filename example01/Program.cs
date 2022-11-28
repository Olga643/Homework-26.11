﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()??"");
    return result;
}

string NumbersBetween(int n)
{
    
    if ( n >= 1) return $"{n}" + " " + NumbersBetween (n - 1) ;
    else return String.Empty;
}


int n = GetNumber("Введите число n:");
Console.WriteLine();
Console.Write(NumbersBetween(n));