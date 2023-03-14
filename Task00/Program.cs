// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдает его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 49
// -7 -> 49


// Console.Write("Введите любое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;

Console.WriteLine($"Квадрат числа {number} = {square} ");

