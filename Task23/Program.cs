
/*
Задача 23. Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.Write("Введите число большее нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeNumber(number);


void CubeNumber(int num)
{
    int i = 1;
    if (num > 0)
    {
        while (i <= num)
        {
            Console.WriteLine($"{i, 5}  {i * i * i, 5}");
            i++;
        }
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число");
    }
}


