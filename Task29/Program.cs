// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("");
if (arraySize < 7 || arraySize > 8)
{
  Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
  return;
}

int[] array1 = CreateArray(arraySize);

PrintArray(array1);

int[] CreateArray(int arrayLength)
{
  int[] newArray = new int[arrayLength];

  Random random = new Random();

  for (int i = 0; i < arrayLength; i++)
  {
    newArray[i] = random.Next(0, 11);
  }

  return newArray;
}
Console.Write("]");
void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}