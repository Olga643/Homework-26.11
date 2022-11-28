// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()??"");
    return result;
}

int SumNumbers(int m, int n)
{
    if ( n == m) return n;
    else return  m + SumNumbers (m + 1, n);
}    

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");

Console.WriteLine();
Console.Write(SumNumbers(m, n));