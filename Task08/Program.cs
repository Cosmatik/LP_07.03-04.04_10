﻿// 8. Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (number == 1) Console.WriteLine("В числе "+number+" нет четных чисел!");
while (i <= number)
{
  if (i % 2 == 0)
  {
    Console.Write(i + ", ");
  }
  i++;
}