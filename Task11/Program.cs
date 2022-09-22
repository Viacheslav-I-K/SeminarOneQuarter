
// Задача 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное число из промежутка (от 100 до 999) = " + number);
int number0 = number / 100;
int number2 = number % 10;
Console.WriteLine($"Результат {number0}{number2}");

// 1-23