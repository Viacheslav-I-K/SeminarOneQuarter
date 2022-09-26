
/*
Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/


Console.WriteLine("Введите число N, для вывода таблицы квадратов чисел от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 1;
int numberSqr;

 if (number <= 0) Console.WriteLine("Введено некорректное число");
 while (num <= number)
 {
    numberSqr = num * num;
    Console.WriteLine($"{num, 3}    {numberSqr, 3}");
    num++;
 }


