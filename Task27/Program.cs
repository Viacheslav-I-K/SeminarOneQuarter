
/*
Задача 27: Напишите программу, которая принимает
 на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    
    int result = 0;
    while (num > 9)
    {
        result = result + num % 10;
        num = num / 10;   
    }

    result = result + num;
    return result;
}

if (number > 0)
{
int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} = " + sumNumber);
}
else Console.WriteLine("Введено некорректное число.");




