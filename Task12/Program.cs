// 12. Напишите программу, которая 
// будет принимать на
// вход два числа и выводить, 
// является ли первое число
// кратным второму. 
// Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.


// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Ввведите первое число: ");
int numberA= Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Multiplicity(numberA, numberB);

if (result == 0)
{
    Console.WriteLine("Все числа кратные.");
}
else
{
    Console.WriteLine($"Остаток от деления {result}");
}

int Multiplicity(int number1, int number2)
{
    return number1 % number2;
}

int ReadConsole()
{
    var str = Console.ReadLine();
    int number = Convert.ToInt32(str);

    return number;
}