

/*
Задача 21. Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.
А (3,6,8); В (2,1,-7) -> 15.84
А (7,-5,0); В (1,-1,9) -> 11.53
*/


Console.WriteLine("Введите координаты точек A1 и A2 ");
Console.Write("X1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("X2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());


double DistanceA1A2(double dx1, double dy1, double dz1, double dx2, double dy2, double dz2)
{
    if (dx1 == dx2 && dy1 == dy2 && dz1 == dz2)
    {
        return 0;
    }
    else
    {
    double dx = dx2 - dx1;
    double dy = dy2 - dy1;
    double dz = dz2 - dz1;
    double dA1A2 = Math.Sqrt(dx * dx + dy * dy + dz * dz);
    return dA1A2;
    }
}

double result = Math.Round(DistanceA1A2(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);

Console.WriteLine("Расстояние между точками A1 и A2 равно: " + result);


