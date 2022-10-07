
/*
Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1 и y = k2 * x + b2.");
Console.WriteLine("Для нахождения точки пересечения двух прямых введите значения:");

Console.Write("k1 = ");
double numberK1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b1 = ");
double numberB1 = Convert.ToInt32(Console.ReadLine());

Console.Write("k2 = ");
double numberK2 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
double numberB2 = Convert.ToInt32(Console.ReadLine());

double[] IntersectionCoordinates(double numK1, double numB1, double numK2, double numB2)
{
    double[] arrayXY = new double[2];
    double CoorX = (numB2 - numB1) / (numK1 - numK2);
    double CoorY = numK1 * CoorX + numB1;
    arrayXY[0] = Math.Round((CoorX), 2, MidpointRounding.ToZero);
    arrayXY[1] = Math.Round((CoorY), 2, MidpointRounding.ToZero);
    return arrayXY;
}

void PrintArray(double[] array)
{
    Console.Write("Координаты точки пересечения двух прямых (");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.WriteLine($"{array[i]})");
    }
}

if (numberK1 == numberK2 || numberB1 == numberB2) Console.WriteLine("Прямые параллельные.");
else
{
double[] intersectionCoordinates = IntersectionCoordinates(numberK1, numberB1, numberK2, numberB2);
PrintArray(intersectionCoordinates);
}




