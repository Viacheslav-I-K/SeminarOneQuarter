

/*
Задача 13. Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что
третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.WriteLine("Введите число большее 99: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberValencyThree(int num)
{
    //int numVal = num;
    while (num / 1000 >= 1)
    {
        num = num / 10;
    }
    int res = num % 10;
    return res;
}

if (number < 100 && number > -100)
{
    Console.WriteLine($"В числе {number} третьей цифры нет.");
    
}
else
{
int result = NumberValencyThree(number);
    if (result > 0)
    {
        Console.WriteLine($"Третья цифра числа {number}: {result}");
    }
    else
    {
       Console.WriteLine($"Третья цифра числа {number}: {result * -1}"); 
    }

}


