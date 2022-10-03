
/*
Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int numberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int numberMax = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int numMin, int numMax)
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(numMin, numMax + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

int EvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0) count++;

    }

return count;
}

int[] arr = CreateArrayRndInt(sizeArray, numberMin, numberMax);

Console.Write("Исходный массив заполненый случайными числами: ");
PrintArray(arr);

int eventNumbers = EvenNumbers(arr);

if (eventNumbers > 0) Console.Write($"В заданном массиве {eventNumbers} чётных чисел.");

else Console.Write("Чётные числа в массиве отсутствуют.");

