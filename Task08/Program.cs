/* 8. Напишите программу, которая на вход 
принимает (N), а на выходе показывает все чётные 
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8.
*/

Console.Write("Введите целое положительное число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (number < 1)
{
    Console.WriteLine("Введено не корректное число. Число должно быть положительным и большим нуля!");
}

if (number == 1)
{
    Console.WriteLine("В промежутке от 1 до введёного числа отсутствуют чётные числа!");
}

while (i <= number)
{
   int remains = i % 2;

   if (remains == 0)
   {
        Console.Write($"{i} ");
   }
   i++;
}