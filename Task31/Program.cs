
/*
Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве: ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве: ");
int maxArray = Convert.ToInt32(Console.ReadLine()); 

int[] createArrayRndInt(int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");

}

int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPositive += array[i];
    }
    return new int[]{sumPositive, sumNegative};
}

int GetSumPositiveElem(int[] array)
{
    int sumPositive = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
    }
    return sumPositive;
}

int GetSumNegativeElem(int[] array)
{
   int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
    }
    return sumNegative; 
}

int[] arr = createArrayRndInt(sizeArray, minArray, maxArray);
PrintArray(arr);
int sumPositive = GetSumPositiveElem(arr);
int sunNegative = GetSumNegativeElem(arr);

Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sunNegative}");

