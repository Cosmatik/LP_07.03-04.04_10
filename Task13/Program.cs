// Задача 13: 
// Напишите программу, которая 
// 1.выводит третью цифру заданного числа или 
// 2.сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



int number1 = new Random().Next();
Console.WriteLine("Компьютер загадывает случайное число: "  + number1 + "  ");

if (number1 < 0) number1 = -number1;

if (ThirdDigit(number1) == -1)
  Console.WriteLine("Где третья цифра(...");
else
  Console.WriteLine($"Третья цифра загаданного числа... Вуаля:  {ThirdDigit(number1)}!");
int ThirdDigit(int number)
{
  int result = -1;
  if (number >= 100)
  {
    while (number > 999)
    {
      number = number / 10;
    }
    result = number % 10;
  }
  return result;
}