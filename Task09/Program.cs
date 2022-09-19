
// Задача 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
int firstDigi = number / 10;
int secondDigi = number % 10;

// System.Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// if (firstDigi == secondDigi)
// {
//     System.Console.WriteLine("Цифры одинаковые");
// }
// else if(firstDigi > secondDigi) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigi}");
// else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigi}");

// int maxDigit = 0;  // обычный цикл
// if(firstDigi > secondDigi) maxDigit = firstDigi;
// else maxDigit = secondDigi;

//int max = firstDigi > secondDigi ? firstDigi : secondDigi; // Тернальный оператор


int MaxDigit (int num)
{
    int firstDigi = num / 10;
    int secondDigi = num % 10;
    if(firstDigi > secondDigi) return firstDigi;
    return secondDigi;
}

bool IsEqualDigits(int num1, int num2);
int maxDigit = MaxDigit(number);
System.Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");

