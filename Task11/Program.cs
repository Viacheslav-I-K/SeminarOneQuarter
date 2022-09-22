
// Задача 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное число из промежутка (от 100 до 999) = " + number);


int DeleteSecontNumber(int num)
{
    int num0 = num / 100;
    int num1 = num % 10;
    int res = num0 * 10 + num1;
    return res;
}

int result = DeleteSecontNumber(number);

Console.WriteLine($"Искомое число: {result}");
