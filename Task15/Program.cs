﻿

/*
Задача 15. Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет.
*/

Console.WriteLine("Введите цифру от 1 до 7 обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());
 switch (day)
 {
    case 1:
        Console.WriteLine("Этот день недели Понедельник. Понедельник не является выходным днем.");
        break;
    case 2:
        Console.WriteLine("Этот день недели Вторник. Вторник не является выходным днем.");
        break;
    case 3:
        Console.WriteLine("Этот день недели Среда. Среда не является выходным днем.");
        break;
    case 4:
        Console.WriteLine("Этот день недели Четверг. Четверг не является выходным днем.");
        break;
    case 5:
        Console.WriteLine("Этот день недели Пятница. Пятница не является выходным днем");
        break;
    case 6:
        Console.WriteLine("Этот день недели Суббота. Суббота является выходным днем.");
        break;
    case 7:
        Console.WriteLine("Этот день недели Воскресенье. Воскресенье является выходным днем.");
        break;
    default:
        Console.WriteLine("Такого дня недели нет! Введите число от 1 до 7.");
        break;
 }



