
/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
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

int[] minIndex = MinMatrixInd(matrix2D);
Console.Write("Минимальное число = " + matrix2D[minIndex[0], minIndex[1]]);

Console.WriteLine();

int[,] resuleMatrix = DeleteMinRowsColumn(matrix2D, minIndex);
PrintMatrix(resuleMatrix);





int[] MinMatrixInd(int[,] matrix)
{
    int[] resultindex = {0, 0};
    int minValue = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                resultindex[0] = i;
                resultindex[1] = j;
            }
        }
    }
    return resultindex;
}

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

int[,] DeleteMinRowsColumn(int[,] matrix, int[] minIndex)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int i1 = 0;
    int j1 = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        
        if (i1 == minIndex[0])i1++;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (j1 == minIndex[1])j1++;
            result[i,j] = matrix[i1,j1];
            j1++;
        }
        i1++;
        j1 = 0;
    }
    return result;
}

