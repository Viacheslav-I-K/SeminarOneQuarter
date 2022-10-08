
/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
*/

Console.Write("Введите количество строк в 2D массиве: ");
int sizeRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в 2D массиве: ");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число элемента массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число элемента массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки искомого в 2D массиве элемента: ");
int searchRowsElem = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца искомого в 2D массиве элемента: ");
int searchColumnsElem = Convert.ToInt32(Console.ReadLine());



int[,] matrix = CreaterMatrixRndInt(sizeRows, sizeColumns, minNumber, maxNumber);
PrintMatrix(matrix);

if (searchRowsElem > sizeRows - 1 || searchColumnsElem > sizeColumns - 1) Console.WriteLine("Такого элемента в массиве нет.");
else
{
    int searchElemMatrix = SearchElemMatrix(matrix, searchRowsElem, searchColumnsElem);
    Console.Write($"Искомый элемент = {searchElemMatrix}");
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


int SearchElemMatrix(int[,] matrix, int numRows, int numColumns)
{
    int result = matrix[numRows, numColumns];
    
    return result;
}


