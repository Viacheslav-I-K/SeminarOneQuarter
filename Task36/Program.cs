
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int numberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int numberMax = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(sizeArray, numberMin, numberMax);
Console.Write("Исходный массив: ");
PrintArray(arr);

int notEvenIndexElemArray = NotEvenIndexElemArray(arr);
Console.Write($"Сумма элементов, стоящих на нечётных позициях = {notEvenIndexElemArray}.");



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

int NotEvenIndexElemArray(int[] array)
{
    int sumNotEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sumNotEvenNumbers += array[i];
    }
    return sumNotEvenNumbers;
}
