// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.


// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите десятичное число: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

int digits = GetNumberOfDigits(number);

int[] array = GetArray(digits);

PrintArray(array);



if(!isParsed)                                     
{                                                 
    Console.WriteLine("Неверное число");
    return;
}

int GetNumberOfDigits(int number)               
{                                                   
  int digits = 0;                                  
    while (number > 0)
  {
    number /= 2;
    digits ++;
  }
 return digits;
}

int[] GetArray(int digits)          
{
    int length = digits;      
    int[] array = new int[length];        
    for (int i = length-1; i >= 0 ; i--)   
    {
        array[i] = number % 2;             
        number = number / 2;
    }
    return array;
}


 void PrintArray(int[] array)              
{
       Console.WriteLine(@"Двоичное число [{0}]", string.Join("", array)); 
}                                        