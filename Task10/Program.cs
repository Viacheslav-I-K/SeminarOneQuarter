

/*
Задача 10. Напишите программу, которая 
принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ValencyTwo(int num)
{
    int num1 = num / 100;
    int num2 = num - num1 * 100;
    int res = num2 / 10;
    return res;
}

int valency = number / 100;
if (valency < 1 || valency > 9)
{
    Console.WriteLine($"Введенное число {number} не верное. Число должно быть положительное и трёхзначное");
}
else
{
int result = ValencyTwo(number);
Console.WriteLine($"Вторая цифра числа {number} равна: {result}");
}

