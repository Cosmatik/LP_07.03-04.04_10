// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Пример:
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// *Функция Аккермана — простой пример вычислимой функции , 
// которая не является примитивно рекурсивной . 
// Она принимает два неотрицательных целых числа 
// в качестве параметров и возвращает натуральное число , обозначается A (m,n).


Console.Write("Введите число M: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите число N: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

AkkermanFunction(m,n);


void AkkermanFunction(int m, int n)
{
    Console.Write(Akk(m, n)); 
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));
    }
}


// Другое решение:

// using System;

// public class Program {
    // public static int Ackermann(int m, int n) {
        // if (m == 0) {
            // return n + 1;
        // }
        // else if (n == 0) {
            // return Ackermann(m - 1, 1);
        // }
        // else {
            // return Ackermann(m - 1, Ackermann(m, n - 1));
        // }
    // }
    
    // public static void Main() {
        // int m = 2, n = 3;
        // Console.WriteLine("A({0},{1}) = {2}", m, n, Ackermann(m, n));
        
        // m = 3; n = 2;
        // Console.WriteLine("A({0},{1}) = {2}", m, n, Ackermann(m, n));
    // }
// }