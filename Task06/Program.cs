﻿// 6. Напишите программу, которая на вход 
//    принимает число и выдает, является ли число четным 
//    (делится ли оно на два без остатка).


// 4 -> Да
// -3 -> Нет
// 7 -> Нет



Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
  Console.WriteLine("Целое число " + number + " Есть четное число! ");
}
else
{
  Console.WriteLine("Целое число " + number + " Есть нечетное число! ");
}
