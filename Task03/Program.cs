﻿// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите целое число:  ");


int a = Convert.ToInt32(Console.ReadLine());

if( a == 1)
{

Console.WriteLine($"Номер {a} - Понедельник");

}

if( a == 2)
{

Console.WriteLine($"Номер {a} - Вторник");

}

if( a == 3)
{

Console.WriteLine($"Номер {a} - Среда");

}

if( a == 4)
{

Console.WriteLine($"Номер {a} - Четверг");

}

if( a == 5)
{

Console.WriteLine($"Номер {a} - Пятница");

}

if( a == 6)
{

Console.WriteLine($"Номер {a} - Суббота");

}

if( a == 7)
{

Console.WriteLine($"Номер {a} - Воскресенье");

}

if(a > 7)

{

Console.WriteLine($"Номер {a} - Покажет несуществующий день недели");

}
