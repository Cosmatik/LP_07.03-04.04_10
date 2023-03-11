// 7. Напишите программу, которая 
// на вход принимает трехзначное число и
// на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{

    int Lastnumber = number % 10;
    Console.WriteLine(Lastnumber);
}
else
{

     Console.WriteLine("Введите целое трехзначное число! ");

}

