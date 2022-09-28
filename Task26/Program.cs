
/*
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int QuantityNumber(int num)
{
    int quantity = 0;
    while (num > 0)
    {
        num = num / 10;
        quantity++;
    }
    return quantity;

}

int quantityNumber = QuantityNumber(number);
if (number > 0)
{
    Console.WriteLine($"В числе {number} => {quantityNumber} цифр.");
}

else
{
    Console.WriteLine("Введено некорректное число.");
}






