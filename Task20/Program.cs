
/*
Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/


Console.WriteLine("Введите координаты точки A1: ");
Console.Write("X1 = ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A2: ");
Console.Write("X2 = ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());

double DistanceA1A2(double dx1, double dy1, double dx2, double dy2)
{
    double dx = dx2 - dx1;
    double dy = dy2 - dy1;
    double dA1A2 = Math.Sqrt(dx*dx + dy*dy);
    return dA1A2;
}

double result = DistanceA1A2(x1, y1, x2, y2);
result = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками A1 и A2 составляет: {result}");

