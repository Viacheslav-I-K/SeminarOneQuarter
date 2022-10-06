
/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

Console.WriteLine("Введите длинну стороны AB: ");
int numberAB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длинну стороны BC: ");
int numberBC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длинну стороны CA: ");
int numberCA = Convert.ToInt32(Console.ReadLine());

if (TriangleExist(numberAB, numberBC, numberCA)) Console.WriteLine($"Треугольник со сторонами AB = {numberAB}, BC = {numberBC}, CA = {numberCA} не может существовать.");
else Console.WriteLine($"Треугольник со сторонами AB = {numberAB}, BC = {numberBC}, CA = {numberCA} может существовать.");



bool TriangleExist(int numAB, int numBC, int numCA)
{
    return (numAB > numBC + numCA) || (numBC > numAB + numCA) || (numCA > numAB + numBC);
}



