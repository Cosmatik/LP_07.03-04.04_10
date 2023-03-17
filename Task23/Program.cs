// Задача 23. 
// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число!: ");
int number = Convert.ToInt32(Console.ReadLine());

TableCube(number);

void TableCube(int number)
{
  int count = 1;
  while (count <= number)
  {
    int squad = count * count * count;
    Console.WriteLine($"{count, 2} -> {squad, 6}");
    count++;
  }

}
