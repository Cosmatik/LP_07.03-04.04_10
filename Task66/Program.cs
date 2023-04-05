// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// Пример:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// *SumFromMToN - функция принимает два целочисленных параметра (М и N) и возвращает сумму чисел.


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);


void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}

// Другое решение:

// using System;

// class Program {
    // static void Main(string[] args) {
        // int m = 1, n = 15;
        // int count = CountNaturalNumbers(m, n);
        // Console.WriteLine("Количество натуральных чисел в диапазоне от {0} до {1}: {2}", m, n, count);
    // }

    // static int CountNaturalNumbers(int start, int end) {
        // if (start == end) {
            // if (start > 0) {
                // return 1;
            // } else {
                // return 0;
            // }
        // } else if (start < end) {
            // return CountNaturalNumbers(start, end - 1) + (end > 0 ? 1 : 0);
        // } else {
            // return CountNaturalNumbers(end, start);
        // }
    // }
// }