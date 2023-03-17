// Задача 26: 
// Напишите программу, которая: 
// 1.принимает на вход число и 
// 2.выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2



Console.Write("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());
int countDigit = CountDigit(number);

Console.WriteLine($"Количество цифр в числе {number}: {countDigit}");

int CountDigit(int num)
{
    int count = 0;

    while (num != 0) //num не равно 0
    {
        count++;
        num /= 10;        
    }

    return count;
}