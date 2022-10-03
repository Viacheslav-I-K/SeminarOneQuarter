
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int numberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int numberMax = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArrayRndInt(sizeArray, numberMin, numberMax);
PrintArray(arr);

double diffMaxMin = DifferenceMaxMin(arr);
Console.Write("Разница между максимальным и минимальным элементом массива = " + diffMaxMin);


double[] CreateArrayRndInt(int size, int numMin, int numMax)
{
    Random rnd = new Random();
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * ((numMax - numMin) + numMin), 1, MidpointRounding.ToZero);
    }
    return array;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

double DifferenceMaxMin(double[] array)
{
    double diff = default;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}






