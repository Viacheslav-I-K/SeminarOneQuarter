/* 2. Напишите программу, которая на вход
принимает два числа и выдаёт, какое число больше, а какое меньше.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
*/

Console.WriteLine("После ввода двух целых чисел мы узнаем, какое из них больше, а какое меньше");
Console.Write("Введите первое целое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
int min = numberTwo;

if (numberOne > numberTwo)
{
    Console.Write($"Число {numberOne} большее, а число {numberTwo} меньшее.");
}

if (numberOne == numberTwo)
{
    Console.Write($"Число {numberOne} равно числу {numberTwo}.");
}

if (numberOne < numberTwo)
{
    Console.Write($"Число {numberTwo} большее, а число {numberOne} меньшее.");
}
