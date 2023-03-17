// Задача 21. 
// Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 3D пространстве.


// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Первая точка A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья точка А: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья точка B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA,yA,zA,xB,yB,zB);
Console.WriteLine("Расстояние между данными точками в 3D пространстве = "+ distance);

double Distance(int x1,int y1,int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
    return resultRound;
}