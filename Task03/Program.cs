/* 3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.Write("Пожалуйста введите целое число от 1 до 7: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay > 0 && numberDay < 8)
{
    if (numberDay == 1)
    {
        Console.WriteLine("Сегодня понедельник!");
    }

    if (numberDay == 2)
    {
        Console.WriteLine("Сегодня вторник!");
    }

    if (numberDay == 3)
    {
        Console.WriteLine("Сегодня среда!");
    }

    if (numberDay == 4)
    {
        Console.WriteLine("Сегодня четверг!");
    }

    if (numberDay == 5)
    {
        Console.WriteLine("Сегодня пятница!");
    }

    if (numberDay == 6)
    {
        Console.WriteLine("Сегодня суббота!");
    }

    if (numberDay == 7)
    {
        Console.WriteLine("Сегодня воскресенье!");
    }
}
else
{
    Console.WriteLine("Вы ввели не верное число. Число должно быть больше нуля и меньше 7!");
}