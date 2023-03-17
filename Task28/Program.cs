// Задача 28: 
// Напишите программу, которая:
//  1.принимает на вход число N и выдаёт
//  2. произведение чисел от 1 до N.


// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;
int fact = Fact(number);
Console.WriteLine("Произведение числа "+number+" = "+fact);

int Fact(int num)
{
  int res = 1;
  for (int i = 1; i <= num; i++)
  {
    res *= i; //res = res+i;
  }
  return res;
}