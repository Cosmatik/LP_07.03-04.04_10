﻿// Задача 30: 
// Напишите программу, которая:
// 1.выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.


// [1,0,1,1,0,1,0,0]

// Создаем массив:
int[] array = new int[8];
// Создаем 2 метода:
FillArray(array);
PrintArray(array);


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

    {
        Console.Write(array[i] + " ");
    }

}


