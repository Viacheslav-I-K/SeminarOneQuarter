
/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.Write("Введите количество строк в 2D массиве: ");
int sizeRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в 2D массиве: ");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число элемента массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число элемента массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());


int[,] matrix = CreaterMatrixRndInt(sizeRows, sizeColumns, minNumber, maxNumber);
PrintMatrix(matrix);
Console.WriteLine("Среднее арифмитическое:");

double[] arithmeticMeanElemMatrix = ArithmeticMeanElemColumnsMatrix(matrix);
PrintArray(arithmeticMeanElemMatrix);




int[,] CreaterMatrixRndInt(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}


double[] ArithmeticMeanElemColumnsMatrix(int[,] matrix)
{
    double[] arithmeticMean = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            arithmeticMean[i] += matrix[j, i];
        }
        arithmeticMean[i] = Math.Round((arithmeticMean[i] / matrix.GetLength(0)),1 ,MidpointRounding.ToZero);
    }
    return arithmeticMean;
}


void PrintArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i], 4} | ");
        else Console.Write($"{array[i], 4} ");
    }
    Console.WriteLine("|");
}




// Console.Write("[");
//     for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
//     Console.Write($"{array[array.Length - 1]}]");