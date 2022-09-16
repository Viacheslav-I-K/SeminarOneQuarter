 /* 1. Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет 
*/
Console.WriteLine("Уважаемый пользователь! После ввода двух целых чисел мы проверим, является ли первое число квадратом второго.");
Console.Write("Введите первое целое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberTwo * numberTwo == numberOne)
{
    Console.Write($"Да, число {numberOne} является квадратом числа {numberTwo}.");
}
else
{
    Console.Write($"Нет, число {numberOne} не является квадратом числа {numberTwo}.");
}