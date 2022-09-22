
// Задача 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int square;

int Square(int num1, int num2)
{
    int squareNum1 = num1 * num1;
    int squareNum2 = num2 * num2;
    if (squareNum1 == num2) return square = 0;
    else if (squareNum2 == num1) return square = 1;
    return square = -1;
}

int result = Square(firstNumber, secondNumber);
if (result == 0)
{
    Console.WriteLine($"Чисело {secondNumber} является квадратом числа {firstNumber}.");
}
else if (result == 1)
{
    Console.WriteLine($"Чисело {firstNumber} является квадратом числа {secondNumber}.");
}
else
{
    Console.WriteLine($"Ни одно из чисел ({firstNumber}, {secondNumber}) не является квадратом другого.");
}


