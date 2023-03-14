// Задача 10: 
// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



int number = new Random().Next(100, 999);
Console.WriteLine("Получаем случайное трехзначное число "+number+"");
if (number < 0) number = -number;
int finalResult = ShowSecondDigit(number);
int ShowSecondDigit(int number)
{
  int firstDigit = number / 10;
  int secondDigit = firstDigit % 10;
  int result = secondDigit;
  return result;
}
Console.WriteLine("Вторая цифра этого числа "+finalResult+"");
