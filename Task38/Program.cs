﻿// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRandDoub(int size, int min, int max, int round)
{
  double[] arr = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    double number = rnd.NextDouble() * (max - min) + min;
    arr[i] = Math.Round(number, round);
  }
  return arr;
}

void PrintArray(double[] arr)
{
  Console.WriteLine("[{0}]", string.Join(", ", arr));
}

void FindDiff(double[] arr)
{
  double min = arr[0];
  double max = arr[0];
  double diff = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
  }
  diff = max - min;
  Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}.");
}

double[] array = CreateArrayRandDoub(55, -55, 50, 5);

PrintArray(array);

FindDiff(array);
