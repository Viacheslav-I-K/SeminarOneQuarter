﻿
/*
17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.

*/


Console.Write("Введите координаты точки X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int qx, int qy)
{
    if(qx > 0 && qy > 0) return 1;
    if(qx < 0 && qy > 0) return 2;
    if(qx < 0 && qy < 0) return 3;
    if(qx > 0 && qy < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0 ? $"Указанные координаты соответствуют четверти -> {quarter.ToString()}" : "Введены некорректные координаты";

Console.WriteLine(result);
