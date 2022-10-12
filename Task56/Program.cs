
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


Console.Write("Введите количество строк в 2D массиве: ");
int sizeRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в 2D массиве: ");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число элемента массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число элемента массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix2D = CreaterMatrixRndInt(sizeRows, sizeColumns, minNumber, maxNumber);
PrintMatrix(matrix2D);

Console.WriteLine();

int[] maxSumNumRows = SumNumbersRows(matrix2D);
PrintArray(maxSumNumRows);

PrintMinSumRows(maxSumNumRows);


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] SumNumbersRows(int [,] matrix)
{
    int[] arraySumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arraySumRows[i] += matrix[i, j];
        }
    }
    return arraySumRows;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма элементов в {i + 1} строке |{array[i]}| ");
    }
}

void PrintMinSumRows(int[] array)
{
    int min = array[0];
    int indMin = default;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            indMin = i;
        }
    }
    Console.Write($"Минимальная сумма элементов находится в {indMin + 1} строке.");
}



