
/*
Задача 19. Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет 
23432 -> да
12821 -> да
*/

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string flipOver = FlipOver(number);
string result = flipOver != "-1" ? $"Число {number} {flipOver} палиндромом." : "Введено не корректное число.";

Console.Write(result);


string FlipOver(int num)
{
    if (num > 0 || num < 0)
    {
        if (num / 10000 == num % 10)
        {
            if ((num % 10000) / 1000 == (num % 100) / 10)
         {
                return "является";
            }
            else
            {
                return "не является";
            }
        }
        else
        {
            return "не является";
        }
    }
    else
    {
        return "-1";
    }
}

