// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("введите целое число! ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);

int SumDigit(int a)
{
  int number = 0;

  while (a > 0)
  {
    number += a % 10;
    a = a / 10;
  }
  return number;
}
Console.WriteLine("Cумма всех цифр в заданном числе " + number + " равна: " + sumDigit);
