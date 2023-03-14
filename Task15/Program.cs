// Задача 15: 
// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.


// 6 -> да
// 7 -> да
// 1 -> нет





 Console.Write("введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
  Console.Write("Понедельник");
 }
else if (day == 2)
{
  Console.Write("Вторник");
}
 else if (day == 3)
 {
  Console.Write("Среда");
}
else if (day == 4)
{
  Console.Write("Четверг");
 }
else if (day == 5)
 {
  Console.Write("Пятница");
 }
 else if (day == 6)
{
   Console.Write("Суббота");
 }
else if (day == 7)
 {
  Console.Write("Воскресенье");
 }
else
{
   Console.Write($"В неделе всего семь дней! ");
 }

 if (day < 6) Console.WriteLine($" - Рабочий день!"); 
 if (day > 5 && day < 8) Console.WriteLine($" Выходной!"); 


// 3 РЕШЕНИЕ (ОПТИМАЛЬНОЕ)

// Console.Write("Введите номер дня недели: ");
// int num = int.Parse(Console.ReadLine());
// if (num >= 1 && num <= 5)
// {
//   Console.Write(" Нет, это не выходной");
// }
// else if (num >= 6 && num <= 7)
// {
//   Console.Write(" Да, это выходной");
// }
// else Console.Write(" Не существует такого дня недели");