

// Задача 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("Введите число (A), которое надо проверить на кратность двух чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите первое число (B), для проверки числа (A) = {number} на кратность (B): ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите второе число (C), для проверки числа (A) = {number} на кратность (C): ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder;

int Multiplicity (int num1, int num2, int num3)
{
    int remainderFirst = num1 % num2;
    int remainderSecond = num1 % num3;
    
    if (remainderFirst == 0 && remainderSecond == 0) return remainder = 0;
    return remainder = 1;
}

int result = Multiplicity(number, firstNumber, secondNumber);
if (result == 0)
{
    Console.WriteLine($"Число (A) = {number} кратно одновременно числу (B) = {firstNumber} и числу (C) = {secondNumber}.");
}
else
{
    Console.WriteLine($"Число (A) = {number} не кратно одновременно числу (B) = {firstNumber} и числу (C) = {secondNumber}.");
}