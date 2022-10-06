
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


// Первый способ с вводом колличества чисел.

// Console.WriteLine("Введите количество чисел, которые вы бы хотели проверить: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int GreaterZero(int sizeNum)
// {
//     int counter = 0;
//     int num = default;
//     for (int i = 0; i < sizeNum; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} число: ");
//         num  = Convert.ToInt32(Console.ReadLine());
//         if (num > 0) counter++;
//     }
//     return counter;
// }

// int numbersGreaterZero = GreaterZero(size);
// Console.WriteLine($"{numbersGreaterZero} чисел больше нуля.");



// Console.WriteLine("Введите количество чисел, которые вы бы хотели проверить: ");
// int size = Convert.ToInt32(Console.ReadLine());


int GreaterZero()
{
    int result = 0;
    int counter = 0;
    string num = default;
    int number = default;
    while (num != "")
    {
        Console.WriteLine($"Введите {counter + 1} число: ");
        num  = Console.ReadLine();
        if (num == "") break;
        else
        {
           number = Convert.ToInt32(num);
           if (number > 0)
           {
            result++;
            counter++;
           }
        }
    }
    return result;
}

Console.WriteLine("Введите числа без пробелов и знаков. Допускается только знак минус.");
Console.WriteLine("Для окончания ввода, при запросе ввода числа нажмите (Enter).");

int numbersGreaterZero = GreaterZero();
Console.WriteLine($"{numbersGreaterZero} чисел больше нуля.");
