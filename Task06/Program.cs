/* 6. Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remains = number % 2;
if (remains == 0)
{
    Console.WriteLine($"Число {number} является чётным.");
}
else
{
    Console.WriteLine($"Число {number} не является четным.");
}