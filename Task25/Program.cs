
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


Console.WriteLine("Введите числа А и В для возведения числа А в натуральную степерь В ");
Console.Write("A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Degree(int numA, int numB)
{
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
         result = result * numA;
    }
    return result;
}

if (numberA > 0 && numberB > 0)
{
int degree = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно: {degree}.");
}
if (numberA < 1) Console.WriteLine($"Введено некорректное число A - {numberA}.");
if (numberB < 1) Console.WriteLine($"Введено некорректное число B - {numberB}.");

