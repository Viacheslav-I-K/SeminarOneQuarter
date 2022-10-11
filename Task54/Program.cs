
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] newMatrix = SortirovkaMatrix(matrix2D);
PrintMatrix(newMatrix);




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

int[,] SortirovkaMatrix(int[,] matrix)
{
    int[,] newMatr = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = matrix[i, j];

            for (int k = 0 + j; k < matrix.GetLength(1); k++)
            {
                if(matrix[i, k] > max)
                {
                    max = matrix[i, k];
                    int obj = matrix[i, k];
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = obj;
                }
            }
        }
    }


    return matrix;
}







